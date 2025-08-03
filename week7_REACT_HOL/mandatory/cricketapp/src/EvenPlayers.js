import React from 'react';

function EvenPlayers([, second, , fourth, , sixth]) {
  return (
    <div>
      <li>Second : {second}</li>
      <li>Fourth : {fourth}</li>
      <li>Sixth : {sixth}</li>
    </div>
  );
}

export default EvenPlayers;
