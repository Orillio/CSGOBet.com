import React from 'react';
import './App.css';
import Header from './components/Header/Header';
import MainContent from './components/MainContent/MainContent';

const App = (props) => {
  return (
    <div className="wrapper">
      <Header />
      <MainContent />
    </div>
  );
}

export default App;
