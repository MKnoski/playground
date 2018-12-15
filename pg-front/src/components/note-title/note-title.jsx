import React, { PureComponent } from 'react'
import PropTypes from 'prop-types'
import './note-title.css';

class NoteTitle extends PureComponent {
  render() {
    return (
      <h2>{this.props.title}</h2>
    )
  }
}

NoteTitle.propTypes = {
  title: PropTypes.string
};

NoteTitle.defaultProps = {
  title: ''
};

export default NoteTitle;
