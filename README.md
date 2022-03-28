# GeometryCalculator

"В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
Если у продукта нет категорий, то его имя все равно должно выводиться."

Если есть таблица PRODUCT_TABLE с продуктами и таблица CATEGORY_TABLE с категориями,
и связанны они связью один ко многим путем наличия в таблице PRODUCT_TABLE поля CATEGORY_ID,
в котором указываются ID_CATEGORY я вляющимися primary key в таблице CATEGORY_TABLE, то ззапрос будет выглядеть так.

SELECT PRODUCT_NAME, CATEGORY_NAME 
FROM PRODUCT_TABLE
LEFT JOIN CATEGORY_TABLE ON ID_CATEGORY = CATEGORY_ID
