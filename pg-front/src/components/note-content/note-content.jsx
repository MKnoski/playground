import React, { PureComponent } from 'react'
import PropTypes from 'prop-types'
import './note-content.css';

class NoteContent extends PureComponent {
  render() {
    return (
      <div className="content">{this.props.content}</div>
    )
  }
}

NoteContent.propTypes = {
  content: PropTypes.string
};

NoteContent.defaultProps = {
  content: ''
};

export default NoteContent;
