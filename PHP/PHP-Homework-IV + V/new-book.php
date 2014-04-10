<?php
    include 'header.php';
    $showQuery = 'SELECT author_name FROM authors';
    $q = mysqli_query($connection, $showQuery);
        if(!$q)
        {
            echo 'DB error.Sorry';
            exit;
        }
    if($_POST)
    {
        $name = trim($_POST['name']);
        $name = mysqli_real_escape_string($connection, $name);
        $author_id = 0;
        $book_id = 0;
        $queryBooks = 'SELECT * FROM books';
        $qBooks =  mysqli_query($connection, $queryBooks);
        if(!$qBooks)
        {
            echo 'DB error.Sorry';
            exit;
        }
        else
        {
            while($rowBooks = $qBooks -> fetch_assoc())
            {
                if($name == $rowBooks['book_title'])
                {
                    echo 'Book already exists!';
                    exit;
                }
            }
            $queryCreateBook = 'INSERT INTO books (book_title)VALUES("'.$name.'")';
            mysqli_query($connection, $queryCreateBook);
        }
        $queryFindIdBook = 'SELECT book_id FROM books WHERE book_title = "'.$name.'"';
        $qFindIdBook = mysqli_query($connection, $queryFindIdBook);
        $rowFindIdBook = $qFindIdBook -> fetch_assoc();
        $book_id = $rowFindIdBook['book_id'];
        $chosenAuthors = $_POST['authors'];
        foreach($chosenAuthors as $auth)
        {
            $queryFindIdAuthor = 'SELECT author_id FROM authors WHERE author_name = "'.$auth.'"';
            $qFindIdAuthor = mysqli_query($connection, $queryFindIdAuthor);
            $rowFindIdAuthor = $qFindIdAuthor -> fetch_assoc();
            $author_id = $rowFindIdAuthor['author_id'];
            $query = 'INSERT INTO books_authors (author_id, book_id)VALUES("'.$author_id.'", "'.$book_id.'")';
            $q = mysqli_query($connection, $query);
            if(!$q)
            {
                echo 'DB error.Sorry';
            }
        }
        
        echo '<div class="">Book was created successfully</div>';
    }
?>
    <form method="POST">
        <input type="text" name="name">
        <select multiple="multiple" name="authors[]">
            <?php
                while($row=$q->fetch_assoc())
                {
                    echo '<option>'.$row['author_name'].'</option>';
                }
            ?>
        </select>
        <input type="submit" value="Create">
    </form>
   
    <?php
    include 'footer.php';
    ?>