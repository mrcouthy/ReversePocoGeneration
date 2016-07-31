USE Northwind;
GO

CREATE TABLE GeographyTypes
(
    Id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    Location GEOGRAPHY NOT NULL,
    Distance GEOMETRY NOT NULL
);
GO

-- Remove
DROP TABLE GeographyTypes;
