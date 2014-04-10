<?php
    include 'header.php';
   
    if(isset($_SESSION['isLogged']))
    {
        if($_SESSION['isLogged']==true)
        {
            include 'menu.php';
            include 'user.php';
            if($admin==0)
            {
                header('Location: index.php');
            }
            $connection = mysqli_connect('localhost', 'administrator', 'pass', 'messages');
            if(!$connection)
            {
                echo '<div class="error">A problem occured. Please try again later.</div>';
                exit;
            }
        }    
    }
    else
    {
        header('Location: index.php');
    }
    if($_POST)
    {
        $name = trim($_POST['name']);
        $name = mysqli_real_escape_string($connection, $name);
        $query = 'INSERT INTO groups (name)VALUES("'.$name.'")';
        mysqli_query($connection, $query);
        echo '<div class="">Group was made successfully</div>';
    }
     
?>
<form method="POST">
    <label>Group name</label>
    <input type="text" name="name">
    <input type="submit" value="Make group">
</form>
