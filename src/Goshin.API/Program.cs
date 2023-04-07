using Goshin.API.Auth.Extensions;
using Goshin.Database.Extensions;
using Goshin.Services.Extensions;
using Goshin.Services.Sanity.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddGoshinServices();
builder.Services.AddSanityServices(option =>
{
    option.ProjectId = builder.Configuration["Sanity:ProjectId"]!;
    option.Dataset = builder.Configuration["Sanity:Dataset"]!;
    option.Token = builder.Configuration["Sanity:Token"]!;
});
builder.Services.AddGoshinDatabase(builder.Configuration);
builder.Services.AddGoshinAuth(options =>
{
    options.Audience = builder.Configuration["JWT:Audience"]!;
    options.Issuer = builder.Configuration["JWT:Issuer"]!;
    options.Secret = builder.Configuration["JWT:Secret"]!;
}, builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
