<?php 
    include 'header.php';
    $authorName = trim($_GET['name']);
    $query = 'SELECT * FROM authors LEFT JOIN books_authors ON books_authors.author_id = authors.author_id LEFT JOIN books ON books_authors.book_id = books.book_id WHERE authors.author_name = "'.$authorName.'"';
    $q = mysqli_query($connection, $query);
    if(!$q)
    {
        echo 'DB went wrong. Sorry';
        echo mysqli_error($connection);
        exit;
    }
    $books = array();
    while($row = $q -> fetch_assoc())
    {
        $bookId = $row['book_id'];
        $book = array();
        array_push($book, $row['book_title']);
        $queryAuthors = 'SELECT * FROM books_authors LEFT JOIN authors ON books_authors.author_id = authors.author_id WHERE books_authors.book_id = "'.$bookId.'"';
        $qAuthors = mysqli_query($connection, $queryAuthors);
        while($rowAuthors = $qAuthors -> fetch_assoc())
        {
            array_push($book, $rowAuthors['author_name']);
        }
         array_push($books, $book);
    }
?>
<table class="books">
    <tr>
        <th>Book Title</th>
        <th>Book Authors</th>
    </tr>
    <?php
        foreach($books as $book)
        {
            echo '<tr><td>'.$book[0].'</td><td>';
            for($i=1;$i<count($book)-1; $i++)
            {
                echo '<a href="booksFromAuthor.php?name='.$book[$i].'">'.$book[$i].'</a>, ';
            }
            echo '<a href="booksFromAuthor.php?name='.$book[count($book)-1].'">'.$book[count($book)-1].'</a></td></tr>';
        }
    ?>
</table>
<?php
include 'footer.php';
?>