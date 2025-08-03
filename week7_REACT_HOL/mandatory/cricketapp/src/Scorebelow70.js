import React from 'react';

function Scorebelow70({ players }) {
  const playersBelow70 = players.filter((item) => item.score <= 70);
  return (
    <div>
      {playersBelow70.map((item, index) => (
        <div key={index}>
          <li>Mr. {item.name} {item.score}</li>
        </div>
      ))}
    </div>
  );
}

export default Scorebelow70;
