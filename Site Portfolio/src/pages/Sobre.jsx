import Icone from '../components/Icones.jsx'
import Info from '../components/Info.jsx'

function Contato() {

  return (
    <>
      <div id='container-sobre'>
        <div className='flex-sobre'>
          <h4>Sobre</h4>
          <Info
            img="https://cdn-icons-png.flaticon.com/512/5404/5404967.png"
            alt="Cursando"
            texto="Cursando Desenvolvimento de Sistemas na Etec Ermelinda Giannini Teixeira (2021 - 2023)"
          />
          <Info
            img="https://cdn-icons-png.flaticon.com/512/8299/8299807.png"
            alt="Idade"
            texto="16 anos"
          />
          <Info
            img="https://cdn-icons-png.flaticon.com/512/3138/3138736.png"
            alt="Local"
            texto="Santana de Parnaíba - SP"
          />
        </div>
        <div className='flex-contato'>
          <h4>Contato</h4>
          <Icone
            link="https://www.instagram.com/renan.rov/"
            img="https://cdn-icons-png.flaticon.com/512/2111/2111463.png"
            alt="Instagram"
            contato="renan.rov"
          />
          <Icone
            link="https://www.linkedin.com/in/renan-mochizuki-55314a259/"
            img="https://cdn-icons-png.flaticon.com/512/3536/3536505.png"
            alt="Linkedin"
            contato="Renan Mochizuki"
          />
          <Icone
            link="https://mail.google.com/mail/u/?authuser=user@gmail.com"
            img="https://cdn-icons-png.flaticon.com/512/5968/5968534.png"
            alt="Gmail"
            contato="renanmochizuki@gmail.com"
          />
        </div>
      </div>
    </>
  )
}

export default Contato