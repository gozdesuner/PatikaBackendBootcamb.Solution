
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

This project includes SQL queries to analyze data from the `film` table, calculating averages, counting specific records, finding maximum values, and identifying distinct values based on various conditions.

## Technologies

- SQL
- Database Management System (DBMS)

## Code Overview

### Queries

#### 1. Average Value of `rental_rate` in the `film` Table

```sql
SELECT AVG(rental_rate) FROM film;
```

This query calculates the average rental rate of all films in the `film` table.

#### 2. Count of Films Starting with the Character 'C'

```sql
SELECT COUNT(*) 
FROM film
WHERE title LIKE 'C%';
```

This query counts the number of films in the `film` table where the title starts with the letter 'C'.

#### 3. Longest Film with a Rental Rate of 0.99

```sql
SELECT MAX(length) 
FROM film
WHERE rental_rate = 0.99;
```

This query retrieves the maximum length of films with a `rental_rate` of 0.99, representing the longest film duration in this rental rate category.

#### 4. Count of Distinct `replacement_cost` Values for Films Longer than 150 Minutes

```sql
SELECT COUNT(DISTINCT replacement_cost) 
FROM film
WHERE length > 150;
```

This query counts the distinct `replacement_cost` values for films that are longer than 150 minutes in the `film` table.

## Usage

To use these queries, execute them in a SQL environment that contains the `film` table. Ensure the database schema aligns with the columns referenced in each query.

## Explanation

Each query is designed to analyze specific aspects of the `film` table, such as calculating averages, counting records, finding the maximum film length, and identifying distinct replacement costs. The explanations for each query's intent and expected results are provided in the **Code Overview** section.

## Output

The output will vary based on the data stored in the `film` table at the time of query execution. Each query’s result will align with the specified criteria.

## License

This project is licensed under the MIT License.
