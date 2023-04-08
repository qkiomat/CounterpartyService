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

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ICounterpartyRepository, CounterpartyRepository>();

            var connectionString = $"Host=localhost;Port=5432;Username=admin;Password=admin;Database=counterparty-service-database";
            builder.Services.AddDbContext<ApplicationBbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            }
            );

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

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}