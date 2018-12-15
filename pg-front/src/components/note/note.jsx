import React, { Component } from 'react'
import PropTypes from 'prop-types'
import NoteTitle from './../note-title/note-title'
import NoteContent from './../note-content/note-content'
import './note.css';

class Note extends Component {
    render() {
        return (
            <div className="note">
                <NoteTitle title={this.props.title} />
                <NoteContent content={this.props.content} />
            </div>
        )
    }
}

Note.propTypes = {
    title: PropTypes.string,
    content: PropTypes.string
};

Note.defaultProps = {
    title: '',
    content: ''
};

export default Note;
