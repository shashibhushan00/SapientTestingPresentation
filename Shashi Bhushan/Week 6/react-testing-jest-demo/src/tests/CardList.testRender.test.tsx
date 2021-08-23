import TestRenderer from 'react-test-renderer';
import { CardList } from '../components/CardList'
import { Cards } from '../components/Cards'
import { CardProvider } from '../types/ CardProvider';

describe('CardList', () => {

    describe('rendering', () => {

        describe('selection', () => {

            describe('all selected', () => {
                it('should select all the Cards', () => {
                    const all = { [CardProvider.ICICI]: true, [CardProvider.HDFC]: true, [CardProvider.SBI]: true };
                    const tr = TestRenderer.create(<CardList cardsActive={all} cards={Cards} onCardSelection={() => { }} />);
                    const inputs = tr.root.findAllByProps({ "data-testid": 'card-selected' });
                    inputs.forEach((input) => {
                        expect(input.props.checked).toBe(true);
                    });
                });
            });

            describe('None selected', () => {
                it('should select no Cards', () => {
                    const all = { [CardProvider.ICICI]: false, [CardProvider.HDFC]: false, [CardProvider.SBI]: false };
                    const tr = TestRenderer.create(<CardList cardsActive={all} cards={Cards} onCardSelection={() => { }} />);
                    const inputs = tr.root.findAllByProps({ "data-testid": 'card-selected' });
                    inputs.forEach((input) => {
                        expect(input.props.checked).toBe(false);
                    });
                });
            });
        });

        describe('activation', () => {
            const inactiveCssClassExpression = /.*CardSelector-inactive/;
            const cardDivPrefix = 'card-div-';

            describe('all active', () => {
                it('should not have the inactive class', () => {
                    const all = { [CardProvider.ICICI]: true, [CardProvider.HDFC]: true, [CardProvider.SBI]: true };
                    const tr = TestRenderer.create(<CardList cardsActive={all} cards={Cards} onCardSelection={() => { }} />);
                    const divs = tr.root.findAll((instance) => (instance.props['data-testid'] || "").startsWith(cardDivPrefix));
                    divs.forEach((div) => {
                        expect(div.props.className).not.toMatch(inactiveCssClassExpression);
                    });
                });
            });

            describe('all inactive', () => {
                it('should have the inactive class', () => {
                    const all = { [CardProvider.ICICI]: false, [CardProvider.HDFC]: false, [CardProvider.SBI]: false };
                    const tr = TestRenderer.create(<CardList cardsActive={all} cards={Cards} onCardSelection={() => { }} />);
                    const divs = tr.root.findAll((instance) => (instance.props['data-testid'] || "").startsWith(cardDivPrefix));
                    divs.forEach((div) => {
                        expect(div.props.className).toMatch(inactiveCssClassExpression);
                    });
                });
            });

            describe('mixed', () => {
                it('should have the inactive class for inactive Cards', () => {
                    const activation: any = { [CardProvider.ICICI]: false, [CardProvider.HDFC]: true, [CardProvider.SBI]: true };
                    const tr = TestRenderer.create(<CardList cardsActive={activation} cards={Cards} onCardSelection={() => { }} />);


                    Object.keys(activation).forEach((cardName: any) => {
                        const div = tr.root.findAll((instance) => (instance.props['data-testid'] || "") === (cardDivPrefix + cardName))[0];
                        if (activation[cardName]) {
                            expect(div.props.className).not.toMatch(inactiveCssClassExpression);
                        } else {
                            expect(div.props.className).toMatch(inactiveCssClassExpression);
                        }
                    });
                });
            });
        });
    });
});