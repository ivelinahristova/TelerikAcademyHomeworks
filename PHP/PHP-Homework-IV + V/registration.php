<?php 
    include 'header.php';
    if($_POST)
    {
        $error = false;
        $name = trim($_POST['name']);
        $name = mysql_real_escape_string($name);
        if(strlen($name)<3)
        {
            echo '<p>Username must be at least 3 symbols!</p>';
            $error = true;
        }
        $pass = trim($_POST['password']);
        $pass = mysql_real_escape_string($pass);
        $query = 'SELECT user_name FROM users WHERE user_name = "'.$name.'"';
        $q = mysqli_query($connection, $query);
        if(!$q)
        {
            echo 'DB error!';
            exit;
        }
        $row = $q -> fetch_assoc();
        if($row)
        {
            echo 'username is alreay used! Please choose another.<br>';
        }
        else
        {
            if(!$error)
            {
            $query = 'INSERT INTO users (user_name, user_password)VALUES("'.$name.'", "'.$pass.'")';
            $q = mysqli_query($connection, $query);
            if(!$q)
            {
                echo 'DB error!';
                exit;
            }
            echo '<p>Registration is successful!</p>';
            }
        }
    }
?>
    <form method="POST">
        <input type="text" name="name">
        <input type="password" name="password">
        <input type="submit" name="register" value="Register">
    </form>
<?php
    include 'footer.php';
?>