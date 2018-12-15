import React, { Component } from 'react';
import Note from './../note/note'
import './notes-container.css';

const API ='https://demo9626765.mockable.io/notes'

class NotesContainer extends Component {

  constructor(props) {
    super(props);
    this.state = { notes: [] };
  }

  componentDidMount() {
    fetch(API)
      .then(response => response.json())
      .then(data => this.setState({ notes: data }));
  }

  render() {
    const { notes } = this.state;
    return (
      <div className="notes-container">
        <h1>Notes:</h1>
        {notes.map((note, i) => {
          return (
            <Note key={i} title={note.title} content={note.content} />)
        })}
      </div>
    );
  }
}

export default NotesContainer;