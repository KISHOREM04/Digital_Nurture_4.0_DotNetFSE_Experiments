import './App.css';
import { CohortsData} from './Cohort'
import CohortDetails from './CohortDetails'; 

function App() {
 
  return (
  <div className='page'>
    <h1>Cohorts Details</h1>
    {CohortsData.map(cohort => <CohortDetails cohort={cohort}/>)}
  </div>
  );
}

export default App;
