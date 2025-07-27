// src/App.js
import { BrowserRouter, Routes, Route, Link } from 'react-router-dom';
import Home from './Home';
import TrainersList from './TrainerList';
import TrainerDetail from './TrainerDetails';
import trainers from './TrainersMock';

function App() {
    return (
        <BrowserRouter>
            <nav>
                <Link to="/">Home</Link> | 
                <Link to="/trainers">Trainers</Link>
            </nav>
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/trainers" element={<TrainersList trainers={trainers} />} />
                <Route path="/trainer/:id" element={<TrainerDetail />} />
            </Routes>
        </BrowserRouter>
    );
}

export default App;
