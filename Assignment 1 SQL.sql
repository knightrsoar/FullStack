--1
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product;

--2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0;

--3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL;

--4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL;

--5
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL AND ListPrice > 0;

--6
SELECT CONCAT(Name, ' -- COLOR: ', Color) AS ProductDescription
FROM Production.Product
WHERE Color IS NOT NULL;

--7 Formatted result set:
SELECT CONCAT('NAME: ', Name, ' -- COLOR: ', Color) AS FormattedOutput
FROM Production.Product
WHERE Color IS NOT NULL;

--8 Retrieve ProductID and Name for ProductID between 400 and 500:
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500;

--9 Retrieve ProductID, Name, and Color for products in black and blue:
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('Black', 'Blue');

--10 Products that begin with the letter 'S':
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Name LIKE 'S%';

--11 Retrieve Name and ListPrice, format as requested, and order by Name:
SELECT Name, ListPrice
FROM Production.Product
ORDER BY Name;

--12 Products starting with 'A' or 'S':
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'A%' OR Name LIKE 'S%'
ORDER BY Name;

--13 Names starting with 'SPO' but not followed by 'K':
SELECT Name
FROM Production.Product
WHERE Name LIKE 'SPO%' AND Name NOT LIKE 'SPOK%'
ORDER BY Name;

--14 Retrieve unique Color values in descending order:
SELECT DISTINCT Color
FROM Production.Product
WHERE Color IS NOT NULL
ORDER BY Color DESC;

--15 Unique ProductSubcategoryID and Color combinations, excluding NULLs:
SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL
ORDER BY ProductSubcategoryID, Color;








