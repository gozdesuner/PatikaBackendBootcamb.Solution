
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [License](#license)

## Introduction

This project includes SQL queries that analyze data in the `film` and `payment` tables. The queries cover calculations for counting records above average values, identifying records with maximum or minimum values, and retrieving customer data based on transaction frequency.

## Technologies

- SQL
- Database Management System (DBMS)

## Code Overview

### Queries

#### 1. Count of Films Longer Than Average Length

```sql
SELECT COUNT(*) 
FROM film
WHERE length > (SELECT AVG(length) FROM film);
```

This query retrieves the count of films whose `length` is greater than the average film length in the `film` table.

#### 2. Count of Films with the Highest Rental Rate

```sql
SELECT COUNT(*) 
FROM film
WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);
```

This query retrieves the count of films with the maximum `rental_rate` value in the `film` table.

#### 3. List of Films with the Lowest Rental Rate and Replacement Cost

```sql
SELECT * 
FROM film
WHERE rental_rate = (SELECT MIN(rental_rate) FROM film)
AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);
```

This query retrieves films that have both the lowest `rental_rate` and the lowest `replacement_cost` values in the `film` table.

#### 4. List of Customers with the Highest Number of Transactions

```sql
SELECT customer_id, COUNT(*) AS alısveris_sayısı 
FROM payment 
GROUP BY customer_id
ORDER BY alısveris_sayısı DESC;
```

This query retrieves customers along with the count of their transactions, sorted in descending order by transaction count.

## Usage

To use these queries, execute them in a SQL environment with `film` and `payment` tables. The queries analyze the number of films above average length, identify films with maximum and minimum rates, and rank customers by transaction frequency.

## Explanation

The queries provide insights into:
- The number of films exceeding average length.
- Films with the highest and lowest rental rates and replacement costs.
- Customers with the highest number of transactions.

## License

This project is licensed under the MIT License.
