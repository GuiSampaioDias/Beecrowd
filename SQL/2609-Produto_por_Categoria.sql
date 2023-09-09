/*

autor: Guilherme Sampaio Dias
exercício:  2609- Produtos por Categoria  
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select          cat.name, sum(pro.amount)

from            categories as cat
join            products   as pro
on              cat.id = pro.id_categories
group by        cat.name