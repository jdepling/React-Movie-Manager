import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Movies } from './components/Movies';
import { AddMovie } from './components/AddMovie';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Movies} />
        <Route path='/add_movies' component={AddMovie} />
      </Layout>
    );
  }
}
