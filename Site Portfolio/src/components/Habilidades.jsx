function Habilidades(props) {
    return (
        /* eslint-disable */
        <div className="competencias">
            <img src={props.img} alt={props.alt} className='logos' />
            <p>{props.habilidade}</p>
            <progress value={props.valor} max="100" />
        </div>
    )
}

export default Habilidades