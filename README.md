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
Criei um projeto console [UPDATE](https://github.com/juniioroliveira/Update) para que ele seja executado quando houver uma nova
versão do projeto em questão. Programei ele para executar 3 passos:

- Copiar os arquivos da nova versão da pasta TEMP para a pasta RAIZ do projeto em questão
- Excluir os arquivos da pasta TEMP 
- Executar o sistema após concluir os 2 passos acima

Os arquivos da pasta Bin desse projeto deve ser jogados dentro da pasta do seu projeto em questão.

> Obs: Na maioria dos casos o antivirus barra a inicialização do sistema. Mais para frente devo implementar uma solução para isso.


### 3 - Implementar validação em seu projeto
Para que tudo funcione perfeitamente, primeiro é necessário adicionar uma "Referencia de projeto" ao projeto em questão 
e selecionar a DLL Validação para que seja possível acessar os recursos. Após adicionar a referência siga o mesmo modelo
da imagem abaixo:
> Print da inicialização para verificar e validar a versão do projeto
![image](https://user-images.githubusercontent.com/69655703/186058492-e4a75907-bbb7-42f6-bf5e-b48a10aa6e37.png)

- `LARANJA:` Rerencia da DLL
- `AMARELO:` Chamada do metodo da DLL Validacao
- `AZUL:` Passagem de parametro "Nome do programa"
- `VERDE:` Passagem de parametro "Versão do projeto em questão"

Se o retorno da validação for de Versão desatualizada, o metodo Download será chamado passando o parameto Item2 no retorno da Validação
onde contém o link de download dos arquivos da atualização.

> Print do metodo de Download
![image](https://user-images.githubusercontent.com/69655703/186051508-c19325ba-0221-4314-a9ce-4fa9949343f3.png)

Eu criei um classe separada com propriedades publicas para informar dados da versão pela necessidade de usar em outras 
situações dentro do projeto. Mas você pode fazer como preferir desde que a versão atual do projeto em questão seja informada
na chamada do metodo da validação.

> Print da classe de versão
![image](https://user-images.githubusercontent.com/69655703/186051605-5db9d45f-e0c1-4734-9f18-79a89b5727d7.png)

# Bom. A parte que todo mundo deve saber já foi passada. Agora vamos para parte que interessa...

### 1 - Onde anexar os arquivos de atualização?
Para utilizar esse metodo de validação, é necessário ter uma plataforma de hospedagem com link direto para download,
o que não foi nada fácil encontrar, seguindo a idéia que o projeto deveria ser 'Zero custo'.
Após muitas pesquisas e testes, consegui achar um conteúdo bacana utilizando o Google Drive que também compartilharei com vocês.

Primeiro é necessário anexar todos arquivos de atualização dentro de uma pasta compactada com extenção [.zip].
> Obs: Testei com outras extensões como [.rar] mas não funcionou.

Após feito isso, basta anexar o arquivo no Google Driver e compartilhar para gerar o link de download. Porém utilizaremos apenas 
o trecho circulado em `VERDE`
![image](https://user-images.githubusercontent.com/69655703/186063282-8446f01d-90d0-41ba-b07f-5dc302ca75e7.png)

### 2 - Gostei da idéia. Mas onde vou usar esse link ?
Mas uma vez, pensando no 'Zero custo', agora é necessário usar alguma plataforma onde é possível anexar dados e gerar um link exclusivo.
Com base nisso fui correndo para um site que muitos devem conhecer, o grandioso [Pastebin](https://pastebin.com/). 
Criei um bloco especifico onde fará todo sentido para as informações que passei acima. 

> Print do json no pastebin
![image](https://user-images.githubusercontent.com/69655703/186064940-1df91be7-51c4-4c51-af34-dc78870eb090.png)

No print acima eu destaquei os principais campos referenciados na validação sendo eles:

- Nome do projeto
- versão
- Link para Download

### Para finalizar, o que eu faço com o trecho do link gerado no Google Drive?

A imagem abaixo já diz tudo.
Basta colar o trecho na parte indicada na imagem que o link se tornará Auto-Run fazendo com que toda a idéia funcione corretamente
![image](https://user-images.githubusercontent.com/69655703/186065680-ba7a148d-549b-4eb9-811d-1dcdc3851d25.png)



Então é isso galera. Espero que tenham gostado da idéia. Se tiverem algo a acrescentar para melhorar, estou à disposição. 
Até mais!


