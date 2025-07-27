import React, { Component } from 'react';

// Cart class
class Cart {
  constructor(itemname, price) {
    this.itemname = itemname;
    this.price = price;
  }
}

class OnlineShopping extends Component {
  constructor(props) {
    super(props);

    // Array of Cart objects
    this.state = {
      cartItems: [
        new Cart("Laptop", 80000),
        new Cart("TV", 120000),
        new Cart("Washing Machine", 50000),
        new Cart("Mobile", 30000),
        new Cart("Fridge", 70000)
      ]
    };
  }

  render() {
    return (
      <div style={{ textAlign: 'center', marginTop: '50px', fontFamily: 'Arial' }}>
        <h1 style={{ color: 'green' }}>Items Ordered :</h1>
        <table style={{
          margin: '20px auto',
          borderCollapse: 'collapse',
          width: '300px',
          textAlign: 'center',
          color: 'green',
          fontSize: '18px'
        }}>
          <thead>
            <tr>
              <th style={{ border: '1px solid green', padding: '10px' }}>Name</th>
              <th style={{ border: '1px solid green', padding: '10px' }}>Price</th>
            </tr>
          </thead>
          <tbody>
            {this.state.cartItems.map((item, index) => (
              <tr key={index}>
                <td style={{ border: '1px solid green', padding: '8px' }}>{item.itemname}</td>
                <td style={{ border: '1px solid green', padding: '8px' }}>{item.price}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    );
  }
}

export default OnlineShopping;
