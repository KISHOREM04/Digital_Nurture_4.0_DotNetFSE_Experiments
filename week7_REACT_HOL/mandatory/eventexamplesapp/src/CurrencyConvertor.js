import React, { Component } from 'react';

class CurrencyConvertor extends Component {
  constructor(props) {
    super(props);
    this.state = {
      amount: '',
      currency: '',
    };
  }

  handleAmountChange = (e) => {
    this.setState({ amount: e.target.value });
  };

  handleCurrencyChange = (e) => {
    this.setState({ currency: e.target.value });
  };

  handleSubmit = (e) => {
    e.preventDefault();
    const { amount, currency } = this.state;

    if (currency.toLowerCase() === 'euro') {
      const converted = amount * 0.012; // Example rate
      alert(`Converting to Euro: Amount is €${converted}`);
    } else if (currency.toLowerCase() === 'rupees') {
      const converted = amount * 84; // Example rate
      alert(`Converting to Rupees: Amount is ₹${converted}`);
    } else {
      alert('Please enter a valid currency: Euro or Rupees');
    }
  };

  render() {
    return (
      <div>
        <h2 style={{ color: 'green' }}>Currency Convertor!!!</h2>
        <form onSubmit={this.handleSubmit}>
          <label>
            Amount: <input type="text" onChange={this.handleAmountChange} />
          </label>
          <br />
          <label>
            Currency:
            <input type="text" onChange={this.handleCurrencyChange} />
          </label>
          <br />
          <button type="submit">Submit</button>
        </form>
      </div>
    );
  }
}

export default CurrencyConvertor;
