USE cd

-- Ver las Disquerias y Companias

SELECT C.descripcion[Nombre], 
	'Compañia'[Tipo]
FROM companias AS C
UNION
SELECT D.descripcion, 
	'Disqueria'
FROM disquerias AS D

-- a) Ver cantidad de temas por autor
-- b) Ver la cantidad de temas por grupo

SELECT A.nombre[Autor],
	COUNT(T.id_autor)[Cantidad Temas]
FROM temas AS T
	INNER JOIN autores AS A
		ON T.id_autor = A.id_autor
GROUP BY A.nombre