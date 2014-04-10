<?php 
    include 'header.php';
    if(isset($_SESSION['isLogged']))
    {
        if($_SESSION['isLogged'] == true)
        {
            include 'menu.php';
        }
    }
    else
    {
        header('Location: index.php');
    }
    $connection = mysqli_connect('localhost', 'administrator', 'pass', 'messages');
        if(!$connection)
        {
            echo '<div class="error">Грешка! Моля, опитайте по-късно.</div>';
            exit;
        }
        mysqli_set_charset($connection, 'utf8');
        include 'functions-consts.php';
?>
<form method="POST">
<select name="selectGroup">
    <?php
    foreach ($groups as $value)
    {
        echo '<option>'.$value.'</option>';
    }
    ?>
</select>
    <input type="submit" value="show">
</form>
<table id="msg">
    <tr>
        <th>User</th>
        <th>Message</th>
        <th>Group</th>
        <th>Date/Time</th>
    </tr>
    <?php
        $group = 'all';
        if($_POST)
        {
            $group = $_POST['selectGroup'];
        }
        if($group != 'all')
        {
            $q='SELECT * FROM messages WHERE groupMsg="'.$group.'" ORDER BY date DESC';
        }
        else
        {
            $q = 'SELECT * FROM messages ORDER BY date DESC';
        }
        $query = mysqli_query($connection, $q);
        echo mysqli_error($connection);
        if($query)
        {
            while($row = $query -> fetch_assoc())
            {
                echo '<tr>';
                echo '<td>'.$row['user_name'].'</td><td>'.$row['message'].'</td><td>'.$row['groupMsg'].'</td><td>'.$row['date'].'</td>';
                echo '</tr>';
            }
        }
    ?>
</table>