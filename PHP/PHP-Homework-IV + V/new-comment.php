<?php
    if(!isset($_SESSION['isLogged']))
    {
        exit;
    }
    if($_POST)
    {
        
        $user_id = $row['user_id'];
        $book_id = $bookId;
        $text = trim($_POST['text']);
         $today = date("Y-m-d H:i:s");
        if(strlen($text)<10)
        {
            echo 'Comment must be at least 10 symbols!';
            exit;
        }

            $queryCreateComment = 'INSERT INTO comments (comment_text, book_id, comment_date)VALUES("'.$text.'","'.$book_id.'", "'.$today.'")';
            mysqli_query($connection, $queryCreateComment);
        $queryFindIdBook = 'SELECT comment_id FROM comments WHERE comment_text = "'.$text.'"';
        $qFindIdBook = mysqli_query($connection, $queryFindIdBook);
        $rowFindIdBook = $qFindIdBook -> fetch_assoc();
        $comment_id = $rowFindIdBook['comment_id'];
            $query = 'INSERT INTO users_comments (user_id, comment_id)VALUES("'.$user_id.'", "'.$comment_id.'")';
            $q = mysqli_query($connection, $query);
            if(!$q)
            {
                echo mysqli_error($connection);
                echo 'DB errorSorry';
            }
        echo '<div class="">Comment was created successfully</div>';
    }
?>
    <form method="POST">
        <textarea name="text"></textarea>
        <input type="submit" value="Add">
    </form>
