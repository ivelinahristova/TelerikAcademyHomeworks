<?php 
    include 'header.php';
    if(isset($_SESSION['isLogged']))
    {
        if($_SESSION['isLogged'] == true)
        {
            header('Location: messages.php');
        }
    }
    else
    {
        include 'login.php';
    }
?>

<?php
    include 'footer.php';
?>