--1-)city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.




 



/*SELECT CITY.city, COUNTRY.country
FROM CITY
LEFT JOIN COUNTRY ON CITY.country_id = COUNTRY.country_id;*/


--2-)customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
/*SELECT PAYMENT.payment_id, CUSTOMER.first_name, CUSTOMER.last_name
FROM CUSTOMER
RIGHT JOIN PAYMENT ON CUSTOMER.customer_id = PAYMENT.customer_id;*/


--3-)customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.
/*SELECT RENTAL.rental_id, CUSTOMER.first_name, CUSTOMER.last_name
FROM CUSTOMER
FULL JOIN RENTAL ON CUSTOMER.customer_id = RENTAL.customer_id;*/