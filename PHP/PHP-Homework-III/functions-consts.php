<?php
    if(!$connection)
    {
        echo 'problem';
    }
    $msg = 'SELECT * FROM groups';
    $groups=array('all');
    $queryMsg = mysqli_query($connection, $msg);
    while($rowMsg = $queryMsg->fetch_assoc())
    {
        array_push($groups, $rowMsg['name']);
    }
?>