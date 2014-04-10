<?php
    include 'header.php';
    if(isset($_SESSION['isLogged']))
    {
        if($_SESSION['isLogged'] == true)
        {
            include 'main.php';
            $username = $_SESSION['username'];
            if($_POST)
            {
                if(count($_FILES)>0)
                {
                    if(move_uploaded_file($_FILES['file']['tmp_name'], $username.DIRECTORY_SEPARATOR.$_FILES['file']['name']))
                    {
                        echo '<p class="important-message">File uploaded successfuly!</p>';
                    }
                }
            }
        }
    }
    else
    {
        header('Location: index.php');
    }
?>
<div id="centerDiv">
    <form method = "POST" enctype="multipart/form-data">
        <input type="file" name="file">
        <input type="submit" name="upload" value="Upload file">
    </form>
</div>
