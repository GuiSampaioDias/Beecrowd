/*

autor: Guilherme Sampaio Dias
exerc�cio:  2613- Filmes em Promo��o      
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select    mo.id, mo.name
from      movies as mo
join      prices as pr
on        mo.id_prices  = pr.id
where     pr.value < 2