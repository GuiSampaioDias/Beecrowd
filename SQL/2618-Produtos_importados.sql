/*

autor: Guilherme Sampaio Dias
exercício:  2618- Produtos Importados 
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select     prd.name, prv.name, cat.name
from       products   as prd

join       providers  as prv
on         prd.id_providers   = prv.id

join       categories as  cat
on         prd.id_categories  = cat.id

where      prv.name      =  'Sansul SA' 
           and  cat.name =  'Imported'
