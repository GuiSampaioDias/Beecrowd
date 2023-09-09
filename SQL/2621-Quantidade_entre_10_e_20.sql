/*

autor: Guilherme Sampaio Dias
exercício:  2621- Quantidade entre 10 e20    
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select       prd.name
from         products  as prd
join         providers as prv
on           prd.id_providers = prv.id
where        (prd.amount >= 10 and prd.amount <= 20)
and          prv.name like 'P%'