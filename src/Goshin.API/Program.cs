using Goshin.Services.Extensions;
using Goshin.Services.Sanity.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddGoshinServices();
// TODO: Move to secret
builder.Services.AddSanityServices(option =>
{
    option.ProjectId = "5qlmrfwg";
    option.Dataset = "production";
    option.Token = "skEOeMvbQ5grKZl2c3yuDoL2xcYNNC2CEF1ybyrlxDPjYKhCBdWhF3w7RvjUcmfs6DBazjLxbeZbfkIx0HtllIV54DOWsoQf52LgSCIQgHCR5mNrqB5GLZnp3w3jRT8J6xQNzCKuREElje1OvEyu3nxlAxrP8FubGqqn4jueEpAJBQAdhqdk";
});

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
