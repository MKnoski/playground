import React, { PureComponent } from "react";
import PropTypes from "prop-types";
import Typography from "@material-ui/core/Typography";
import "./note-content.css";

class NoteContent extends PureComponent {
  render() {
    return (
      <div className="note-content">
        <Typography align="justify" gutterBottom>
          {this.props.content}
        </Typography>
      </div>
    );
  }
}

NoteContent.propTypes = {
  content: PropTypes.string.isRequired
};

NoteContent.defaultProps = {
  content: ""
};

export default NoteContent;
