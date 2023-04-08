using CounterpartyService.Repositories;
using CounterpartyService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CounterpartyService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<ICounterpartyRepository, CounterpartyRepository>();

            var connectionString = $"Host=localhost;Port=5432;Username=admin;Password=admin;Database=our-practice-database";
            builder.Services.AddDbContext<ApplicationBbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            }
            );

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationBbContext>();
                var pendingMigrations = dbContext.Database.GetPendingMigrations();
                foreach (var pendingMigration in pendingMigrations)
                {
                    Console.WriteLine(pendingMigration);
                }
                dbContext.Database.Migrate();
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapControllers();

            app.Run();
        }
    }
}