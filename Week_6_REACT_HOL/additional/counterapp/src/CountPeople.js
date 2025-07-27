import React, { Component } from 'react';

class CountPeople extends Component {
  constructor(props) {
    super(props);
    this.state = {
      entryCount: 0,
      exitCount: 0
    };

    // Bind methods to class
    this.UpdateEntry = this.UpdateEntry.bind(this);
    this.UpdateExit = this.UpdateExit.bind(this);
  }

  // Method to increase entry count
  UpdateEntry() {
    this.setState(prevState => ({
      entryCount: prevState.entryCount + 1
    }));
  }

  // Method to increase exit count
  UpdateExit() {
    this.setState(prevState => ({
      exitCount: prevState.exitCount + 1
    }));
  }

  render() {
    return (
      <div style={{
        display: 'flex',
        justifyContent: 'space-around',
        alignItems: 'center',
        marginTop: '100px',
        fontFamily: 'Arial'
      }}>
        <div>
          <button
            onClick={this.UpdateEntry}
            style={{
              backgroundColor: 'white',
              border: '1px solid green',
              color: 'green',
              fontWeight: 'bold',
              padding: '5px 10px',
              marginRight: '10px'
            }}
          >
            Login
          </button>
          <span style={{ color: 'green', fontSize: '18px' }}>
            {this.state.entryCount} People Entered!!!
          </span>
        </div>

        <div>
          <button
            onClick={this.UpdateExit}
            style={{
              backgroundColor: 'white',
              border: '1px solid green',
              color: 'green',
              fontWeight: 'bold',
              padding: '5px 10px',
              marginRight: '10px'
            }}
          >
            Exit
          </button>
          <span style={{ color: 'green', fontSize: '18px' }}>
            {this.state.exitCount} People Left!!!
          </span>
        </div>
      </div>
    );
  }
}

export default CountPeople;
