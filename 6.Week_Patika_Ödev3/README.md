
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

This project includes SQL queries to retrieve data from `country` and `film` tables based on specific criteria.

## Technologies

- SQL
- Database Management System (DBMS)

## Code Overview

### Queries

#### 1. Retrieve Country Names Starting with 'A' and Ending with 'a'

```sql
SELECT country 
FROM country
WHERE country LIKE 'A%a';
```

This query retrieves country names from the `country` table where the country name starts with 'A' and ends with 'a'.

#### 2. Retrieve Country Names with at Least 6 Characters Ending with 'n'

```sql
SELECT country 
FROM country 
WHERE LENGTH(country) >= 6 AND country LIKE '%n';
```

This query retrieves country names from the `country` table where the name is at least 6 characters long and ends with 'n'.

#### 3. Retrieve Film Titles Containing at Least Four 'T' Characters (Case Insensitive)

```sql
SELECT title 
FROM film
WHERE LOWER(title) LIKE '%t%t%t%t';
```

This query retrieves film titles from the `film` table that contain at least four occurrences of the character 'T' (case insensitive).

#### 4. Retrieve All Columns from `film` Where Title Starts with 'C', Length is Greater Than 90, and Rental Rate is 2.99

```sql
SELECT * 
FROM film
WHERE title LIKE 'C%' AND LENGTH > 90 AND rental_rate = 2.99;
```

This query retrieves all columns from the `film` table where the title starts with 'C', the length is greater than 90, and the rental rate is 2.99.

## Usage

To use these queries, run them in a SQL database environment that has access to the `country` and `film` tables.

## Explanation

Each query is designed to retrieve data based on specific filters in the `country` and `film` tables. The explanations and intended results for each query are provided in the **Code Overview** section.

## Output

The output will depend on the data available in the `country` and `film` tables at the time of execution. Each query will return rows that meet the specified criteria.

## License

This project is licensed under the MIT License.
