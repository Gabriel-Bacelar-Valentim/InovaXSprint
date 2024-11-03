<h1>Integrantes:</h1>
Lucas dos Santos Lopes RM:550790
Murilo Machado RM:550718
Victor Taborda Rodrigues RM:97900
Gustavo Marques Catelan RM:551823
Gabriel Bacelar Valentim RM:97901

<h1>Explicação da Arquitetura:</h1>
A arquitetura do projeto segue um modelo monolítico, onde todos os componentes da aplicação estão integrados dentro de uma única solução. As diferentes responsabilidades, como controle de dados, interface de comunicação e lógica de negócios, estão separadas em projetos distintos dentro da mesma solução, o que facilita o desenvolvimento e a manutenção, mas ainda mantém todas as partes interligadas e executadas como um único serviço.

<h1>Justificativa da escolha:</h1> 
Optou-se por uma arquitetura monolítica para garantir simplicidade de desenvolvimento e facilitar a integração entre os componentes. Em fases iniciais de um projeto, o modelo monolítico permite iterações rápidas e fácil gestão dos componentes. A escolha por uma arquitetura monolítica também é vantajosa para cenários em que não há uma demanda por escalabilidade distribuída ou quando o time de desenvolvimento é pequeno e se busca uma menor complexidade operacional.

<h1>Design Patterns Utilizados</h1>
Foram aplicados alguns padrões de design ao longo do projeto:
Singleton: Implementado na classe Logger para garantir que exista apenas uma instância desta classe durante o ciclo de vida da aplicação.
Repository: Utilizado para centralizar as operações de acesso ao banco de dados, separando a lógica de persistência da lógica de negócio. Esse padrão facilita a manutenção e o reaproveitamento de código.

<h1>Instruções para rodar a API</h1>

1- Clone o repositório ou extraia os arquivos zipados dentro do Visual Studio 2022.
2- No Visual Studio, selecione o modo de execução https.
3- Clique em Run para iniciar a API.
4- Você será direcionado automaticamente para o Swagger no endereço:
https://localhost:7201/swagger/index.html
Esse será o ambiente onde você poderá testar as requisições da API.

<h1>TESTE </h1>
Foi feito um teste que ele verifica o valor do CEP passado, e se for verdadeiro ele procede devolvendo todas as informacoes, agora se o cep nao concidir ele retorna um erro de o cep esta incorreto


<h1>TESTES MODEL : </h1>

GET API - NAME: APPLE IPHONE 14/ Samsung Galaxy S22/ Dell XPS 13

PREDICT MODEL - NAME: APPLE IPHONE 14/ Samsung Galaxy S22/ Dell XPS 13;
	      - CATEGORY: SMARTPHONES/ HEADPHONES/ CAMERAS;

<h1>Funcionalidade da IA</h1>
Nós desenvolvemos uma IA preditiva que com base nos dados do csv, que fora implementado, ela irá prever o preco medio do produto que o cliente esta a procura.
Acima eu deixei alguns de nossos produtos que voce pode testar, tanto a requisicao como o a predicao de valor medio do produto.

<h1>Praticas de Clean Code</h1>
-Nomes Significativos
-Estruturacao Consistente
-Codigo Autoexplicativo
-Organizacao do Codigo
-Principio DRY
     
