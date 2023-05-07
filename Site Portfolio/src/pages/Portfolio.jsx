import Projetos from '../components/Projetos.jsx'

function Portfolio() {

  return (
    <div id='container-projetos'>
      <h2 className='titulo-projeto'>Projetos do 1º Ano do curso de DS</h2>
      <Projetos
        img={[{ src: "1Curriculo1", alt: "Currículo" }]}
        titulo="Currículo Web"
        texto="Esse site de um currículo web foi desenvolvido para treinar a composição de layouts, o funcionamento de divs e outras coisas como hyperlinks. O site possui alguns elementos semânticos e não foi desenvolvido com intenção de ser usado profissionalmente."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Site%20Curr%C3%ADculo%20Web"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/1051/1051277.png", alt: "HTML" },
          { src: "https://cdn-icons-png.flaticon.com/512/732/732190.png", alt: "CSS" }
        ]}
        lado="e"
      />
      <Projetos
        img={[{ src: "1Hamburgueria1", alt: "Hamburgueria" }]}
        titulo="Hamburgueria"
        texto="Com esse site de uma hamburgueria fictícia foi possível treinar o uso do elemento nav, carousel e outros elementos providos pelo framework bootstrap. Para prática, apenas foi desenvolvido a página avaliações."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Site%20Hamburgueria"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/1051/1051277.png", alt: "HTML" },
          { src: "https://cdn-icons-png.flaticon.com/512/732/732190.png", alt: "CSS" }
        ]}
        lado="d"
      />
      <Projetos
        img={[{ src: "1Pizzaria1", alt: "Pizzaria" }]}
        titulo="Pizzaria"
        texto="O intuito para esse site foi de prototipar o layout para que fosse desenvolvido em HTML e CSS e não teve a intenção de ser um site muito amplo. O conteúdo do site foi desenvolvido em uma página só, assim tendo uma barra de redirecionamento que leva até determinado ponto da página."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Site%20Pizzaria"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/1051/1051277.png", alt: "HTML" },
          { src: "https://cdn-icons-png.flaticon.com/512/732/732190.png", alt: "CSS" }
        ]}
        lado="e"
      />
      <Projetos
        img={[{ src: "1Witcher1", alt: "The Witcher" }]}
        titulo="The Witcher"
        texto="Nesse site sobre o jogo The Witcher 3, foi praticado o funcionamento das divs com flex, a responsividade do site e aprendi transições com :hover. O site possui diversas imagens sobre elementos do jogo como uma wiki."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Site%20The%20Witcher%203"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/1051/1051277.png", alt: "HTML" },
          { src: "https://cdn-icons-png.flaticon.com/512/732/732190.png", alt: "CSS" }
        ]}
        lado="d"
      />
      <Projetos
        img={[{ src: "1Mybuddy1", alt: "My Buddy" }]}
        titulo="My Buddy"
        texto="Esse site de uma instituição de adoção de animais pets, foi o último projeto do 1º ano do curso, incluindo todos os elementos já aprendidos e com uma proposta que acabou por ser inspiração para o TCC. O site possui uma página para adoção, exibindo pets em cards e para uma loja, além de uma página sobre."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Site%20My%20Buddy"
        video="https://youtu.be/0oY7PDFIAWs"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/1051/1051277.png", alt: "HTML" },
          { src: "https://cdn-icons-png.flaticon.com/512/732/732190.png", alt: "CSS" }
        ]}
        lado="e"
      />
      <h2 className='titulo-projeto'>Projetos do 2º Ano do curso de DS</h2>
      <Projetos
        img={[{ src: "2Livraria1", alt: "Livraria" }]}
        titulo="Livraria"
        texto="Esse site foi desenvolvido com integração ao banco de dados de uma livraria, onde foi utilizado PHP para fazer a conexão. O site possui o cadastro de autores, editoras, categorias e livros, seleção e alteração."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Site%20Livraria"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/1051/1051277.png", alt: "HTML" },
          { src: "https://cdn-icons-png.flaticon.com/512/732/732190.png", alt: "CSS" },
          { src: "https://cdn-icons-png.flaticon.com/512/5968/5968332.png", alt: "PHP" },
          { src: "https://cdn-icons-png.flaticon.com/512/5968/5968313.png", alt: "MySQL" }
        ]}
        lado="d"
      />
      <Projetos
        img={[{ src: "2Locadora9", alt: "Projeto Locadora" }]}
        titulo="Projeto Locadora"
        texto="Esse aplicativo para desktop sobre uma locadora de automóveis foi desenvolvido em C# no Visual Studio. O aplicativo possui cadastro de marcas, clientes, automóveis, locações, entre outros e foi desenvolvido com a intenção de facilitar o processo de cadastro."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Projeto%20Locadora"
        video="https://youtu.be/lSf-YjmGujk"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/6132/6132221.png", alt: "C#" },
          { src: "https://cdn-icons-png.flaticon.com/512/5968/5968313.png", alt: "MySQL" }
        ]}
        lado="e"
      />
      <Projetos
        img={[
          { src: "2Greattaste1", alt: "Great Taste" },
          { src: "2Greattaste2", alt: "Great Taste" },
          { src: "2Greattaste4", alt: "Great Taste" },
          { src: "2Greattaste5", alt: "Great Taste" }
        ]}
        titulo="Great Taste"
        texto="A ideia para esse aplicativo de Android é de reunir receitas que pessoas possam cadastrar, contudo, como o aplicativo foi desenvolvido sem banco de dados, o aplicativo foi feito como demonstração e possui diversas telas e redirecionamentos."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Aplicativo%20Great%20Taste"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/888/888839.png", alt: "Java Android" }
        ]}
        lado="e"
      />
      <Projetos
        img={[
          { src: "2Mybuddy1", alt: "My Buddy" },
          { src: "2Mybuddy2", alt: "My Buddy" },
          { src: "2Mybuddy9", alt: "My Buddy" },
          { src: "2Mybuddy10", alt: "My Buddy" }
        ]}
        titulo="My Buddy"
        texto="Esse aplicativo é sobre o mesmo projeto já desenvolvido em website sobre adoção de animais e para Android. O aplicativo foi desenvolvido com banco de dados com SQLite e tinha a intenção de integrar uma aba para adoções, cadastros, loja e doações, contudo, houve um problema com a criação de mais de uma tabela no banco de dados e com a inserção de imagens."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Aplicativo%20My%20Buddy"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/888/888839.png", alt: "Java Android" },
          { src: "https://media.trustradius.com/product-logos/6O/c7/R8JW30GR5ELU.PNG", alt: "SQLite" }
        ]}
        lado="d"
      />
      <h2 className='titulo-projeto'>Projetos do 2º Ano do curso de DS</h2>
      <Projetos
        img={[{ src: "3Paises1", alt: "API de Paises" }]}
        titulo="API de Paises"
        texto="Esse site foi desenvolvido com uma API Pública sobre países, podendo consultar diversas informações sobre países. O site possui um campo com diversos países e você pode consultar a sua bandeira, nome oficial, entre outros."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Site%20Paises"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/1051/1051277.png", alt: "HTML" },
          { src: "https://cdn-icons-png.flaticon.com/512/732/732190.png", alt: "CSS" },
          { src: "https://cdn-icons-png.flaticon.com/512/5968/5968332.png", alt: "PHP" }
        ]}
        lado="d"
      />
      <Projetos
        img={[{ src: "3Desconjuracao1", alt: "Desconjuração" }]}
        titulo="Desconjuração"
        texto="Esse site foi feito para treinar o consumo de arquivos JSON, assim fizemos um site sobre o RPG Ordem Paranormal, armazendo dados de personagens do RPG em JSON e consumindo-os com PHP."
        link="https://github.com/Renan-Mochizuki/ETEC-DS/tree/main/Site%20Desconjuracao"
        linguagens={[
          { src: "https://cdn-icons-png.flaticon.com/512/1051/1051277.png", alt: "HTML" },
          { src: "https://cdn-icons-png.flaticon.com/512/732/732190.png", alt: "CSS" },
          { src: "https://cdn-icons-png.flaticon.com/512/5968/5968332.png", alt: "PHP" }
        ]}
        lado="e"
      />
    </div>
  )
}

export default Portfolio