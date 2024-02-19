--1.
SELECT DISTINCT City
FROM Customers
WHERE City IN (SELECT City FROM Employees);

--2.a
SELECT DISTINCT City 
FROM Customers 
WHERE City NOT IN (SELECT City FROM Employees);

--2.b
SELECT DISTINCT c.City 
FROM Customers c 
LEFT JOIN Employees e ON c.City = e.City 
WHERE e.City IS NULL;

--3.
SELECT p.ProductName, SUM(od.Quantity) AS TotalQuantity
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName;

--4.
SELECT c.City, SUM(od.Quantity) AS TotalOrdered
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City;

--5.a
SELECT City FROM 
    ( SELECT City, COUNT(*) AS CustomerCount FROM Customers GROUP BY City HAVING COUNT(*) >= 2 ) AS CustomerCities 
    UNION 
SELECT City FROM 
    ( SELECT City, COUNT(*) AS EmployeeCount FROM Employees GROUP BY City HAVING COUNT(*) >= 2 ) AS EmployeeCities;


--5.b
SELECT City 
FROM Customers 
GROUP BY City 
HAVING COUNT(CustomerID) >= 2;

--6.
SELECT c.City
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2;

--7.
SELECT DISTINCT c.CustomerID, c.CompanyName
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity;

--8.
SELECT TOP 5 p.ProductName, AVG(od.UnitPrice) AS AveragePrice, c.City
FROM [Order Details] od
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY p.ProductName, c.City
ORDER BY SUM(od.Quantity) DESC;

--9.a
SELECT DISTINCT City 
FROM Employees 
WHERE City NOT IN (SELECT ShipCity FROM Orders);

--9.b
SELECT DISTINCT e.City 
FROM Employees e 
LEFT JOIN Orders o ON e.City = o.ShipCity 
WHERE o.OrderID IS NULL;

--10.
SELECT TOP 1 e.City
FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY e.City
ORDER BY COUNT(DISTINCT o.OrderID) DESC, SUM(od.Quantity) DESC;

--11. A common approach to remove duplicate records involves using a CTE (Common Table Expression) with the ROW_NUMBER() function. Here's a general template:

-- WITH CTE AS (
--     SELECT *, ROW_NUMBER() OVER (PARTITION BY [Column1], [Column2], ... ORDER BY [SomeColumn]) AS RN
--     FROM [YourTable]
-- )
-- DELETE FROM CTE WHERE RN > 1;

-- Replace [Column1], [Column2], ... with the columns you want to check for duplicates, 
-- [SomeColumn] with a column that can determine which row to keep (like an ID or a date column), and [YourTable] with your table name.


