using Microsoft.EntityFrameworkCore;
using Kimia.BackEnd;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ChemistryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionString"]);
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
