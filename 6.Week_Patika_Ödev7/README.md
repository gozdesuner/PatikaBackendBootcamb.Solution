
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

This project includes SQL queries to analyze and retrieve data from the `film`, `customer`, and `city` tables by grouping, filtering, and counting records based on specific criteria.

## Technologies

- SQL
- Database Management System (DBMS)

## Code Overview

### Queries

#### 1. Group Films by Rating

```sql
SELECT rating, COUNT(*) 
FROM film
GROUP BY rating
ORDER BY rating;
```

This query groups films in the `film` table by their `rating` and counts the number of films in each rating category, ordered alphabetically by `rating`.

#### 2. Replacement Cost Groups with More Than 50 Films

```sql
SELECT replacement_cost, COUNT(*) 
FROM film
GROUP BY replacement_cost
HAVING COUNT(*) > 50
ORDER BY replacement_cost;
```

This query groups films by `replacement_cost` and retrieves those groups where the number of films is greater than 50, sorted by `replacement_cost`.

#### 3. Customer Count by Store ID

```sql
SELECT store_id, COUNT(*) 
FROM customer
GROUP BY store_id;
```

This query counts the number of customers for each `store_id` in the `customer` table.

#### 4. Country ID with the Most Cities

```sql
SELECT country_id, COUNT(*) AS sehir_sayisi 
FROM city
GROUP BY country_id
ORDER BY sehir_sayisi DESC
LIMIT 1;
```

This query groups cities by `country_id`, counts the cities in each country, and returns the `country_id` with the highest city count.

## Usage

To use these queries, execute them in a SQL environment that contains the `film`, `customer`, and `city` tables. Ensure the database schema aligns with the columns referenced in each query.

## Explanation

Each query is designed to group data from specific tables and retrieve relevant counts based on conditions and filters. The explanations for each query's intent and expected results are provided in the **Code Overview** section.

## Output

The output will vary based on the data in the `film`, `customer`, and `city` tables at the time of query execution. Each query’s result will align with the specified criteria.

## License

This project is licensed under the MIT License.
