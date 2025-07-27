import styles from './CohortDetails.module.css';

function CohortDetails(props) {
  const { cohort } = props;

  // Set class conditionally based on cohort status
  const headingClass =
    cohort.currentStatus.toLowerCase() === 'ongoing'
      ? styles.greenText
      : styles.blueText;

  return (
    <div className={styles.box}>
      <h3 className={headingClass}>
        {cohort.cohortCode} - <span>{cohort.technology}</span>
      </h3>
      <dl>
        <dt>Started On</dt>
        <dd>{cohort.startDate}</dd>
        <dt>Current Status</dt>
        <dd>{cohort.currentStatus}</dd>
        <dt>Coach</dt>
        <dd>{cohort.coachName}</dd>
        <dt>Trainer</dt>
        <dd>{cohort.trainerName}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;
