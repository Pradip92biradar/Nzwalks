using Microsoft.EntityFrameworkCore;
using Nzwalks.API.Data;
using Nzwalks.API.Repositories;


var builder = WebApplication.CreateBuilder(args);

//Add service to the container
builder.Services.AddController();

//Learn More about Configuring Swagger/Open API at https://aka.ms/aspnetcore/PradipBiradar
builder.Services.AddEndPointsApiExplore();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<NzwalksDBContext>(Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("NzWalks"));
});
builder.Services.AddScoped<IRegionRepository, RegionRepository>();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

//Configure the HTTP request Pipeline.
if (app.Environment.IsDevelopement())
{
    app.UseSwaggger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();





namespace Nzwalks.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
