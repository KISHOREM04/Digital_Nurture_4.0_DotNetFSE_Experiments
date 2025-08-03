import React from 'react';

function CourseDetails({ courses }) {
  return (
    <div>
      <h2>Course Details</h2>
      {courses.length ? (
        courses.map((course) => (
          <div key={course.id}>
            <h3>{course.name}</h3>
            <p>{course.date}</p>
          </div>
        ))
      ) : (
        <p>No courses available</p>
      )}
    </div>
  );
}

export default CourseDetails;
