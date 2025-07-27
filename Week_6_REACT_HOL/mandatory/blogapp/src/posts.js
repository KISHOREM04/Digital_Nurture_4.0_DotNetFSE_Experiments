import React from 'react';
import Post from './post';

class Posts extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => response.json())
      .then(data => {
        const posts = data.map(p => new Post(p.id, p.title, p.body));
        this.setState({ posts });
      });
  }

  componentDidMount() {
    this.loadPosts();
  }

  componentDidCatch(error, info) {
    this.setState({ hasError: true });
    alert("An error occurred while rendering posts.");
    console.error(error, info);
  }

  render() {
    return (
      <div>
        <h2>Blog Posts</h2>
        {this.state.hasError ? (
          <p>Error loading posts</p>
        ) : (
          this.state.posts.map(post => (
            <div key={post.id}>
              <h3>{post.title}</h3>
              <p>{post.body}</p>
            </div>
          ))
        )}
      </div>
    );
  }
}

export default Posts;
