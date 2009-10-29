USE cd

-- Ver las Disquerias y Companias

SELECT C.descripcion[Nombre], 
	'Compania'[Tipo]
FROM companias AS C
UNION
SELECT D.descripcion, 
	'Disqueria'
FROM disquerias AS D

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
	
-- Costo total de todos los album's por grupo

-- ############ CONSULTAS HECHAS POR LEO ############

--1 Cuantos temas  tiene el primer Album, cual es la duracion total  del album y cuantas disquerias las vendieron,
--Nombrar como CANTIDAD E TEMAS, DURACION TOTAL DE TEMAS y DISQUERIAS

select	count(T.id_tema)[Cantidad de temas],
		sum(T.duracion)[Duracion total del album],
		D.descripcion[Disqueria]
from	temas as T, album as A, disquerias as D
where	A.id_album = T.id_album
and		A.id_disqueria = D.id_disqueria
group by D.descripcion


--2 Cuantos estilos puede tener un grupo?
-- Cual es el estilo del grupo por cada album?

select * from generos
select * from grupo
select * from album

select	Gr.descripcion[Grupo],
		Ge.descricpion[Genero],
		A.titulo[Album]
from	album as A, generos as Ge, grupo as Gr
where	A.id_genero = Ge.id_genero
and		A.id_grupo = Gr.id_grupo


incompletas
--3 mostrar el ultimo disco lanzado 

select	A.titulo,
		A.fecha_lanzamiento
from	album as A
--where
having max(A.fecha_lanzamiento)	
--4 










-- CREACION DE STORE PROCEDURE

CREATE PROCEDURE sp_SeleccionNombreConjunto_Solista
	@tipo bit
AS
	SELECT G.descripcion
	FROM grupo AS G
	WHERE G.solista_conjunto = @tipo

