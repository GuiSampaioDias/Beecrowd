/*

autor: Guilherme Sampaio Dias
exercício:  2611- Filmes de Ação          
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select   mo.id, mo.name
from     genres as ge
join     movies as mo 
on       ge.id = mo.id_genres 
where    ge.description = 'Action'