<?php
    include 'header.php';
    if(isset($_SESSION['isLogged']))
    {
        header('Location: index.php');    
    }
    if($_POST)
            {
                $error = false;
                $username = trim($_POST['username']);
                $password = trim($_POST['password']);
                $isAdmin = isset($_POST['Active']) && $_POST['Active']  ? "1" : "0";
                if(mb_strlen($username) < 5)
                {
                    echo '<div class="error">Username is too short!</div>';
                    $error = true;
                }
                if(mb_strlen($username) > 40)
                {
                    echo '<div class="error">Username is too long!</div>';
                    $error = true;
                }
                if(mb_strlen($password) < 5)
                {
                    echo '<div class="error">Password is too short!</div>';
                    $error = true;
                }
                if(mb_strlen($password) > 40)
                {
                    echo '<div class="error">Password is too long!</div>';
                    $error = true;
                }
                $connection = mysqli_connect('localhost', 'administrator', 'pass', 'messages');
                if(!$connection)
                {
                    echo '<div class="error">We have a problem. Please try again later.</div>';
                    exit;
                }
                if(!$error)
                {
                    $query = 'SELECT * FROM users WHERE user_name="'.$username.'"';
                    $q = mysqli_query($connection, $query);
                    echo mysqli_error($connection);
                    if($q)
                    {
                        $error = true;
                        echo '<div class="error">Username already exists.</div>';
                    }
                }
                if(!$error)
                {
                    $username = mysqli_real_escape_string($connection, $username);
                    $password = mysqli_real_escape_string($connection, $password);
                    $query = 'INSERT INTO users (user_name, user_pass, isAdmin)VALUES("'.$username.'", "'.$password.'", "'.$isAdmin.'")';
                    mysqli_query($connection, $query);
                    echo '<script>alert("Account was made successfuly! You can now login!");</script>';
                    header('Location: index.php');
                }     
            }
?>
<form method="POST" id="register">
    <label>Username</label><input type="text" name="username"><br>
    <label>Password</label><input type="password" name="password"><br>
    <input type="checkbox" name="Active">I want to be administrator!<br>
    <input type="submit" value="Register">
    or <a href="index.php">Login</a>
</form>