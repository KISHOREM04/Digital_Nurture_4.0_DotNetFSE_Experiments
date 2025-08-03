import React from 'react';

function BlogDetails({ blogs }) {
  if (blogs.length === 0) {
    return <p>No blog posts found</p>;
  }

  return (
    <div>
      <h2>Blog Details</h2>
      {blogs.map((blog) => (
        <div key={blog.id}>
          <h3>{blog.title}</h3>
          <strong>{blog.author}</strong>
          <p>{blog.description}</p>
        </div>
      ))}
    </div>
  );
}

export default BlogDetails;
