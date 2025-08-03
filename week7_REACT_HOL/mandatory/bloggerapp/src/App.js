import React from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';
import { books, blogs, courses } from './data';

function App() {
  return (
    <div style={{ display: 'flex', justifyContent: 'space-around', margin: '20px' }}>
      <div style={{ borderLeft: '3px solid green', paddingLeft: '10px' }}>
        <CourseDetails courses={courses} />
      </div>
      <div style={{ borderLeft: '3px solid green', paddingLeft: '10px' }}>
        <BookDetails books={books} />
      </div>
      <div style={{ borderLeft: '3px solid green', paddingLeft: '10px' }}>
        <BlogDetails blogs={blogs} />
      </div>
    </div>
  );
}

export default App;
