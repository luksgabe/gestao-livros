import React, { Component } from 'react';
import Routes from './routes';
import { BrowserRouter } from "react-router-dom";
import Layout from './components/Shared/Layout';


class App extends Component {
  render() {
    return(
        <BrowserRouter>
          <Layout>
            <Routes/>
          </Layout>
        </BrowserRouter>
    )
  }
}

export default App;