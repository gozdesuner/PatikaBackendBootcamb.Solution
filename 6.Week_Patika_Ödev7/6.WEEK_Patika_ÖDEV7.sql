--1-)film tablosunda bulunan filmleri rating değerlerine göre gruplayınız.
--select rating, count(*) from film
--group by rating
--order by rating;

--2-)film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralayınız.
--select replacement_cost, count(*) from film
--group by replacement_cost
--having count(*)>50
--order by replacement_cost

--3-)customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayılarını nelerdir?
--SELECT store_id, COUNT(*) FROM customer
--GROUP BY store_id;

--4-)city tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşınız.
--SELECT country_id, COUNT(*) sehir_sayisi FROM city
--GROUP BY country_id
--ORDER BY sehir_sayisi DESC
--LIMIT 1;
