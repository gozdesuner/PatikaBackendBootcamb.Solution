
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [License](#license)

## Introduction

This project includes SQL queries using different types of `JOIN` statements to combine data from related tables. The queries use `LEFT JOIN`, `RIGHT JOIN`, and `FULL JOIN` to retrieve information across tables, such as city and country names, customer details with payment information, and customer details with rental information.

## Technologies

- SQL
- Database Management System (DBMS)

## Code Overview

### Queries

#### 1. LEFT JOIN Between `city` and `country` Tables to Display City and Country Names

```sql
SELECT CITY.city, COUNTRY.country
FROM CITY
LEFT JOIN COUNTRY ON CITY.country_id = COUNTRY.country_id;
```

This query performs a `LEFT JOIN` between the `city` and `country` tables on `country_id`. It retrieves all cities and, if available, their corresponding countries.

#### 2. RIGHT JOIN Between `customer` and `payment` Tables to Display Customer Names and Payment ID

```sql
SELECT PAYMENT.payment_id, CUSTOMER.first_name, CUSTOMER.last_name
FROM CUSTOMER
RIGHT JOIN PAYMENT ON CUSTOMER.customer_id = PAYMENT.customer_id;
```

This query performs a `RIGHT JOIN` between the `customer` and `payment` tables using `customer_id`. It retrieves all payments and, if available, the corresponding customer’s `first_name` and `last_name`.

#### 3. FULL JOIN Between `customer` and `rental` Tables to Display Customer Names and Rental ID

```sql
SELECT RENTAL.rental_id, CUSTOMER.first_name, CUSTOMER.last_name
FROM CUSTOMER
FULL JOIN RENTAL ON CUSTOMER.customer_id = RENTAL.customer_id;
```

This query performs a `FULL JOIN` between the `customer` and `rental` tables using `customer_id`. It retrieves all customers and rentals, displaying the `rental_id` along with the customer’s `first_name` and `last_name` if they exist in both tables.

## Usage

To use these queries, run them in a SQL environment that contains the `city`, `country`, `customer`, `payment`, and `rental` tables. Ensure that the database schema aligns with the column names and relationships specified in each query.

## Explanation

Each query is designed to join related tables and retrieve specific information:
- The first query joins `city` and `country` tables to display city and country names using `LEFT JOIN`.
- The second query joins `customer` and `payment` tables to show customer names with payment IDs using `RIGHT JOIN`.
- The third query joins `customer` and `rental` tables to show customer names with rental IDs using `FULL JOIN`.

## License

This project is licensed under the MIT License.
