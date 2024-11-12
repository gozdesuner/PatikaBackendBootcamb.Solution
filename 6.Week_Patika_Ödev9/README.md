
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [License](#license)

## Introduction

This project includes SQL queries using `INNER JOIN` statements to combine data from related tables. The focus is on joining tables to display related information, such as city and country names, customer details with payment information, and customer details with rental information.

## Technologies

- SQL
- Database Management System (DBMS)

## Code Overview

### Queries

#### 1. Joining `city` and `country` Tables to Display City and Country Names

```sql
SELECT city, country 
FROM city
INNER JOIN country ON city.country_id = country.country_id;
```

This query performs an `INNER JOIN` between the `city` and `country` tables based on `country_id`. It retrieves `city` and `country` names together.

#### 2. Joining `customer` and `payment` Tables to Display Customer Names and Payment ID

```sql
SELECT first_name, last_name, payment_id
FROM customer
INNER JOIN payment ON customer.customer_id = payment.customer_id;
```

This query performs an `INNER JOIN` between the `customer` and `payment` tables using `customer_id`. It retrieves `first_name`, `last_name`, and `payment_id` for each customer.

#### 3. Joining `customer` and `rental` Tables to Display Customer Names and Rental ID

```sql
SELECT rental_id, first_name, last_name
FROM customer
INNER JOIN rental ON customer.customer_id = rental.customer_id;
```

This query performs an `INNER JOIN` between the `customer` and `rental` tables using `customer_id`. It retrieves the `rental_id`, `first_name`, and `last_name` of customers involved in rentals.

## Usage

To use these queries, run them in a SQL environment that contains the `city`, `country`, `customer`, `payment`, and `rental` tables. Ensure the database schema matches the column names and relationships specified in each query.

## Explanation

Each query is designed to join related tables and retrieve specific information:
- The first query joins `city` and `country` tables to display city and country names.
- The second query joins `customer` and `payment` tables to show customer names with payment IDs.
- The third query joins `customer` and `rental` tables to show customer names with rental IDs.

## License

This project is licensed under the MIT License.
