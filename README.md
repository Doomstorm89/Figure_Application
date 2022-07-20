# Figure_Application
Тестовое задание: 
C# библиотека, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
Дополнительно:
Юнит-тесты
Легкость добавления других фигур
Вычисление площади фигуры без знания типа фигуры в compile-time
Проверку на то, является ли треугольник прямоугольным

# SQL-запрос:
--Тестовая дб с таблицами и запросом: https://dbfiddle.uk/?rdbms=sqlserver_2019&fiddle=21e2dd295ce01529af1a1ca47e30e683

select p.Name, c.Name from Products_and_categories as pac
left join Products as p on pac.ProductId = p.Id
left join Categories as c on pac.CategoryId = c.Id;
