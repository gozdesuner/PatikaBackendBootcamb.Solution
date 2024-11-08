
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [License](#license)

## Introduction

This project includes SQL queries that perform operations across the `actor` and `customer` tables using set operations such as `UNION`, `INTERSECT`, and `EXCEPT`. These queries allow us to retrieve combined, intersecting, and exclusive data from both tables, focusing on the `first_name` column.

## Technologies

- SQL
- Database Management System (DBMS)

## Code Overview

### Queries

#### 1. Retrieve All Unique First Names from `actor` and `customer` Tables

```sql
SELECT first_name FROM actor
UNION
SELECT first_name FROM customer
ORDER BY first_name;
```

This query combines all unique `first_name` values from both the `actor` and `customer` tables and sorts them in alphabetical order.

#### 2. Retrieve Intersecting First Names from `actor` and `customer` Tables

```sql
SELECT first_name FROM actor
INTERSECT
SELECT first_name FROM customer
ORDER BY first_name;
```

This query retrieves `first_name` values that exist in both the `actor` and `customer` tables, sorted in alphabetical order.

#### 3. Retrieve Exclusive First Names from `actor` Table

```sql
SELECT first_name FROM actor
EXCEPT
SELECT first_name FROM customer
ORDER BY first_name;
```

This query retrieves `first_name` values that exist in the `actor` table but not in the `customer` table, sorted in alphabetical order.

#### 4. Repeat the First Three Queries Including Duplicates

```sql
SELECT first_name FROM actor
UNION ALL
SELECT first_name FROM customer
ORDER BY first_name;

SELECT first_name FROM actor
INTERSECT ALL
SELECT first_name FROM customer
ORDER BY first_name;

SELECT first_name FROM actor
EXCEPT ALL
SELECT first_name FROM customer
ORDER BY first_name;
```

These queries repeat the first three operations (`UNION`, `INTERSECT`, and `EXCEPT`), but include duplicate entries using `UNION ALL`, `INTERSECT ALL`, and `EXCEPT ALL`.

## Usage

To use these queries, execute them in a SQL environment with `actor` and `customer` tables that contain a `first_name` column. These queries will display unique, intersecting, and exclusive first names across both tables.

## Explanation

The queries utilize set operations to demonstrate the following:
- `UNION` and `UNION ALL`: Combine all or all with duplicates from both tables.
- `INTERSECT` and `INTERSECT ALL`: Retrieve names common to both tables.
- `EXCEPT` and `EXCEPT ALL`: Retrieve names that exist in the first table but not in the second.

## License

This project is licensed under the MIT License.
