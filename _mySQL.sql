/* Funcion IF: Solo muesta un resultado entre verdadero y falso*/
SELECT user, email, IF(status=1, 'Activo', 'Inactivo') AS Estado FROM users;

/* Funcion CASE: Igual que if genera una condicion solo que case puede regresar mas valores como respuesta*/
/* FORMA 1*/
SELECT user, email, CASE WHEN status =1 THEN 'Activo' ELSE 'Inactivo' END AS Estado FROM users
/* FORMA 2 y mas recomendable*/
SELECT 
    user,
    emal,
    CASE status
        WHEN 0 THEN 'Eliminado'
        WHEN 1 THEN 'Activo'
        WHEN 2 THEN 'Inactivo'
    END AS Estado
FROM
    users;
/*DENTRO DE LOS THEN PODEMOS EJECUTAR FUNCIONES Y SUBCONSULTAS  */

/*
IFNULL(CONSULTA, Val) : IFNULL sirve para cualquier campo del lado del SELECT y con el le indicamos
                        que valor queremos mostrar si el resultado es null´

SUBSTR(column, caracterComienzo, cuantosCaracteres) : Esta funcion substrae una parte de un string ejem
                Nombre = 'María Robles SUBSTR(Nombre, 1,5) AS Abreviatura   TODO 'Maria'

DATABASE(): muestra la base de datos que se esta usando
CURRENT_USER : muestra el usuario que esta usando la base de datos
CURRENT_DATE: Se obtiene la fecha actual
CURRENT_TIME: Se obtiene la hora actual 
CURRENT_TIMESTAMP(): Regresa la fecha actual con hora hasta segundos
DATEDIFF(fechaMasActual, fechaMasAntigua): Muestra cuantos dias han pasado entre una fecha y otra ejm
            DATEDIFF('2023-04-24', '2020-04-24') AS Dias    TODO   1095
            DATEDIFF(CURRENT_DATE, '2020-04-24') AS Dias    TODO   1338

YEAR(fecha): Regresa el año por numero TODO 2023
MONTH(fecha): Regresa el mes por numero
DAY(fecha): Regresa el dia del mes
DAYOFWEEK(fecha): Regresa el dia de la semana por numero 1-Domingo 7-Sabado
ADDDATE(fecha, diasAdd): permite agregar dias a una fecha
                        ADDDATE('2023-12-12', 12) AS NvaFecha  TODO  2023-12-24
                        ADDDATE(CURRENT_TIMESTAMP()), '00:15:00') AS NvaHora;  Agrega 15 minutes a la hora actual

DATE_ADD(fecha, INTERVAL): permite agregar dias meses o años a una fecha
                        DATE_ADD(CURRENT_DATE, INTERVAL 3 MONTH)
                        DATE_ADD(CURRENT_DATE, INTERVAL 2 DAY)
                        DATE_ADD(CURRENT_DATE, INTERVAL 5 YEAR)

DATE_SUB(): similaral DATE_ADD pero este no agrega si no resta dias meses años a la fecha

DATE_FORMAT(fecha, param): Formetea un elemento de la fecha ya sea el años, mes y dia
                        date_format('2023-12-12', '%Y')  TODO 2023
                        date_format('2023-12-12', '%y')  TODO 23   año en dos digitos
                        date_format('2023-12-12', '%m')  TODO 12 num del mes
                        date_format('2023-12-12', '%M')  TODO December nombre del mes
                        date_format('2023-12-12', '%d')  TODO 12 num del dia
                        date_format('2023-12-12', '%D')  TODO 12th
                        date_format('2023-12-12', '%w')  TODO 2 dia de la semana
                        date_format('2023-12-12', '%W')  TODO Tuesday nombre del dia de la semana;
                        date_format(current_timestamp, '%H') TODO 14 hora en formato de 24  
                        date_format(current_timestamp, '%h') TODO 02 hora en formato de 12  
                        date_format(current_timestamp, '%p') TODO PM o AM
                        date_format(current_timestamp, '%i') TODO minutos de la hora
                        date_format(current_timestamp, '%s') TODO segundos de la hora


CAST(valor AS TipoDato): convierte un valor en un tipo de dato determinado
                        CAST(12345 AS CHAR)   TODO '12345'

CHAR_LENGTH(campo): DEvuelve la longitud de un campo string por medio de un numero  Maria TODO 5
COMPRESS(campo): Comprime datos
UNCOMPRESS(COMPRESS(campo)): Descomprime columna que esta comporimida
CONCAT(nombre, apellidoP, apellidoM): Permite unir varios campos en uno solo  TODO José Perez Leon
CONCAT_WE(' ', nombre,apellidoP,apellidoM): Permite unir varios campos en uno solo usando un delimitador TODO José Perez Leon

CONV("numConvetir", sistema, sisPara Convertir) Convierte un numero de un sistema a otro
                CONV("666", 10, 2)  convierte el 666 a 666 en binario TODO 1010011010


JOINS : Los Join son funciones que nos permiten unir tablas para consultar su informacion en una consulta
 Estructura Del Join
    INNER JOIN tabla-a-unir ON col-de-tabla-a-coincidir = id-tabla-a-unir

    INNER JOIN o JOIN : Palabra reservada para el uso de join
    teams  Es el nombre de la tabla con la queremos hacer union 
    ON  : Palabra reservada para indicar donde o conque columna haremos la union
    player_team : nombre del campo de la tabla que servira como referencia para hacer la union
    team_id : Es la columna de la tabla con la que vamos hacer union y servira para hacer union con el campo de la tabla de referencia
 
 En este caso usaremos dos tablas una llamada players y otra llamada teams con la sig estructura
 players
 +------------+------------+-------------+---------------+
 | player_id  | player_nom | player_team | player_dorsal / 
 +------------+------------+-------------+---------------+
 | 1          | Messi      |  33         |  10           |
 +------------+------------+-------------+---------------+

 teams
  +------------+------------+
 | team_id     | team_nom   |  
 +-------------+------------+
 | 33          | Miami      |
 +-------------+------------+

 Ahora haremos un ejemplo de una consulta con un join
 SELECT player_nom AS nombre, player_dorsal AS dorsal, team_nom as equipo INNER JOIN teams ON player_team = team_nom; 

 Esto nos dara como resultado lo sig
 +---------+--------+--------+
 | nombre  | dorsal | equipo |  
 +---------+--------+--------+
 | Messi   | 10     |  Miami |
 +---------+--------+--------+
Ejemplo de join con tres tablas y filtros
*/
SELECT team_nom, player_nom, sponsor_nom FROM teams 
 JOIN ligas ON team_liga = liga_id AND liga_nom ='Liga Premier'
 JOIN sponsors on team_sponsor = sponsor_id AND sponsor_nom = 'Nike'
 JOIN players on player_team = team_id 
 GROUP BY player_nom;

/* LEFT JOIN : es otra manera de hacer union entre tablas solo que a diferencia del join que muestra los resultados
                de las columnas que coincidan o el join Left join le da prioridad a la tabla de que
                este a la izquierdo mostrando todos los resultados de esa tabla tengan coincidencia o no
                con la tabla con la que se une*/

/* RIGHT JOIN : es otra manera de hacer union entre tablas semejante al LEFT JOIN solo que la diferencia 
                es que el RIGHT JOIN le da prioridad a la tabla de que
                este a la derecha mostrando todos los resultados de esa tabla tengan coincidencia o no
                con la tabla con la que se une*/
SELECT producto, descripcion
FROM productos
LEFT JOIN ventas on producto_id = ventas_id   /*LEFT JOIN indica que la tabla principal o de relevancia sera Productos*/
RIGHT JOIN ventas on producto_id = ventas_id  /*RIGHT JOIN indica que la tabla principal o de relevancia sera ventas*/
GROUP BY producto_id
         

SUBCONSULTAS
Las subconsultas son consultas que se pueden agregar o anidar dentro de un SELECT un FROM o un WHERE
*/



SELECT codeGerente,
  SUM(esExterno AND Estado) EmailExternoTotal,
  SUM(NOT esExterno AND Estado) EmailInternoTotal
  FROM envios
  GROUP BY codeGerente;
  
SELECT 
    T.codeGerente,
    SUM(Externo) AS TotalExterno,
    SUM(Interno) AS TotalInterno
FROM
    (SELECT 
        codeGerente,
            CASE esExterno
                WHEN 1 THEN 1
                ELSE 0
            END AS Externo,
            CASE esExterno
                WHEN 0 THEN 1
                ELSE 0
            END AS Interno
    FROM
        envios
    WHERE
        estado = 1) T
GROUP BY T.codeGerente;







