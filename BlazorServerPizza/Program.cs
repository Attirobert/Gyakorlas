using BlazorServerPizza.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// builder.Services.AddSingleton<WeatherForecastService>(); A p�ld�ban nem szerepel

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // app.UseHsts(); A p�ld�ban nem szerepel
}

// app.UseHttpsRedirection();    A p�ld�ban nem szerepel

app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();    // A gener�ltban nem szerepel, de a p�ld�ban igen

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
