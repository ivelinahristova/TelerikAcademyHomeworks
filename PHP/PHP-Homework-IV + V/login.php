<?php 
    include 'header.php';
    if($_POST)
    {
        $error = false;
        $name = trim($_POST['name']);
        $pass = trim($_POST['password']);
        $query = 'SELECT * FROM users WHERE user_name = "'.$name.'"';
        $q = mysqli_query($connection, $query);
        if(!$q)
        {
            echo 'DB error!';
            exit;
        }
        $row = $q -> fetch_assoc();
        if(!$row || $pass != $row['user_password'])
        {
            echo 'wrong username or password!.<br>';
        }
        else
        {
            if(!$error)
            {
                $_SESSION['isLogged'] = true;
                $_SESSION['user'] = $name;
                header("Location: index.php");
            }
        }
    }
?>
    <form method="POST">
        <input type="text" name="name">
        <input type="password" name="password">
        <input type="submit" name="register" value="Login">
    </form>
<?php
    include 'footer.php';
?>