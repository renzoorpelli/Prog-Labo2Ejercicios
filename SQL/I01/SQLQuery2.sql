use EMPRESA_DB;
GO

create table empleados(
ID_EMPLEADO int identity primary key,
NOMBRE varchar(100) NOT NULL,
APELLIDO varchar(100) NOT NULL,
ID_PUESTO int NOT NULL ,
SALARIO float NOT NULL,
ESTA_ACTIVO bit NOT NULL,
FECHA_ALTA date NOT NULL,
FECHA_BAJA DATE NULL,
MAIL varchar(150) NULL
)

create table puestos(
ID_PUESTO int primary key,
NOMBRE varchar(200) NOT NULL,
NIVEL_AUTORIZACION INT NOT NULL,
)


insert into puestos (ID_PUESTO,NOMBRE, NIVEL_AUTORIZACION) values
(1,'Director',3),
(2,'Gerente',3),
(3,'Jefe de sector',2),
(4,'Administrativo',1),
(5,'Vendedor',0),
(6,'Secretario',2);


insert into empleados(NOMBRE,APELLIDO, ID_PUESTO, SALARIO,ESTA_ACTIVO,FECHA_ALTA, FECHA_BAJA,MAIL)values
('Leilani','Kinney',1,383946.80,1,'1996-03-21',NULL,'lkinney@gmail.com'),
('Igor','England',5,283558.85,1,'2013-03-28',NULL,'iengland@hotmail.com'),
('Maya','Brock',3,	164546.09,1,'1993-10-24',NULL,NULL),
('Hayden','Moss',4,211695.50,0,'2013-03-28','2015-02-19','hmoss@gmail.com'),
('Amal','Colon',2,388933.60,1,'2013-03-28', NULL,NULL)

select * from empleados
select * from puestos


--4 consultas
--I Todos los empleados con todos sus datos.
select * from empleados
--II El nombre (y s�lo eso) de todos los puestos.
select NOMBRE from puestos
--III S�lo los empleados que est�n activos (ESTA_ACTIVO = 1).
select * FROM empleados WHERE ESTA_ACTIVO = 1
--IV Los empleados cuyo salario sea mayor a $200.000,00.
select * FROM empleados WHERE SALARIO > 200000
--V Los empleados cuya fecha de alta sea menor o igual al 07/06/2012.
select * FROM empleados WHERE FECHA_ALTA >= '07/06/2012'
--VI Los empleados que no tengan mail cargado.
select * FROM empleados WHERE MAIL is NULL
--VII Los empleados que tengan mail cargado.
select * FROM empleados WHERE MAIL IS NOT NULL
--VIII Los empleados cuyo mail sea de gmail.
select * FROM empleados where MAIL LIKE '%gmail%'
--IX Los empleados cuyo apellido empiece con la letra "B".
select * from empleados where NOMBRE LIKE 'B%'

-- 5 consultas
--I Los empleados que est�n activos y ganen m�s de $300.000,00.
select * FROM empleados WHERE ESTA_ACTIVO = 1 AND SALARIO > 300000
--II  Los empleados que no tengan mail o no est�n activos. 
select * FROM empleados WHERE ESTA_ACTIVO = 0 OR MAIL IS NULL
--III Los empleados que tengan mail y su nombre contenga la letra "a".
select * FROM empleados WHERE MAIL IS NOT NULL AND NOMBRE LIKE '%a%'
-- IV Los empleados que ganen $250.000,00 o m�s y hayan ingresado despu�s del a�o 2000 inclusive, 
--o aquellos que ganen menos de $250.000,00 y hayan ingresado antes del a�o 2000 sin incluir.
select * FROM empleados WHERE FECHA_ALTA > '01/01/2000' AND SALARIO > 300000 OR 
SALARIO < 250000 AND FECHA_ALTA < '01/01/2000'
--V Los empleados cuyo salario est� entre $100.000,00 y $250.000,00.
select * FROM empleados WHERE SALARIO > 100000 AND SALARIO < 250000
-- VI Los empleados cuyo salario NO est� entre $100.000,00 y $250.000,00.
select * FROM empleados WHERE SALARIO < 100000 OR SALARIO > 250000
--VII Los puestos con nivel de autorizaci�n 0, 1 o 2.
select * FROM puestos WHERE NIVEL_AUTORIZACION = 0 or NIVEL_AUTORIZACION=1 or NIVEL_AUTORIZACION = 2
--VIII Los puestos con nivel de autorizaci�n distinto a 0, 1 y 2. 
select * FROM puestos WHERE NIVEL_AUTORIZACION > 2

-- 6 CONSULTAS
-- I Los empleados activos ordenados alfab�ticamente por su apellido de manera ascendente.
select * FROM empleados WHERE ESTA_ACTIVO=1 order by APELLIDO asc
-- II Los tres empleados m�s viejos.
select TOP(3)* FROM empleados ORDER BY FECHA_ALTA ASC 
-- III Los tres empleados que m�s ganan
select TOP(3)* FROM empleados ORDER BY SALARIO DESC
--IV Todos los datos de los empleados ordenados por el valor de sus salarios de manera descendente.
select * FROM empleados ORDER BY SALARIO DESC
-- V Los distintos niveles de autorizaci�n de los puestos, sin repetir. 
select DISTINCT NIVEL_AUTORIZACION FROM puestos 

-- 7 CONSULTAS
--I El nombre y apellido de los empleados, junto al nombre de su puesto.
select empleados.NOMBRE, empleados.APELLIDO , puestos.NOMBRE from puestos
inner join empleados on puestos.ID_PUESTO = empleados.ID_PUESTO


--II Los empleados que tengan un puesto con nivel de autorizaci�n igual a 3. 
SELECT * FROM empleados
inner join puestos on puestos.ID_PUESTO = empleados.ID_PUESTO and puestos.NIVEL_AUTORIZACION =3

--III El nombre y apellido de los empleados, junto al nombre de su puesto, 
--ordenados alfab�ticamente por apellido del empleado de manera ascenden
select empleados.NOMBRE, empleados.APELLIDO , puestos.NOMBRE from puestos
inner join empleados on puestos.ID_PUESTO = empleados.ID_PUESTO ORDER BY empleados.APELLIDO ASC

--IV  El nombre y apellido de los empleados, junto al nombre de su puesto, 
--ordenados alfab�ticamente por nombre del puesto de manera ascendente. 
select empleados.NOMBRE, empleados.APELLIDO , puestos.NOMBRE from puestos
inner join empleados on puestos.ID_PUESTO = empleados.ID_PUESTO ORDER BY puestos.NOMBRE ASC

-- V Nombre, apellido y nombre del puesto de los empleados que est�n activos, 
--ordenados por su nivel de autorizaci�n de forma ascendente.
select empleados.NOMBRE, empleados.APELLIDO , puestos.NOMBRE from puestos 
inner join empleados on puestos.ID_PUESTO = empleados.ID_PUESTO WHERE empleados.ESTA_ACTIVO =1
ORDER BY puestos.NIVEL_AUTORIZACION ASC

--VI Los puestos que no tengan empleados asociados. --left excluding join
SELECT * FROM puestos left join empleados on empleados.ID_PUESTO = puestos.ID_PUESTO
where empleados.ID_PUESTO is null

--VII Los puestos que tienen empleados asociados.
SELECT * FROM puestos left join empleados on empleados.ID_PUESTO = puestos.ID_PUESTO
where empleados.ID_PUESTO is not null

-- 8 CONSULTAS

--I El promedio de los salarios de todos los empleados que est�n activos.

SELECT SUM(SALARIO)/ COUNT(SALARIO) AS PROMEDIO_SALARIO FROM empleados WHERE ESTA_ACTIVO = 1

-- II La suma de los salarios de todos los empleados que est�n activos.
SELECT SUM(SALARIO) AS SUMA_SALARIO FROM empleados WHERE ESTA_ACTIVO = 1

-- III La cantidad de empleados que ganan m�s de $250.000,00.
SELECT COUNT(SALARIO) FROM empleados WHERE SALARIO > 250000

-- IV La cantidad de empleados que ingresaron antes del a�o 2010. 
SELECT COUNT(SALARIO) FROM empleados WHERE FECHA_ALTA < '01/01/2010'

-- V El salario m�s alto.
SELECT TOP(1) SALARIO  FROM empleados ORDER BY SALARIO DESC

-- VI Los puestos con el nivel de autorizaci�n m�s bajo.
SELECT min(NIVEL_AUTORIZACION) from puestos

-- VII El nombre completo de todos los empleados (concatenado).
SELECT CONCAT(NOMBRE,' ',APELLIDO) AS NOMBRE_COMPLETO  FROM empleados 

-- VIII El nombre completo de todos los empleados (concatenado), el nombre de su puesto y su nivel de autorizaci�n.
select CONCAT(empleados.NOMBRE,' ',empleados.APELLIDO) AS NOMBRE_COMPLETO , puestos.NOMBRE, puestos.NIVEL_AUTORIZACION  
from puestos 
inner join empleados on puestos.ID_PUESTO = empleados.ID_PUESTO 

-- IX El nombre completo de todos los empleados (concatenado), el nombre de su puesto y su nivel de autorizaci�n. 
--Y los puestos con su nivel de autorizaci�n que no tengan empleados asociados. 
--Todo en una misma consulta.
select CONCAT(empleados.NOMBRE,' ',empleados.APELLIDO) AS NOMBRE_COMPLETO , puestos.NOMBRE, puestos.NIVEL_AUTORIZACION  
from puestos 
LEFT join empleados on puestos.ID_PUESTO = empleados.ID_PUESTO 

--10 AGREGAR Agregar el mail mbrock@yahoo.com a Maya Brock filtrando por su ID_EMPLEADO. 
--Verificar con una consulta la correcta ejecuci�n del comando. 
UPDATE empleados SET MAIL = 'mbrock@yahoo.com' WHERE ID_EMPLEADO=3
SELECT * FROM empleados

--11 Cambiar el puesto de Maya Brock a Administrativo y su salario a $210.000,00.
UPDATE empleados SET ID_PUESTO = 1  WHERE ID_EMPLEADO=3
UPDATE empleados SET SALARIO = 210000  WHERE ID_EMPLEADO=3
SELECT * FROM puestos

--12 Dar un aumento del 25% a todos los empleados que ganen menos de $250.000,00.
UPDATE empleados SET SALARIO = SALARIO + (SALARIO*0.25) WHERE SALARIO < 250000
--14 Hacer una baja l�gica del empleado con ID = 1, sin olvidar cargar su fecha de baja. Verificar con una consulta la correcta ejecuci�n del comando
UPDATE empleados SET FECHA_BAJA = GETDATE() where ID_EMPLEADO = 1;

-- 15Hacer una baja f�sica a todos los empleados que no est�n activos. Verificar con una consulta la correcta ejecuci�n del comando.
delete from empleados where ESTA_ACTIVO = 0;


-- la cantidad de empleados que ganan por encima del promedio 

select COUNT(*) from empleados
where empleados.salario > (
    select avg(empleados.salario) from empleados
)''
