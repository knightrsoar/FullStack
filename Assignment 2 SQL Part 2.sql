--14.
SELECT DISTINCT p.ProductName
FROM dbo.[Order Details] od
JOIN dbo.Orders o ON od.OrderID = o.OrderID
JOIN dbo.Products p ON od.ProductID = p.ProductID
WHERE o.OrderDate >= DATEADD(YEAR, -26, GETDATE());

--15.
SELECT TOP 5 ShipPostalCode, COUNT(*) AS TotalSales
FROM dbo.Orders
GROUP BY ShipPostalCode
ORDER BY TotalSales DESC;

--16.
SELECT TOP 5 ShipPostalCode, COUNT(*) AS TotalSales
FROM dbo.Orders
WHERE OrderDate >= DATEADD(YEAR, -26, GETDATE())
GROUP BY ShipPostalCode
ORDER BY TotalSales DESC;

--17.
SELECT City, COUNT(*) AS NumberOfCustomers
FROM dbo.Customers
GROUP BY City;

--18.
SELECT City, COUNT(*) AS NumberOfCustomers
FROM dbo.Customers
GROUP BY City
HAVING COUNT(*) > 2;

--19.
SELECT c.CompanyName, o.OrderDate
FROM dbo.Customers c
JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1998-01-01'
ORDER BY o.OrderDate;

--20.
SELECT c.CompanyName, MAX(o.OrderDate) AS MostRecentOrderDate
FROM dbo.Customers c
JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CompanyName;

--21.
SELECT c.CompanyName, SUM(od.Quantity) AS ProductsBought
FROM dbo.Customers c
JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName;

--22.
SELECT c.CustomerID, SUM(od.Quantity) AS ProductCount
FROM dbo.Customers c
JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) > 100;

--23.
SELECT s.CompanyName AS SupplierCompanyName, sh.CompanyName AS ShippingCompanyName
FROM dbo.Suppliers s
CROSS JOIN dbo.Shippers sh;

--24.
SELECT o.OrderDate, p.ProductName
FROM dbo.Orders o
JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
JOIN dbo.Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate, p.ProductName;

--25.
SELECT e1.FirstName + ' ' + e1.LastName AS EmployeeName1, e2.FirstName + ' ' + e2.LastName AS EmployeeName2, e1.Title
FROM dbo.Employees e1
INNER JOIN dbo.Employees e2 ON e1.Title = e2.Title AND e1.EmployeeID < e2.EmployeeID;

--26.
SELECT Manager.FirstName + ' ' + Manager.LastName AS ManagerName, COUNT(*) AS Reportees
FROM dbo.Employees AS Employees
JOIN dbo.Employees AS Manager ON Employees.ReportsTo = Manager.EmployeeID
GROUP BY Manager.FirstName, Manager.LastName, Manager.EmployeeID
HAVING COUNT(*) > 2;

--27.
SELECT City, CompanyName, ContactName, 'Customer' AS Type
FROM dbo.Customers
UNION
SELECT City, CompanyName, ContactName, 'Supplier'
FROM dbo.Suppliers;
