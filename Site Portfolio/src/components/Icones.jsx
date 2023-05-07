function Icone(props) {
    return (
        /* eslint-disable */
        <div className="flex-row">
            <a href={props.link} target='_blank' rel="noreferrer">
                <img src={props.img} alt={props.alt} className='icone' />
            </a>
            <div className="flex-row">
                <a href={props.link} target='_blank' rel="noreferrer" className="link">
                    {props.contato}
                </a>
            </div>
        </div>
    )
}

export default Icone