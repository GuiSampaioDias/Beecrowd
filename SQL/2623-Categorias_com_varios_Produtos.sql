/*

autor: Guilherme Sampaio Dias
exercício:  2623- Categorias com Vários Produtos
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select     pro.name, cat.name
 
 from       products   as pro
 join       categories as cat
   on       pro.id_categories = cat.id
where       pro.amount > 100 and       
(cat.id = 1 or cat.id = 2 or cat.id = 3 or cat.id = 6 or cat.id = 9)
order by    cat.id asc