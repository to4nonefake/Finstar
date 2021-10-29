import React from 'react';
import './App.css';
import {Header} from './components/Header';
import { RecordsTable } from './components/RecordsTable';

const App = () => {
  return (
    <div className="App">
      <h3>Some text</h3>
      <div style={{maxWidth: '70%', margin: 'auto'}}>
        <Header />
        <RecordsTable />
      </div>
    </div>
  );
}

export default App;
