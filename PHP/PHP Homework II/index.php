<?php
    
    include 'header.php';
    if($_POST)
    {
            $username = trim($_POST['username']);
            $password = trim($_POST['password']);
            $logged = false;
            if(file_exists('data.txt'))
            {
                $result = file('data.txt');
                foreach ($result as $value) 
                {
                    $columns= explode(',', $value); 
                    if(trim($columns[0]) == $username && trim($columns[1])==$password)
                    {
                        if(trim($username)=='')
                        {
                            
                        }
                        else
                        {
                        $logged = true;
                        $_SESSION['isLogged'] = true;
                        $_SESSION['username'] = $username;
                        header('Location: index.php');
                        exit;
                        }
                    }
                    
                }
                if($logged == false)
                    {
                        echo '<p class="error">Incorrect username or password!</p>';
                    }
            }
    } 
    if(isset($_SESSION['isLogged']))
    {
        if($_SESSION['isLogged']==true)
        {
            header("Location: profile.php");
        }
    }
    else
    {
        echo '<div id="centerDiv">';
          include 'Login.php';
          echo '</div>';
    }
    
    
?>
       
<?php
    include 'footer.php';
?>
