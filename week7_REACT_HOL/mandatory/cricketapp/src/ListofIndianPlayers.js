import React from 'react';

function ListofIndianPlayers({ players }) {
  return (
    <div>
      {players.map((item, index) => (
        <li key={index}>Mr. {item}</li>
      ))}
    </div>
  );
}

export default ListofIndianPlayers;
