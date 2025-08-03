import React from 'react';

function OddPlayers([first, , third, , , fifth]) {
  return (
    <div>
      <li>First : {first}</li>
      <li>Third : {third}</li>
      <li>Fifth : {fifth}</li>
    </div>
  );
}

export default OddPlayers;
