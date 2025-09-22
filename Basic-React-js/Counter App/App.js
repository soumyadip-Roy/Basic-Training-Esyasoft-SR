import logo from './logo.svg';
import './App.css';
import Counter from './Counter'

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          <h1>FAS FAS FAS</h1>
        </a>
        <Counter/>
        <p>Enjoy the counter</p>
      </header>
    </div>
  );
}

export default App;
