/*

autor: Guilherme Sampaio Dias
exerc�cio:  2616- Nenhuma Loca��o        
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select     cus.id, cus.name
from       customers as cus
left join  locations as lo
on         cus.id = lo.id_customers
where       lo.id_customers is Null