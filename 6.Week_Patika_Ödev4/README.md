
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

This project includes SQL queries to analyze and retrieve data from `film`, `country`, and `city` tables based on specific conditions.

## Technologies

- SQL
- Database Management System (DBMS)

## Code Overview

### Queries

#### 1. List Unique Values in `replacement_cost` from the `film` Table

```sql
SELECT DISTINCT replacement_cost 
FROM film
ORDER BY replacement_cost;
```

This query retrieves all unique values from the `replacement_cost` column in the `film` table, sorted in ascending order.

#### 2. Count of Unique Values in `replacement_cost` from the `film` Table

```sql
SELECT COUNT(DISTINCT replacement_cost) 
FROM film;
```

This query counts the number of unique values in the `replacement_cost` column from the `film` table.

#### 3. Count of Film Titles Starting with 'T' and Rating Equal to 'G'

```sql
SELECT title 
FROM film
WHERE title LIKE 'T%' AND rating = 'G';
```

This query retrieves film titles from the `film` table that start with the letter 'T' and have a rating of 'G'.

#### 4. Count of Country Names with 5 Characters

```sql
SELECT COUNT(*) 
FROM country
WHERE LENGTH(country) = 5;
```

This query counts the number of country names in the `country` table that are exactly 5 characters long.

#### 5. Count of Cities Ending with 'R' or 'r'

```sql
SELECT COUNT(*) AS count_of_cities_ending_with_r 
FROM city
WHERE city LIKE '%r' OR city LIKE '%R';
```

This query counts the number of cities in the `city` table whose names end with the letter 'R' or 'r'.

## Usage

To use these queries, execute them in a SQL environment that contains the `film`, `country`, and `city` tables. Ensure that the database schema aligns with the columns referenced in each query.

## Explanation

Each query is designed to analyze specific columns in the `film`, `country`, and `city` tables. The explanations for each query's intent and expected results are provided in the **Code Overview** section.

## Output

The output will vary based on the data stored in the `film`, `country`, and `city` tables at the time of query execution. Each query's result will align with the specified criteria.

## License

This project is licensed under the MIT License.
