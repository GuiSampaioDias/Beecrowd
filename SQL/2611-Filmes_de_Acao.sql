/*

autor: Guilherme Sampaio Dias
exerc�cio:  2611- Filmes de A��o          
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select   mo.id, mo.name
from     genres as ge
join     movies as mo 
on       ge.id = mo.id_genres 
where    ge.description = 'Action'