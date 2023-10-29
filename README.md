Razor é uma estratégia para desenvolvimento de páginas SSR (Server Side Rendering) onde todo o HTML é processado no lado do servidor e o resultado é retornado. Não permite (por padrão), uso do C# no lado do Cliente ("substituir" o javascript por C#), ao contrário do Blazor.

## Repositório

Confira o repositório com o código usado neste exemplo [Aqui]()

## Páginas

Diferente do padrão MVC, Razor Pages não usam Controllers, todo processamento é feito em um arquivo:  `{página} + .cs` ex:

![[Pasted image 20231028203736.png]]

Neste exemplo, o arquivo `Login.cshtml` contem todo o HTML da página. Um arquivo `.cshtml` muito parecido com as Views do MVC, com a adição do **@page** (Linha 3).
![[Pasted image 20231028204446.png]]


O arquivo `Login.cshtml.cs` é responsável por pegar (GET) os dados do banco e preparar para a tela. E para enviar informações para o banco (POST) via Formulários (\<form>). 

A diretiva `@model LoginModel` referencia essa classe abaixo 


![[Pasted image 20231028204324.png]]

Essa classe funciona como uma ViewModel + Controller. Aqui é possível definir os campos que vamos usar na página (veja exemplos posteriores) e preparar essas informações (usando o método `OnGet()`).

## Rotas

Como não temos controllers, precisamos de outra maneira de preparar as URLs para as páginas certo? Aqui está a solução das razor pages, rotas baseado em pastas!

![[razor-routes.png]]

Basta organizar as pastas do projeto e as rotas serão formadas automaticamente.

Arquivos com prefixo `_` (underline) são ignorados, o Razor entende que são **Partials** e não os renderiza.

## Estilo

Razor pertmite a estratégia de CSS Isolado, onde o conteúdo do arquivo CSS é apenas aplicado a página refente a ele, `{nome da página} + .css`.

Neste exemplo, o arquivo `Login.cshtml.css` usa diretamente a tag `h1`, o que faria com que todas as \<h1> em todas as páginas fossem alteradas, mas isto só acontece dentro da página Login.cshtml. 

> Confira o repositório no Github para uma demostração, acesse a página `/Account/Login` e veja que apenas o texto Login foi alterado para vermelho, por mais que a Navbar também contenha um \<h1>.

![[Pasted image 20231028210150.png]]

Isto também é valido para *Partials*, o que torna fácil criar pequenos componentes e soma-los posteriormente, promovendo reutilização de código, alem de mais facilidade e assertividade quando for alterar algo, pois tudo esta isolado!

## GET e POST

> Use como referencia, estas páginas:

![[Pasted image 20231028212916.png]]

Métodos **GET** são usados para pegar informações necessárias para recarregar a página, por exemplo, dados dos Blog_Posts de um Blog, são os dados que serão usados para desenhar a tela.

Métodos **POST** serão usados para enviar alguma informação ao servidor, por exemplo, os dados referentes a um novo Blog_Post.

### Create
Definimos dentro da própria classe, outra classe para usarmos de *Bind*, é a partir dela que iremos rastrear os campos dos **Forms**. É possível definir as validações aqui mesmo, elas  serão usadas ao enviar o forms.

Se os valores são validos, os dados são trafegados para outra Página, esta será de exibição.

![[Pasted image 20231028212514.png]]

E está é a página HTML referente a criação de um Blog Post. Note o uso de **Input.Title** e **Input.Body**, esses são os **BINDS**, são eles que conectam os valores do front ao back quando o form é enviado.

![[Pasted image 20231028213022.png]]

### Exibição

A página de exibição é ainda mais simples

Basicamente vamos pegar as informações recebidas pela URL e transformar em campos acessáveis pelo HTML.

![[Pasted image 20231028213549.png]]

Veja que é necessário avisar a página qual model estamos usando (Linha 4) para que assim possamos usar as propriedades nela definidas.

![[Pasted image 20231028213334.png]]
