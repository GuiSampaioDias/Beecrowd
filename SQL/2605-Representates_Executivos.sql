/*

autor: Guilherme Sampaio Dias
exercício:  2605- Representantes Executivos        
plataforma: Beecrowd
data: 07/09/2023
Linguagem: SQLServer

*/
select      prd.name, prv.name
from        products  as prd

join        providers as prv
on          prd.id_providers  =  prv.id

join        categories as cat
on          prd.id_categories  =  cat.id
where       cat.id = 6