import { CalculateScore } from './components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore
        Name="Dipanjan"
        School="DNV Public School"
        total={284}
        goal={3}
      />
    </div>
  );
}

export default App;
