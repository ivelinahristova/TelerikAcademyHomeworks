<?php
    if($_POST)
    {
        $username = trim($_POST['username']);
        $password = trim($_POST['password']);
        if($username == "" || $password=="")
        {
            echo '<div class="error">Incorrect username or password!</div>';
        }
        else
        {
            $connection = mysqli_connect('localhost', 'administrator', 'pass', 'messages');
            if(!$connection)
            {
                echo '<div class="error">Грешка! Моля, опитайте по-късно.</div>';
                exit;
            }
            mysqli_set_charset($connection, 'utf8');
            $q = 'SELECT * FROM users WHERE user_name = "'.$username.'"';
            $query = mysqli_query($connection, $q);
            if(!$query)
            {
                echo '<div class="error">Incorrect username or password!</div>';
            }
            else
            {
                $row = $query->fetch_assoc();
                if($row['user_pass'] == $password)
                {
                    $_SESSION['isLogged'] = true;
                    $_SESSION['username'] = $username;
                    header('Location: messages.php');
                }
                else
                {
                    echo '<div class="error">Incorrect username or password!</div>';
                }
            }
        }
    }
?>
<form method="POST" id="login">
    <label>Username</label><input type="text" name="username"><br>
    <label>Password</label><input type="password" name="password"><br>
    <input type="submit" value="Login">
    or <a href="registration.php">Register</a>
</form>
