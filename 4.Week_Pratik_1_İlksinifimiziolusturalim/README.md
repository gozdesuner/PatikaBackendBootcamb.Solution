
# 4. Hafta Pratik 1 - İlk Sınıfımızı Oluşturalım

## Giriş
Bu proje, C# programlama dilinde basit bir sınıf oluşturmayı ve sınıf içerisinde temel özellikleri (name, surname, date) tanımlamayı amaçlamaktadır. Projede bir `Person` sınıfı oluşturulmuş ve bu sınıfa ait isim, soyisim ve doğum tarihi özellikleri tanımlanmıştır.

## Teknolojiler
- C# 10
- .NET 6

## Kod Genel Bakış
Bu projede `Person` sınıfı oluşturulmuştur. Sınıfta aşağıdaki özellikler yer alır:
- **Name**: Kişinin adını saklar.
- **Surname**: Kişinin soyadını saklar.
- **Date**: Kişinin doğum tarihini saklar.

Her özellik için get ve set metotları kullanılarak erişim sağlanmıştır.

### Person Sınıfı Örneği:

```csharp
namespace _4.Week_Pratik_1_İlksinifimiziolusturalim
{
    public class Person
    {
        public string _name;
        public string _surname;
        public DateTime _date;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
    }
}
```

## Kullanım
Projeyi kendi bilgisayarınıza klonladıktan sonra, Visual Studio veya herhangi bir C# geliştirme ortamında projeyi açarak çalıştırabilirsiniz.

### Adımlar:
1. Projeyi indirin veya klonlayın.
2. `Person` sınıfındaki `Name`, `Surname`, ve `Date` alanlarını kullanarak nesneler oluşturun.
3. Projeyi derleyip çalıştırın.

## Açıklama
Bu proje, nesne yönelimli programlama (OOP) ilkelerini öğrenmek amacıyla hazırlanmıştır. `Person` sınıfı, bir kişiye ait temel bilgileri temsil eder ve bu bilgiler üzerinde işlem yapabilme yetisi sağlar.

## Çıktı
Projeyi çalıştırdığınızda, `Person` nesnesine ait özellikleri kullanarak isim, soyisim ve doğum tarihi bilgilerini alabilirsiniz.

## Lisans
Bu proje MIT lisansı ile lisanslanmıştır.
