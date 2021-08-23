type CardListProps = {
    cardsActive: any;
    cards: Card[];
    onCardSelection: any;
}

export const CardList = ({ cardsActive, cards, onCardSelection }: CardListProps): JSX.Element => {
    return (
        <div>
            {
                cards.map(card => {
                    return (
                        <div id={card.type}>
                            <div data-testid={`card-div-${card.type}`} className={cardsActive[card.type] ? "CardSelector-active" : "CardSelector-inactive"}>
                                <span>Name - {card.name}</span>
                                <span>Number - {card.number}</span>
                                <span>Type - {card.type}</span>
                            </div>
                            <div>
                                <input data-testid="card-selected" checked={cardsActive[card.type]}></input>
                            </div>
                        </div>
                    )
                })
            }
        </div>
    )
}