/*

autor: Guilherme Sampaio Dias
exercício:  2617- Fornecedor Ajax SA  
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select    prd.name as name, pro.name as name
from      providers as pro
join      products  as prd
on        pro.id    =  prd.id_providers
where     pro.name  =  'Ajax SA'