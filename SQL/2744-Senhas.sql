/*

autor: Guilherme Sampaio Dias
exerc�cio:  2744- Senhas                        
plataforma: Beecrowd
data: 08/09/2023
Linguagem: SQLServer

*/
select     id, password, md5(password) as MD5
from       account