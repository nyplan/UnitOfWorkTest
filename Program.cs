using Microsoft.EntityFrameworkCore;
using UnitOfWork.BLL.Abstract;
using UnitOfWork.BLL.Concrete;
using UnitOfWork.DAL.Abstract;
using UnitOfWork.DAL.Concrete;
using UnitOfWork.DAL.Contexts;
using UnitOfWork.DAL.UnitOfWork.Abstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL"));
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork.DAL.UnitOfWork.Concrete.UnitOfWork>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
