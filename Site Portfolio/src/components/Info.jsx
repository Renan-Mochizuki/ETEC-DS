function Info(props) {
    return (
        /* eslint-disable */
        <div className="info-texto">    
            <img src={props.img} alt={props.alt} className='icon' />
            <p>{props.texto}</p>
        </div>
    )
}

export default Info