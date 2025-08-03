import React from 'react';

function BookDetails(props) {
  return (
    <div>
      <h2>Book Details</h2>
      <ul>
        {props.books.length > 0 ? (
          props.books.map((book) => (
            <div key={book.id}>
              <h3>{book.bname}</h3>
              <h4>{book.price}</h4>
            </div>
          ))
        ) : (
          <p>No books available</p>
        )}
      </ul>
    </div>
  );
}

export default BookDetails;
