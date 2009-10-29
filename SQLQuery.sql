USE cd

-- Ver las Disquerias y Companias con su respectivo Grupo
-- El nombre del grupo es ingresado por programa

SELECT C.descripcion[Nombre], 
	'Compania'[Tipo],
	G.descripcion + ' : ' + A.titulo[Grupo : Album]
FROM album as A
	INNER JOIN companias AS C
		ON A.id_compania = C.id_compania
	INNER JOIN grupo AS G
		ON A.id_grupo = G.id_grupo
WHERE G.descripcion LIKE '%@nombre_grupo%'
UNION
SELECT D.descripcion, 
	'Disqueria',
	G.descripcion + ' : ' + A.titulo
FROM album as A
	INNER JOIN disquerias AS D
		ON A.id_disqueria = D.id_disqueria
	INNER JOIN grupo AS G
		ON A.id_grupo = G.id_grupo
WHERE G.descripcion LIKE '%@nombre_grupo%'
ORDER BY 3, 2

-- Ver cantidad de temas por autor y album

SELECT A.nombre[Autor],
	Al.titulo[Album],
	COUNT(T.id_autor)[Cantidad Temas]
FROM album AS Al
	INNER JOIN temas AS T
		ON Al.id_album = T.id_album
	INNER JOIN autores AS A
		ON T.id_autor = A.id_autor
GROUP BY A.nombre, Al.titulo

-- Ver album's sacados por anio
-- El anio es ingresado por programa ej. 2009

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
		AND YEAR(Al.fecha_lanzamiento) = @anio
	)
ORDER BY 1, 3
	
-- Calcula la antiguedad de los discos de un autor
-- El nombre del grupo es ingresado por programa

SELECT G.descripcion[Grupo], 
	A.titulo[Album],
	CASE ISNULL(DATEDIFF(year, A.fecha_lanzamiento, getdate()), 0) 
		WHEN 0 THEN 'Falta Fecha Lanzamiento' END[Antiguedad]
FROM album AS A
	INNER JOIN grupo AS G
		ON A.id_grupo = G.id_grupo
WHERE G.descripcion LIKE '%@nombre_grupo%'









-- CREACION DE STORE PROCEDURE

CREATE PROCEDURE sp_SeleccionNombreConjunto_Solista
	@tipo bit
AS
	SELECT G.descripcion
	FROM grupo AS G
	WHERE G.solista_conjunto = @tipo