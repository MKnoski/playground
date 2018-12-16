import React, { PureComponent } from "react";
import PropTypes from "prop-types";
import Typography from "@material-ui/core/Typography";
import "./note-title.css";

class NoteTitle extends PureComponent {
  render() {
    return (
      <div className="note-title">
        <Typography variant="title">{this.props.title}</Typography>
      </div>
    );
  }
}

NoteTitle.propTypes = {
  title: PropTypes.string.isRequired
};

NoteTitle.defaultProps = {
  title: ""
};

export default NoteTitle;
