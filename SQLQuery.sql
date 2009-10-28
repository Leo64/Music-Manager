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

-- Ver que album's fueron sacados este año

SELECT G.descripcion[Grupo], 
	A.titulo[Titulo],
	MONTH(A.fecha_lanzamiento)[Fecha]
FROM album AS A
	INNER JOIN grupo AS G
		ON A.id_grupo = G.id_grupo
WHERE A.id_album IN (
	SELECT Al.id_album
	FROM album AS Al
	WHERE Al.id_album = A.id_album 
		AND YEAR(Al.fecha_lanzamiento) = YEAR(getdate())
	)
	
-- Costo total de todos los album's por grupo

