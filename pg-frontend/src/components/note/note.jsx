import React, { Component } from "react";
import PropTypes from "prop-types";
import NoteTitle from "./../note-title/note-title";
import NoteContent from "./../note-content/note-content";
import Button from "@material-ui/core/Button";
import DeleteIcon from "@material-ui/icons/Delete";
import "./note.css";

class Note extends Component {
  render() {
    return (
      <div className="note">
        <NoteTitle title={this.props.title} />
        <NoteContent content={this.props.content} />
        <div className="delete-button ">
          <Button
            onClick={() => this.props.handleDelete(this.props.id)}
            variant="contained"
            color="secondary"
          >
            Delete
            <DeleteIcon />
          </Button>
        </div>
      </div>
    );
  }
}

Note.propTypes = {
  id: PropTypes.number.isRequired,
  title: PropTypes.string.isRequired,
  content: PropTypes.string.isRequired,
  handleDelete: PropTypes.func.isRequired
};

Note.defaultProps = {
  title: "",
  content: ""
};

export default Note;
