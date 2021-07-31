import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import GlobalStyles from './styles/GlobalStyles';

// Create browser history to use in the Redux store

// Get the application-wide store instance, prepopulating with state from the server where available.
// const store = configureStore(history);

ReactDOM.render( 
  <React.StrictMode>
    <GlobalStyles/>
    <App />
  </React.StrictMode>,
  document.getElementById('root')
);

