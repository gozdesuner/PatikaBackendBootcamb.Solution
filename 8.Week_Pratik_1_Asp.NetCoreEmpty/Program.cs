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


// Controller: Uygulaman�n i� mant���n� y�netir ve kullan�c�n�n taleplerini i�ler. Verileri modelden al�r ve view'e g�nderir.
// Action: Controller i�inde tan�mlanan ve kullan�c� isteklerine yan�t veren metotlard�r. �rne�in, bir web sayfas�n� d�nd�ren veya JSON veri sa�layan metotlar.
// Model: Uygulamadaki veri yap�lar�n� temsil eder. Veriler �zerinde i�lemler yapar ve View ile Controller aras�nda veri ta��r.
// View: Kullan�c�ya g�sterilecek olan HTML ��kt�s�n� olu�turur. Modelden gelen verileri kullanarak dinamik i�erik �retir.
// Razor: ASP.NET Core taraf�ndan kullan�lan bir view motorudur. HTML kodlar�n� C# ile birle�tirerek dinamik sayfalar olu�turmay� sa�lar.
// RazorView: Razor syntax'�n� kullanarak olu�turulan .cshtml dosyalar�n� ifade eder. Bu dosyalar, dinamik web sayfalar�n�n olu�turulmas�nda kullan�l�r.
// wwwroot: Uygulamadaki statik dosyalar�n (CSS, JavaScript, resimler vb.) bar�nd�r�ld��� klas�rd�r. Bu dosyalar taray�c� taraf�ndan do�rudan eri�ilebilir.

// builder.Build(): Uygulaman�n yap�land�rmas�n� tamamlar ve bir WebApplication nesnesi olu�turur. T�m servisler ve middleware'ler bu a�amada eklenmi� olur.
// app.Run(): Uygulamay� ba�lat�r ve HTTP isteklerini dinlemeye ba�lar. Bu metot �a�r�ld�ktan sonra uygulama �al���r duruma gelir.