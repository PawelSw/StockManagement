using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLog.Web;
using StockManagement.ApplicationServices.API.Domain;
using StockManagement.ApplicationServices.API.Validators.ItemCaseValidator;
using StockManagement.ApplicationServices.Mappings;
using StockManagement.Authentication;
using StockManagement.DataAccess;
using StockManagement.DataAccess.CORS;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
builder.Host.UseNLog();

builder.Services.AddAuthentication("BasicAuthentication")
   .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


// Add services to the container.
builder.Services.AddMvcCore()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddItemCaseRequestValidator>());
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddAutoMapper(typeof(ItemsProfile).Assembly);
builder.Services.AddMediatR(typeof(ResponseBase<>));
builder.Services.AddTransient<IQueryExecutor, QueryExecutor>();
builder.Services.AddTransient<ICommandExecutor, CommandExecutor>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddDbContext<StockManagementStorageContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StockDatabaseConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();


app.MapControllers();

app.Run();
