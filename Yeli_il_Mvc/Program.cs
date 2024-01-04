using Microsoft.EntityFrameworkCore;
using Yeli_il_Mvc.DAL;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    "defalut",
    "{controller=home}/{action=index}/{id?}"


);

app.Run();
