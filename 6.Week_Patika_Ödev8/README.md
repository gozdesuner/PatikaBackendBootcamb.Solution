
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [License](#license)

## Introduction

This project involves creating and managing an `employee` table in a test database, using various SQL operations such as `CREATE TABLE`, `INSERT`, `UPDATE`, and `DELETE`. The operations include creating the table schema, inserting data, updating rows, and deleting specific entries based on column values.

## Technologies

- SQL
- Database Management System (DBMS)

## Code Overview

### 1. Creating the `employee` Table

```sql
CREATE TABLE employee (
    id INTEGER PRIMARY KEY,
    name VARCHAR(50),
    birthday DATE,
    email VARCHAR(100)
);
```

This command creates the `employee` table with the following columns:
- `id`: Primary key (INTEGER)
- `name`: Employee's name (VARCHAR with a 50-character limit)
- `birthday`: Employee's birthdate (DATE)
- `email`: Employee's email address (VARCHAR with a 100-character limit)

### 2. Inserting Data into the `employee` Table

```sql
-- Example Insert Statements
INSERT INTO employee (name, birthday, email) VALUES ('Alyse Dessant', '2024-09-22', 'adessant0@networkadvertising.org');
INSERT INTO employee (name, birthday, email) VALUES ('Thorstein Brimmacombe', '2024-02-18', 'tbrimmacombe1@4shared.com');
-- (continues for 50 rows)
```

These `INSERT` statements add 50 records into the `employee` table. The data includes various names, birthdates, and email addresses, some of which may be `NULL`.

### 3. Updating Records in the `employee` Table

```sql
UPDATE employee SET name = 'Gözde Süner' WHERE id = 1;
UPDATE employee SET email = 'gzd@example.com' WHERE name = 'Mendel Preshaw';
UPDATE employee SET name = 'Gram McMichell' WHERE birthday = '2024-01-13';
UPDATE employee SET birthday = '2023-12-06' WHERE email = 'frattrieo@washingtonpost.com';
UPDATE employee SET email = 'gzdsnQexample.com' WHERE id = 2;
```

These `UPDATE` statements modify records in the `employee` table based on specified conditions, allowing you to change the values of the `name`, `email`, and `birthday` columns.

### 4. Deleting Records from the `employee` Table

```sql
DELETE FROM employee WHERE id = 4;
DELETE FROM employee WHERE name = 'Gram McMichell';
DELETE FROM employee WHERE email = 'ntoomey9@bloglovin.com';
DELETE FROM employee WHERE id = 210;
DELETE FROM employee WHERE birthday = '2024-09-10';
```

These `DELETE` statements remove specific rows from the `employee` table based on conditions in each column.

## Usage

To use these SQL commands, execute them in a SQL environment connected to a database where the `employee` table will be created. Ensure the `test` database exists and you have permissions to create, insert, update, and delete records.

## Explanation

The SQL commands are organized into sections for creating, inserting, updating, and deleting records in the `employee` table. The queries demonstrate various SQL functionalities for table management and data manipulation in a structured and systematic way.

## License

This project is licensed under the MIT License.
