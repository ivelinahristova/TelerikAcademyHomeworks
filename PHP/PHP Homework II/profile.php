<?php
include 'header.php';
if(isset($_SESSION['isLogged']))
{
        
    if($_SESSION['isLogged']==true)
    {   
        include 'main.php';
        $username = $_SESSION['username'];
        $FileArray = scandir($username);
        $name = '';
        $lastname = '';
        if(file_exists('data.txt'))
                {
                    $result = file('data.txt');
                    foreach ($result as $value) 
                    {
                        $columns= explode(',', $value); 
                        if($columns[0] == $username)
                        {
                            $name = trim($columns[2]);
                            $lastname = trim($columns[3]);
                            $today = trim($columns[4]);
                        }
                    }
                }
             echo '<div id="centerDiv"><h1>'.$username.' ('.$name.' '.$lastname.')';
             echo '</h1>';
             echo '<p>Registered on '.$today.'</p>';
             echo '<table id="dirContent"><tr><th>File name</th><th>Download file</th><th>Size</th></tr>';
             for($i=2; $i<count($FileArray); $i++)
             {
                 echo '<tr><td>'.$FileArray[$i].'</td><td><a href="download.php/?id='.$FileArray[$i].'">download</a></td><td>'.filesize($username.DIRECTORY_SEPARATOR.$FileArray[$i]).' Bytes</tr>';
             }
             echo '</table><br><br>';
             echo '<div class="button">'.
                  '<a href="upload.php">Upload another file...</a>'.
                  '</div>';
             echo '</div>';
    }
}
else
{
    header('Location: index.php');
}
?>


