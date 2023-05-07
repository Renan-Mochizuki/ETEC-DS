function Projetos(props) {
    /* eslint-disable */
    let estiloFlexRow, sombraLado;
    if (props.lado == 'e') {
        estiloFlexRow = { flexDirection: "row-reverse", gap: "1rem" }
        sombraLado = { boxShadow: "1px 1px 3px whitesmoke " }
    } else {
        estiloFlexRow = { gap: "1rem" }
        sombraLado = {}
    }

    const linguagens = props.linguagens
    const img = props.img

    return (
        <div className="flex-row" style={estiloFlexRow}>
            {img.map((imagem, index1) => (
                <img src={"/img/prints/" + imagem.src + ".jpg"} alt={imagem.alt} key={index1} className='prints' style={sombraLado} />
            ))}
            <div className="texto-projeto">
                <h3>{props.titulo}</h3>
                <p>{props.texto}</p>
                <br />
                <h5>Linguagens:</h5>
                <div className="flex-row">
                    {linguagens.map((linguagem, index2) => (
                        <img src={linguagem.src} alt={linguagem.alt} key={index2} className="linguagens" />
                    ))}
                </div>
                {props.video && (
                    <a href={props.video} className="flex-row link" target='_blank' rel="noreferrer">
                        <img src="https://cdn-icons-png.flaticon.com/512/3670/3670147.png" className="icon" />
                        Vídeo do Projeto
                    </a>
                )}
                <a href={props.link} className="flex-row link" target='_blank' rel="noreferrer">
                    <img src="https://cdn-icons-png.flaticon.com/512/733/733609.png" className="icon" />
                    Github
                </a>
            </div>
        </div>
    )
}

export default Projetos