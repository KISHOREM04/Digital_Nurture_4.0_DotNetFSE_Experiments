// src/TrainerDetails.js
import { useParams } from 'react-router-dom';
import trainers from './TrainersMock';

function TrainerDetail() {
    const { id } = useParams();
    const trainer = trainers.find(t => t.TrainerId.toString() === id);

    if (!trainer) return <div>Trainer not found</div>;

    return (
        <div>
            <h2>Trainer Detail</h2>
            <p><strong>Name:</strong> {trainer.Name}</p>
            <p><strong>Email:</strong> {trainer.Email}</p>
            <p><strong>Phone:</strong> {trainer.Phone}</p>
            <p><strong>Technology:</strong> {trainer.Technology}</p>
            <p><strong>Skills:</strong> {trainer.Skills.join(', ')}</p>
        </div>
    );
}

export default TrainerDetail;
