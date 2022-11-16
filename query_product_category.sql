SELECT p.Name, c.Name FROM ProductCategory AS pc
JOIN Categories AS c ON c.Id = pc.CategoryId
FULL JOIN Products AS p ON p.Id = pc.ProductId;