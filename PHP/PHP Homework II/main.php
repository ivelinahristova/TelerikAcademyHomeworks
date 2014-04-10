<nav>
<div>
    <p id="user"><span id="username"><?php echo 'Hello, '.$_SESSION['username']; ?></span>
    <a href="Logout.php">Logout</a></p>
</div>
<div id="menu">
    <div class="button left">
        <a href="upload.php">Upload File</a>
    </div>
    <div class="button">
        <a href="profile.php">View Profile</a>
    </div>
</div>
    </nav>