

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();// 1 - 
var app = builder.Build();


// Our builder code
app.UseStaticFiles(); // 2 -
app.UseRouting();  // 2 -
app.UseAuthorization();  // 2 -

app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}"); // 3 -

app.Run();
