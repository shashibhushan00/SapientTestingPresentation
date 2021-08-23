import { CardSelection } from './CardSelection';
import '../css/App.css';

function App() {

  const cards: any = {
    CC: "Credit Cards",
    DC: "Debit Cards"
  };

  return (
    <div className="App">
      <CardSelection card="CC" cards={cards} onCardSelected={() => { }} />
    </div>
  );
}

export default App;
