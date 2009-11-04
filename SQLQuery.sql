USE cd

-- 1. Ver las Disquerias y Companias con su respectivo Grupo
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
WHERE G.descripcion LIKE '%' + @nombre_grupo + '%'
ORDER BY 3, 2

-- 2. Ver cantidad de temas por autor y album seleccionados por genero
-- El genero es ingresado por programa

SELECT A.nombre[Autor],
	Al.titulo[Album],
	COUNT(T.id_autor)[Cantidad Temas]
FROM album AS Al
	INNER JOIN temas AS T
		ON Al.id_album = T.id_album
	INNER JOIN autores AS A
		ON T.id_autor = A.id_autor
	INNER JOIN generos AS G
		ON Al.id_genero = G.id_genero
WHERE G.descricpion LIKE '%' + @genero_descripcion + '%'
GROUP BY A.nombre, Al.titulo

-- 3. Ver album's sacados por anio
-- El anio es ingresado por programa ej. 2009

SELECT G.descripcion[Grupo], 
	A.titulo[Titulo],
	Ge.descricpion[Genero],
	MONTH(A.fecha_lanzamiento)[Fecha]
FROM album AS A
	INNER JOIN grupo AS G
		ON A.id_grupo = G.id_grupo
	INNER JOIN generos AS Ge
		ON A.id_genero = Ge.id_genero
WHERE A.id_album IN (
	SELECT Al.id_album
	FROM album AS Al
	WHERE Al.id_album = A.id_album 
		AND YEAR(Al.fecha_lanzamiento) = @anio
	)
ORDER BY 1, 4
	
-- Calcula la antiguedad de los discos de un grupo
-- El nombre del grupo, fechas y duracion son ingresado por programa

SELECT G.descripcion[Grupo], 
	A.titulo[Album],
	Ge.descricpion[Genero],
	C.descripcion[Compania],
	D.descripcion[Disqueria],
	CASE ISNULL(DATEDIFF(year, A.fecha_lanzamiento, getdate()), 0) 
		WHEN 0 THEN 'Falta Fecha Lanzamiento' END[Antiguedad],
	A.costo[Precio]
FROM album AS A
	INNER JOIN grupo AS G
		ON A.id_grupo = G.id_grupo
	INNER JOIN generos AS Ge
		ON A.id_genero = Ge.id_genero
	INNER JOIN companias AS C
		ON A.id_compania = C.id_compania
	INNER JOIN disquerias AS D
		ON A.id_disqueria = D.id_disqueria
WHERE G.descripcion LIKE '%' + @nombre_grupo + '%'
	OR (A.fecha_lanzamiento BETWEEN @fecha_inicial AND @fecha_final)
	AND A.duracion_album > @duracion_album
ORDER BY 1, 2, 6, 7