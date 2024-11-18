
# Patikaflix Dizi Platformu

## İçindekiler
- [Giriş](#giriş)
- [Teknolojiler](#teknolojiler)
- [Kod Açıklaması](#kod-açıklaması)
- [Kullanım](#kullanım)
- [Açıklama](#açıklama)
- [Çıktı](#çıktı)
- [Lisans](#lisans)

## Giriş
Patikaflix Dizi Platformu, kullanıcıların dizi bilgilerini kaydetmelerine ve komedi türündeki dizileri listelemelerine olanak tanır. Bu uygulama, dizilerin adını, yapım yılını, türünü, yayın yılını, yönetmenini ve yayınlandığı ilk platformu kaydetmenizi sağlar. Komedi dizileri ayrıca kendi başlarına sıralı bir şekilde listelenir.

## Teknolojiler
- C#
- .NET Console Application

## Kod Açıklaması
Projede iki ana sınıf bulunmaktadır:
1. **Dizi**: Dizinin genel özelliklerini tutar.
    - `DiziAd`, `YapimYili`, `Turu`, `YayinYili`, `Yönetmen`, `YayinlandigiIlkPlatform`
2. **KomediDizisi**: Komedi türündeki diziler için özel özellikleri içerir.
    - `DiziAdi`, `DiziTuru`, `Yonetmen`

Program, kullanıcıdan dizi bilgilerini toplar, ardından komedi türündeki dizileri filtreler ve listeler.

## Kullanım
1. Programı çalıştırın.
2. Dizinin adını, yapım yılını, türünü, yayın yılını, yönetmenini ve yayınlandığı ilk platformu girin.
3. Yeni bir dizi eklemek için `E` tuşuna basarak eklemeye devam edebilirsiniz. Ekleme işlemi tamamlandıktan sonra, program "Komedi" türündeki dizileri listeleyecektir.

## Açıklama
Dizi sınıfı, tüm dizi türleri için temel özellikleri içerir. Komedi türündeki diziler, kullanıcıdan alınan bilgiler arasından "Komedi" türünde olanlar filtrelenerek sıralı bir liste halinde gösterilir.

Komedi dizileri `KomediDizisi` sınıfında `DiziAdi`, `DiziTuru`, ve `Yonetmen` özellikleri ile tanımlanır.

## Çıktı
Programın çıktısı şu şekildedir:

```
Komedi Dizileri Listesi:
Dizi Adı: [Dizi Adı], Türü: [Türü], Yönetmen: [Yönetmen]
...
```

## Lisans
Bu proje, MIT Lisansı kapsamında lisanslanmıştır.
