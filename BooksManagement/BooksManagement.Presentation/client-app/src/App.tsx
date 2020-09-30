import React, { Component } from 'react';
import { Provider } from "react-redux";
import Routes from './routes';
import store from "./store";
import { BrowserRouter } from "react-router-dom";
import Layout from './components/Shared/Layout';


const App = () => (
  <Provider store = {store}>
    <BrowserRouter>
      <Layout>
        <Routes/>
      </Layout>
    </BrowserRouter>
  </Provider>
)

export default App;

