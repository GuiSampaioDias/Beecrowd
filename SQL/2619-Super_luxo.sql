/*

autor: Guilherme Sampaio Dias
exercício:  2619- Super Luxo          
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select     prd.name, prv.name, prd.price
from       products  as prd

join       providers as prv
on         prd.id_providers  =  prv.id

join       categories as cat
on         prd.id_categories  = cat.id

where      prd.price > 1000 and cat.name = 'Super Luxury'
