<?php
    mb_internal_encoding('UTF-8');
    include 'header.php';
    if($_POST)
    {
        $error = false;
        $today = date("j.F.Y"); 
        $username = trim($_POST['username']);
        $username = str_replace(',', '', $username);
        $password = trim($_POST['password']);
        $password = str_replace(',', '', $password);
        $name = trim($_POST['name']);
        $name = str_replace(',', '', $name);
        $lastname = trim($_POST['last-name']);
        $lastname = str_replace(',', '', $lastname);
        if(mb_strlen($username) < 4)
        {
            echo '<p class="error">Username is too short!</p>';
            $error = true;
        }
        if(mb_strlen($username) > 15)
        {
            echo '<p class="error">Username is too long!</p>';
            $error = true;
        }
        if(mb_strlen($name) < 3)
        {
            echo '<p class="error">Name is too short!</p>';
            $error = true;
        }
        if(mb_strlen($name) > 15)
        {
            echo '<p class="error">Name is too long!</p>';
            $error = true;
        }
        if(mb_strlen($lastname) < 3)
        {
            echo '<p class="error">Lastname is too short!</p>';
            $error = true;
        }
        if(mb_strlen($lastname) > 15)
        {
            echo '<p class="error">Lastname is too long!</p>';
            $error = true;
        }
        if(mb_strlen($password) < 4)
        {
            echo '<p class="error">Password is too short!</p>';
            $error = true;
        }
        if(mb_strlen($password) > 15)
        {
            echo '<p class="error">Password is too long!</p>';
            $error = true;
        }
        if(file_exists('data.txt'))
            {
                $result = file('data.txt');
                foreach ($result as $value) 
                {
                    $columns= explode(',', $value); 
                    if(trim($columns[0]) == $username)
                    {
                        echo '<p class="error">Username is already used!</p>';
                        $error = true;
                    }
                }
            }
         if(!$error){
        $result=$username.','.$password.','.$name.','.$lastname.','.$today."\r\n";
        if(file_put_contents('data.txt', $result,FILE_APPEND))
        {
            echo '<p class="important-message">The account was created successfully!</p><a href="index.php">Login</a>';
            mkdir($username, 0777, true);
        }
    }
    }
?>
<div id="centerDiv">
    <h1>Registration form</h1>
<form method="POST" id="registration">
    <div class="left">
        <label>Username</label>
        <input type="text" name="username">
    </div>
    <div>
        <label>Password</label>
        <input type="password" name="password">
    </div>
    <div class="clear"></div>
    <div class="left">
        <label>Name</label>
        <input type="text" name="name">
    </div>
    <div>
        <label>Last Name</label>
        <input type="text" name="last-name">
    </div>
    <div class="clear"></div>
    <input type="submit" value="Register">
    <span>or</span>
    <a href="index.php" id="register-link">Login</a>
</form>
</div>
<?php include 'footer.php'?>
