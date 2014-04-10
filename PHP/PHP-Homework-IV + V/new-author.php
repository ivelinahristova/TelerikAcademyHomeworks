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
        while($row = $q -> fetch_assoc())
            {
               if($row['author_name'] == $name)
               {
                   echo 'Author already exists!';
                   exit;
               }
            }
        $query = 'INSERT INTO authors (author_name)VALUES("'.$name.'")';
        $q = mysqli_query($connection, $query);
        if(!$q)
        {
            echo 'DB error.Sorry';
        }
        echo '<div class="">Author was created successfully</div>';
    }
    
?>
    <form method="POST">
        <input type="text" name="name">
        <input type="submit" value="Create">
    </form>
    <table class="books">
        <tr>
            <th>Authors</th>
        </tr>
        <?php
            while($row = $q -> fetch_assoc())
            {
                echo '<tr><td><a href="booksFromAuthor.php?name='.$row['author_name'].'">'.$row['author_name'].'</a></td></tr>';
            }
        ?>
    </table>
    <?php
    include 'footer.php';
    ?>