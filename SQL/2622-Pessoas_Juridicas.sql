/*

autor: Guilherme Sampaio Dias
exercício:  2622- Pessoas Jurídicas       
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select      cus.name
from        customers    as cus
join        legal_person as leg
on          cus.id  =  leg.id_customers
where       cus.id  =  leg.id_customers