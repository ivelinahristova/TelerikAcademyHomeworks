<?php 
    include 'header.php';
    $bookName = trim($_GET['name']);
        $authors = array();
        $queryAuthors = 'SELECT * FROM books_authors LEFT JOIN authors ON books_authors.author_id = authors.author_id LEFT JOIN books ON books_authors.book_id = books.book_id WHERE books.book_title = "'.$bookName.'"';
        $qAuthors = mysqli_query($connection, $queryAuthors);
        
        while($rowAuthors = $qAuthors -> fetch_assoc())
        {
            $bookId = $rowAuthors['book_id'];
            array_push($authors, $rowAuthors['author_name']);
        }
?>
<h1>
    <?php
        echo $bookName;
    ?>
</h1>
<h3>Authors:<br>
    <?php
        foreach ($authors as $auth)
        {
            echo $auth.' ';
        }
    ?>
</h3>
<h1> Comments: </h1>
<table class="books">
    <tr>
        <th>Date</th>
        <th>User</th>
        <th>Comment</th>
    </tr>
    <?php
        $query = 'SELECT * FROM users_comments LEFT JOIN comments ON users_comments.comment_id = comments.comment_id LEFT JOIN users ON users_comments.user_id = users.user_id WHERE comments.book_id = "'.$bookId.'"';
        $q = mysqli_query($connection, $query);
        if(!$q)
        {
            echo 'DB error!';
            exit;
        }
        while($row = $q -> fetch_assoc())
        {
            echo '<tr><td>'.$row['comment_date'].'</td>';
            echo '<td>'.$row['user_name'].'</td>';
            echo '<td>'.$row['comment_text'].'</td>';
        }
        
    ?>
</table>
<?php
include 'new-comment.php';
include 'footer.php';
?>