import React from 'react';
import './App.css';
import office1 from './assets/office1.png';
import office2 from './assets/office2.png';
import office3 from './assets/office3.png';


function App() {
  const officeSpaces = [
    { Name: "DBS", Rent: 50000, Address: "Chennai", Image: office1 },
    { Name: "WeWork", Rent: 70000, Address: "Mumbai", Image: office2 },
    { Name: "Regus", Rent: 45000, Address: "Bangalore", Image: office3 },
  ];

  return (
    <div className="App">
      <h1>Office Space , at Affordable Range</h1>
      {officeSpaces.map((item, index) => {
        const colorClass = item.Rent <= 60000 ? 'textRed' : 'textGreen';

        return (
          <div key={index} style={{ marginBottom: '20px' }}>
            <img src={item.Image} width="25%" height="25%" alt="Office Space" />
            <h2>Name: <b>{item.Name}</b></h2>
            <h3 className={colorClass}>Rent: Rs. {item.Rent}</h3>
            <h3>Address: {item.Address}</h3>
          </div>
        );
      })}
    </div>
  );
}

export default App;
