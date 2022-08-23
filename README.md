Olá Dev's!
Aqui está mais um projeto bom para compartilhar com a comunidade. 
Há um tempo venho buscando uma forma de gerenciar melhor as verões dos meus projetos em produção. O ruim que as formas mais
funcionais são pagas... Com objetivo de melhorar o gerencimento com custo zero, eu busquei algumas ferramentas gratuítas na
internet e criei meu próprio projeto para Validação de versão de forma totalmente grátis e automática.
Resolvi compartilhar essa idéia com vocês. Caso tenham alguma dúvida, estou à disposição no Whatsapp +55 11 99667-1807 para 
auxiliar-los na implantação.


### 1 - Utilização da DLL Validacao
Nessa DLL, além de pensar em atualizar automaticamente, eu também pensei em um cenário onde o usuário fica rodando o sistema 
sem conexão de internet. Por isso eu criei algo simples e que sem dúvidas pode ser escrito de forma melhor e mais segura, 
porém no modelo em que está, tem me atendido até o momento. Nos próximos passos explicarei mais detalhes dessa validação.

### 2 - Agregação de um segundo projeto para realizar ações externas.
Criei um projeto console UPDATE (https://github.com/juniioroliveira/Update) para que ele seja executado quando houver uma nova
versão do projeto em questão. Programei ele para executar 3 passos:

• Copiar os arquivos da nova versão da pasta TEMP para a pasta RAIZ do projeto em questão
• Excluir os arquivos da pasta TEMP 
• Executar o sistema após concluir os 2 passos acima

Os arquivos da pasta Bin desse projeto deve ser jogados dentro da pasta do seu projeto em questão.

> Obs: Na maioria dos casos o antivirus barra a inicialização do sistema. Mais para frente devo implementar uma solução para isso.


### 3 - Implementar validação em seu projeto
Para que tudo funcione perfeitamente, primeiro é necessário adicionar uma "Referencia de projeto" ao projeto em questão 
e selecionar a DLL Validação para que seja possível acessar os recursos. Após adicionar a referência siga o mesmo modelo
da imagem abaixo:
> Print da inicialização para verificar e validar a versão do projeto
![image](https://user-images.githubusercontent.com/69655703/186058492-e4a75907-bbb7-42f6-bf5e-b48a10aa6e37.png)


### 3 - Utilização da DLL Validacao
Nessa DLL, além de pensar em atualizar automaticamente, eu também pensei em um cenário onde o usuário fica rodando o sistema 
sem conexão de internet. Por isso eu criei algo simples e que sem dúvidas pode ser escrito de forma melhor e mais segura, 
porém no modelo em que está tem me atendido até o momento. Nos próximos passos explicarei mais detalhes dessa validação.








PRINT DA CLASSE DE DOWNLOAD
![image](https://user-images.githubusercontent.com/69655703/186051508-c19325ba-0221-4314-a9ce-4fa9949343f3.png)

PRINT DE VERSÕES
![image](https://user-images.githubusercontent.com/69655703/186051605-5db9d45f-e0c1-4734-9f18-79a89b5727d7.png)

Projeto UPDATE
https://github.com/juniioroliveira/Update

