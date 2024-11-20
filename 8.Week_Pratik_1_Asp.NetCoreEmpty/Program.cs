var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();


// Controller: Uygulamanýn iþ mantýðýný yönetir ve kullanýcýnýn taleplerini iþler. Verileri modelden alýr ve view'e gönderir.
// Action: Controller içinde tanýmlanan ve kullanýcý isteklerine yanýt veren metotlardýr. Örneðin, bir web sayfasýný döndüren veya JSON veri saðlayan metotlar.
// Model: Uygulamadaki veri yapýlarýný temsil eder. Veriler üzerinde iþlemler yapar ve View ile Controller arasýnda veri taþýr.
// View: Kullanýcýya gösterilecek olan HTML çýktýsýný oluþturur. Modelden gelen verileri kullanarak dinamik içerik üretir.
// Razor: ASP.NET Core tarafýndan kullanýlan bir view motorudur. HTML kodlarýný C# ile birleþtirerek dinamik sayfalar oluþturmayý saðlar.
// RazorView: Razor syntax'ýný kullanarak oluþturulan .cshtml dosyalarýný ifade eder. Bu dosyalar, dinamik web sayfalarýnýn oluþturulmasýnda kullanýlýr.
// wwwroot: Uygulamadaki statik dosyalarýn (CSS, JavaScript, resimler vb.) barýndýrýldýðý klasördür. Bu dosyalar tarayýcý tarafýndan doðrudan eriþilebilir.

// builder.Build(): Uygulamanýn yapýlandýrmasýný tamamlar ve bir WebApplication nesnesi oluþturur. Tüm servisler ve middleware'ler bu aþamada eklenmiþ olur.
// app.Run(): Uygulamayý baþlatýr ve HTTP isteklerini dinlemeye baþlar. Bu metot çaðrýldýktan sonra uygulama çalýþýr duruma gelir.