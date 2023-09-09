/*

autor: Guilherme Sampaio Dias
exercício:  2606- Categorias                 
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select         prd.id, prd.name
from           products   as prd
join           categories as cat
on             prd.id_categories = cat.id
where          cat.name like  'super%'