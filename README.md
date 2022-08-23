Olá Dev's!
Aqui está mais um projeto bom para compartilhar com a comunidade. 
Há um tempo venho buscando uma forma de gerenciar melhor as verões dos meus projetos em produção. O ruim que as formas mais
funcionais são pagas... Com objetivo de melhorar o gerencimento com custo zero, eu busquei algumas ferramentas gratuítas na
internet e criei meu próprio projeto para Validação de versão de forma totalmente grátis e automática.
Resolvi compartilhar essa idéia com vocês. Caso tenham alguma dúvida, estou à disposição no Whatsapp +55 11 99667-1807 para 
auxiliar-los na implantação.

### 1 - Agregação de um segundo projeto para realizar ações externas.
Criei um projeto console UPDATE (https://github.com/juniioroliveira/Update) para que ele seja executado quando houver uma nova
versão do projeto em questão. Programei ele para executar 3 passos:

• Copiar os arquivos da nova versão da pasta TEMP para a pasta RAIZ do projeto em questão
• Excluir os arquivos da pasta TEMP 
• Executar o sistema após concluir os 2 passos acima

Obs: Na maioria dos casos o antivirus barra a inicialização do sistema. Mais para frente devo implementar uma solução para isso.




PRINT DA INICIALIZAÇÃO PARA VERIFICAR VERSÃO
![image](https://user-images.githubusercontent.com/69655703/186051408-6e242c81-fee1-4866-b9b1-209bfa001656.png)

PRINT DA CLASSE DE DOWNLOAD
![image](https://user-images.githubusercontent.com/69655703/186051508-c19325ba-0221-4314-a9ce-4fa9949343f3.png)

PRINT DE VERSÕES
![image](https://user-images.githubusercontent.com/69655703/186051605-5db9d45f-e0c1-4734-9f18-79a89b5727d7.png)

Projeto UPDATE
https://github.com/juniioroliveira/Update

