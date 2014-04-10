<?php 
    include 'header.php';
    $q = 'SELECT * FROM books LEFT JOIN books_authors ON books.book_id=books_authors.book_id LEFT JOIN authors ON books_authors.author_id=authors.author_id';
    $query = mysqli_query($connection, $q);
    if(!$query)
    {
                echo '<div class="error">DB Error! Please, try again later</div>';
                echo mysqli_error($connection);
                exit;
    }
    $last_id = 0;
?>
<table class="books">
    <tr>
       <th>Book</th>
       <th>Authors</th>
    </tr>
    <?php
         while ($row = $query->fetch_assoc()) 
    {
        if($row['book_id'] == $last_id)
        {
             echo ',<a href="booksFromAuthor.php?name='.$row['author_name'].'">'.$row['author_name'].'</a>';    
        }
        else 
        {
            echo '</td>';
            echo '</tr>';
            echo '<tr>';
            echo '<td><a href="book.php?name='.$row['book_title'].'">'.$row['book_title'].'</td>';
            echo '<td><a href="booksFromAuthor.php?name='.$row['author_name'].'">'.$row['author_name'].'</a>';
        }
        
        $last_id = $row['book_id'];
    }
    ?>
</table>