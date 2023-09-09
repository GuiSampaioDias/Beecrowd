/*

autor: Guilherme Sampaio Dias
exercício:  2614- Locações de Setembro   
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select       cus.name, ren.rentals_date
from         customers  as cus
join         rentals    as ren
on           ren.id_customers = cus.id
where        ren.rentals_date > '2016-09-01' 
and          ren.rentals_date < '2016-09-30'