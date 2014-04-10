<?php
    include 'user.php';
?>
<nav id="menu">
    <ul>
        <li>
            <a href="messages.php">Messages</a>
        </li>
        <li>
            <a href="new-message.php">New Message</a>
        </li>
        <?php
        if($admin)
        {
            echo '<li>
            <a href="new-group.php">New Group</a>
            </li>';
        }
        ?>
        <li>
            <a href="logout.php">Logout</a>
        </li>
    </ul>
</nav>