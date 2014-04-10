<?php
    include 'header.php';
   
    if(isset($_SESSION['isLogged']))
    {
        if($_SESSION['isLogged']==true)
        {
            include 'menu.php';
            $connection = mysqli_connect('localhost', 'administrator', 'pass', 'messages');
            if(!$connection)
            {
                echo '<div class="error">A problem occured. Please try again later.</div>';
                exit;
            }
            include 'functions-consts.php';
        }    
    }
    else
    {
        header('Location: index.php');
    }
    if($_POST)
    {
        $text = trim($_POST['text']);
        $msgGroup = trim($_POST['group']);
        $today = date("Y-m-d H:i:s");
        include 'user.php';
        $text = mysqli_real_escape_string($connection, $text);
        $query = 'INSERT INTO messages (user_name, message, groupMsg, date)VALUES("'.$username.'", "'.$text.'", "'.$msgGroup.'", "'.$today.'")';
        mysqli_query($connection, $query);
        header('Location: messages.php');
    }
     
?>
<form method="POST">
    <label>Message(250 symbols):</label><br><textarea name="text"></textarea>
    <br>
    <label>Message Group</label>
    <select name="group">
        <?php
        foreach ($groups as $value)
        {
            if($value != 'all')
            {
            echo '<option>'.$value.'</option>';
            }
        }
        ?>
    </select>
    <input type="submit" value="Send">
</form>
