/*

autor: Guilherme Sampaio Dias
exercício:  2620- Pedidos no Primeiro Semestre
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select     cus.name, ord.id
from       customers as cus
join       orders    as ord
on         cus.id  =  ord.id_customers 
where      ord.orders_date > '2016-01-01'
and        ord.orders_date < '2016-06-30'

