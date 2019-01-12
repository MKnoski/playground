import React, { Component } from "react";
import Note from "./../note/note";
import AddNoteModal from "./../add-note-modal/add-note-modal";
import Button from "@material-ui/core/Button";
import Typography from "@material-ui/core/Typography";
import "./notes-container.css";

const API = "http://localhost:53108/api/notes";

class NotesContainer extends Component {
  constructor(props) {
    super(props);

    this.state = {
      notes: [],
      isModalOpen: false
    };
  }

  componentDidMount() {
    fetch(API)
      .then(response => response.json())
      .then(data => this.setState({ notes: data }));
  }

  handleOpen = () => {
    this.setState({ isModalOpen: true });
  };

  handleClose = () => {
    this.setState({ isModalOpen: false });
  };

  handleDelete = id => {
    this.setState(prevState => ({
      notes: prevState.notes.filter(note => note.id !== id)
    }));
  };

  render() {
    const { notes } = this.state;

    return (
      <div className="notes-container">
        <div>
          <Typography component="h2" variant="h1" gutterBottom>
            Notes
          </Typography>
          <Button
            onClick={this.handleOpen}
            variant="contained"
            color="primary"
            size="large"
          >
            <Typography variant="button" color="inherit">
              ADD NEW NOTE
            </Typography>
          </Button>
          <AddNoteModal
            isModalOpen={this.state.isModalOpen}
            handleClose={this.handleClose}
          />
        </div>
        {notes.map((note, i) => {
          return (
            <Note
              key={i}
              id={note.id}
              title={note.title}
              content={note.content}
              handleDelete={this.handleDelete}
            />
          );
        })}
      </div>
    );
  }
}

export default NotesContainer;
