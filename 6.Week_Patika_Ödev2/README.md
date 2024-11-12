
# SQL Query Practice

This document contains SQL queries for various operations on the `film` and `actor` tables, focusing on filtering results using conditions on replacement costs, rental rates, and names.

## Table of Contents
- [Queries](#queries)
  - [Query 1](#query-1)
  - [Query 2](#query-2)
  - [Query 3](#query-3)

## Queries

### Query 1

Retrieve all columns from the `film` table where `replacement_cost` is greater than or equal to 12.99 and less than 16.99 using the `BETWEEN` and `AND` operators.

```sql
SELECT * FROM film
WHERE replacement_cost BETWEEN 12.99 AND 16.99;
```

### Query 2

Select the `first_name` and `last_name` columns from the `actor` table where the `first_name` is either 'Penelope', 'Nick', or 'Ed'. This query demonstrates the use of the `IN` operator.

```sql
SELECT first_name, last_name FROM actor
WHERE first_name IN ('Penelope', 'Nick', 'Ed');
```

### Query 3

Retrieve all columns from the `film` table where the `rental_rate` is either 0.99, 2.99, or 4.99, and `replacement_cost` is either 12.99, 15.99, or 28.99. This query demonstrates multiple conditions with the `IN` operator.

```sql
SELECT * FROM film
WHERE rental_rate IN (0.99, 2.99, 4.99) 
AND replacement_cost IN (12.99, 15.99, 28.99);
```

---

Each query is designed to practice filtering data using SQL operators like `BETWEEN`, `AND`, and `IN`.
