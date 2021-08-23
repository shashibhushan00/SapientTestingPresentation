import ReactDOM from 'react-dom';
import { Provider } from 'react-redux';
import { createStore, Store } from 'redux';
import { App } from './App';
import { tasksReducer } from './features/tasks/reducers/tasksReducer';
import reportWebVitals from './reportWebVitals';
import './style/index.css';

const appStore: Store = createStore(tasksReducer);

ReactDOM.render(
    <Provider store={appStore}>
        <App />
    </Provider>,
    document.getElementById('root')
);

reportWebVitals();