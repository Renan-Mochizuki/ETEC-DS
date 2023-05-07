import Habilidades from '../components/Habilidades.jsx'

function Competencias() {

  return (
    <>
      <h2 id='titulo-habilidades'>Habilidades</h2>
      <div id='container-competencias'>
        <Habilidades
          img="https://cdn-icons-png.flaticon.com/512/1051/1051277.png"
          alt="HTML"
          habilidade="HTML"
          valor="80"
        />
        <Habilidades
          img="https://cdn-icons-png.flaticon.com/512/732/732190.png"
          alt="CSS"
          habilidade="CSS"
          valor="80"
        />
        <Habilidades
          img="https://cdn-icons-png.flaticon.com/512/5968/5968332.png"
          alt="PHP"
          habilidade="PHP"
          valor="60"
        />
        <Habilidades
          img="https://styles.redditmedia.com/t5_2su6s/styles/communityIcon_4g1uo0kd87c61.png?width=256&v=enabled&s=86f4a4bd647772d34d2de32a0e4281dd0ab095f1"
          alt="React"
          habilidade="React"
          valor="30"
        />
        <Habilidades
          img="https://cdn-icons-png.flaticon.com/512/6132/6132221.png"
          alt="C#"
          habilidade="C#"
          valor="50"
        />
        <Habilidades
          img="https://cdn-icons-png.flaticon.com/512/888/888839.png"
          alt="Java Android"
          habilidade="Java Android"
          valor="30"
        />
        <Habilidades
          img="https://cdn-icons-png.flaticon.com/512/5764/5764221.png"
          alt="Edição de imagem"
          habilidade="Edição de imagem"
          valor="40"
        />
        <Habilidades
          img="https://cdn-icons-png.flaticon.com/512/8361/8361118.png"
          alt="Edição de vídeo"
          habilidade="Edição de vídeo"
          valor="65"
        />
        <Habilidades
          img="https://cdn-icons-png.flaticon.com/512/5968/5968313.png"
          alt="MySQL"
          habilidade="MySQL"
          valor="70"
        />
        <Habilidades
          img="https://cdn-icons-png.flaticon.com/512/7819/7819053.png"
          alt="Inglês"
          habilidade="Inglês"
          valor="80"
        />
      </div>
    </>
  )
}

export default Competencias
