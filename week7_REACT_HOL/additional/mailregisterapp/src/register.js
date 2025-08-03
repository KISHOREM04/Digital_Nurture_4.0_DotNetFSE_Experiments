import React, { useState } from 'react';

function Register() {
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();

    if (name.length < 5) {
      alert("Full Name must be 5 characters long!");
      return;
    }

    if (!email.includes('@') || !email.includes('.')) {
      alert("Email is not valid!");
      return;
    }

    if (password.length < 8) {
      alert("Password must be at least 8 characters!");
      return;
    }

    alert("Registration Successful!");
  };

  return (
    <div style={{ textAlign: 'center' }}>
      <h1 style={{ color: 'red' }}>Register Here!!!</h1>
      <form onSubmit={handleSubmit}>
        <div>
          Name: <input type="text" value={name} onChange={(e) => setName(e.target.value)} />
        </div>
        <div>
          Email: <input type="text" value={email} onChange={(e) => setEmail(e.target.value)} />
        </div>
        <div>
          Password: <input type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
        </div>
        <div>
          <button type="submit">Submit</button>
        </div>
      </form>
    </div>
  );
}

export default Register;
