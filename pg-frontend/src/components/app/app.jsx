import React, { Component } from "react";
import NotesContainer from "./../notes-container/notes-container.jsx";
import "./app.css";

class App extends Component {
  render() {
    return (
      <div className="app">
        <NotesContainer />
      </div>
    );
  }
}

export default App;
