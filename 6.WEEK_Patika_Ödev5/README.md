
# Film ve Müşteri Sorguları Projesi

## İçindekiler
1. [Giriş](#giriş)
2. [Teknolojiler](#teknolojiler)
3. [Kod Genel Bakış](#kod-genel-bakış)
4. [Kullanım](#kullanım)
5. [Açıklama](#açıklama)
6. [Çıktı](#çıktı)
7. [Lisans](#lisans)

## Giriş
Bu proje, SQL sorguları ile film ve müşteri tabloları üzerinde yapılan bazı filtreleme ve sıralama işlemlerini içermektedir. Özellikle belirli kriterlere göre film uzunluklarına ve müşteri soyadlarına göre sıralama yapılmıştır.

## Teknolojiler
- SQL

## Kod Genel Bakış
Bu proje kapsamında film ve müşteri tabloları üzerinde sıralama ve filtreleme işlemleri gerçekleştirilmiştir.

## Kullanım
Projeyi çalıştırmak için aşağıdaki SQL sorgularını kullanabilirsiniz.

## Açıklama
### 1. Film Tablosundaki En Uzun 5 Film
Film tablosunda, `title` sütunu 'n' harfi ile biten en uzun 5 film aşağıdaki sorgu ile sıralanmıştır:
```sql
SELECT title 
FROM film 
WHERE title LIKE '%n' 
ORDER BY LENGTH(title) DESC 
LIMIT 5;
```

### 2. Film Tablosundaki En Kısa 5 Film (İkinci Grup)
Film tablosunda, `title` sütunu 'n' harfi ile biten ve uzunluk açısından 6. sıradan 10. sıraya kadar olan en kısa 5 film aşağıdaki sorgu ile sıralanmıştır:
```sql
SELECT title 
FROM film 
WHERE title LIKE '%n' 
ORDER BY LENGTH(title) ASC 
OFFSET 5 
LIMIT 5;
```

### 3. Müşteri Tablosunda Soyada Göre Sıralama (store_id = 1 ve İlk 4 Kayıt)
Müşteri tablosunda `store_id` 1 olan müşteriler, `last_name` sütununa göre azalan sırada sıralanmış ve ilk 4 kayıt aşağıdaki sorgu ile getirilmiştir:
```sql
SELECT * 
FROM customer 
WHERE store_id = 1 
ORDER BY last_name DESC 
LIMIT 4;
```

## Çıktı
Her sorgu, tablolar üzerinde belirli filtreleme kriterlerine göre veri döndürmektedir. Çıktı olarak, filmler ve müşteriler belirli sıralama kurallarına göre listelenir.

## Lisans
Bu proje, MIT lisansı altında lisanslanmıştır.
