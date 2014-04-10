<?php
    $connection = mysqli_connect('localhost', 'administrator', 'pass', 'books');
    if(!$connection)
    {
        echo '<div class="error">DB Error! Please, try again later</div>';
        exit;
    }
    mysqli_set_charset($connection, 'utf8');
?>