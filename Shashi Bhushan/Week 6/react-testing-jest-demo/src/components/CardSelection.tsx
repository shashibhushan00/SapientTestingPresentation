type CardSelectionProps = {
    card: string;
    cards: any;
    onCardSelected: any;
}


export const CardSelection = ({ card, cards, onCardSelected }: CardSelectionProps): JSX.Element => {

    return (
        <select id="creditCardSelector" defaultValue={card} onChange={onCardSelected}>
            {
                Object.keys(cards).map(key => {
                    return <option key={key} value={key} >{cards[key]}</option>
                })
            }
        </select>
    )
}