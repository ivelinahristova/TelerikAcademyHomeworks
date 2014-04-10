<?php
    if(isset($_SESSION['isLogged']))
    {
        if($_SESSION['isLogged']==true)
        {
            $username = $_SESSION['username'];
            $connection = mysqli_connect('localhost', 'administrator', 'pass', 'messages');
            if(!$connection)
            {
                echo '<div class="error">Error occured. Please try later.</div>';
                exit;
            }
            mysqli_set_charset($connection, 'utf8');
            $q = 'SELECT * FROM users WHERE user_name = "'.$username.'"';
            $query = mysqli_query($connection, $q);
            if($query)
            {
                $row = $query->fetch_assoc();
                $password = $row['user_pass'];
                $admin = $row['isAdmin'];
            }  
        }
    }
?>