## Sales-System✨

### Sistema de Vendas

#### Estudo do desenvolvimento com o asp.net. 
#### CRUD básico que tem conexão com um banco de dados em MySQL.
<img align='center' alt="dancing" src="https://miro.medium.com/v2/resize:fit:1400/1*CsJ05WEGfunYMLGfsT2sXA.gif" width="400"/>


### 🧶MVC:
##### MVC é um padrão de desenvolvimento que divide a aplicação em Model, View e Controller.

#### Model, ou domain model, é o sistema e a estrutura dos dados e suas transformações. Nele estão as entidades e os serviços relacionados a ela. Em certos projetos, também tem repositories, objetos que acessam dados. 

#### Controllers recebem e tratam as interações do usuário com o sistema, ele faz a comunicação entre o model e o view.

#### View define as estruturas e o comportamento das telas, é o que o usuário interage.
##### As comunicações se dão da seguinte forma:
<img align='center' alt="dancing" src="https://github.com/majuliah/Sales-System/blob/main/readme-images/mvc%20structure.png?raw=true" width="300"/>

#### 
### 🧶Sobre o Entity Framework:

+ A comunicação entre paradigmas (orientação a objetos e modelo relacional) exige muito esforço de implementação. Implementar manualmente o esquema de conversão é um processo custoso e trabalhoso. Além disso, existem outras questões que devem ser consideradas ao implementarmos de maneira correta e limpa tais comunicações. Contexto de persistência diz respeito ao monitoramento de alterações nos objetos que estão ligados a uma conexão em dado momento de execução, e deve-se monitorar alterações, transações e concorrência. O Mapa de identidade diz respeito aos objetos carregados em cache, então precisamos de controle dos objetos para que a busca na memória não seja recorrente. O carregamento tardio diz respeito ao controle de objetos que serão carregados, se um objeto for atrelado a muitos outros objetos, o carregamento de todos ele não deve ser efetuado, e sim somente quando for necessário a sua utilização. 
####
+ Quando vamos implementar uma persistência de dados em uma aplicação orientada a objetos, a solução são as ORMs, que permitem programar no paradigma da orientação a objetos e isso automaticamente será transparente ao banco de dados relacional. No .net temos o Entity Framework Core, que fornece prividers que são comunicações com bancos de dados específicos. 
+ As principais classes do Entity Framework Core são a DbCOntext e a DbSet<TEntity>.
  + A DbContext é um objeto que encapsula uma sessão com o banco de dados. Quando instanciamos este objeto, estamos definindo uma conexão com o banco de dados e realizando operações com ele.
  + A DbContext é usada para consultar e salvar entidades, define quais entidades vão fazer parte do modelo de dados do sistema, define configurações e é uma combinação dos padrões Unity of Work e Repository.
    + Unity of Work -> mantém uma lista de objetos afetados por uma transação e coordena a escrita de mudanças e trata possíveis problemas de concorrência.
    + Repository -> define um objeto capaz de realizar operações de acesso a dados(consulta, atualização, salvamento, deletar) para uma entidade.
  ####
  + A DbSet<TEntity> representa a coleção de entidades de um tipo em um contexto, geralmente corresponde a uma tabela no banco de dados.
 ####
+ O processo geral para executar operações se dá em : LINQ -> DbSet -> SQL -> BANCO DE DADOS. Isso quer dizer que escrevemos em expressões lambda e as operações do linqvão ser convertidas em tempo de execução para tabelas em bancos de dados.
  

