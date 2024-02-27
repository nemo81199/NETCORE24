var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//customer map route
app.MapControllerRoute(
    name: "product",
    pattern: "danh-sach-san-pham",
    defaults: new {controller = "Product", action = "GetAllProduct" }

    );
app.MapControllerRoute(
    name: "product",
    pattern: "san-pham",
    defaults: new { controller = "Product", action = "GetProduct" }

    );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
