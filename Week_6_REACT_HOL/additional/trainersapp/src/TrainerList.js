// src/TrainerList.js
import { Link } from 'react-router-dom';

function TrainersList({ trainers }) {
    return (
        <div>
            <h2>Trainer List</h2>
            <ul>
                {trainers.map((trainer) => (
                    <li key={trainer.TrainerId}>
                        <Link to={`/trainer/${trainer.TrainerId}`}>{trainer.Name}</Link>
                    </li>
                ))}
            </ul>
        </div>
    );
}

export default TrainersList;
