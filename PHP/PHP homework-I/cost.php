<?php
mb_internal_encoding('UTF-8');
include 'header.php';

if($_POST){
    $date=trim($_POST['date']);
    $date=  str_replace(',', '', $date);
    $name=trim($_POST['name']);
    $name=  str_replace(',', '', $name);
    $price=trim($_POST['price']);
    $price=  str_replace(',', '', $price);
    $selectedGroup=(int)$_POST['group'];
    $error=false;
    if(mb_strlen($name)<3){
        echo '<p>Името е прекалено късо</p>';
        echo mb_strlen($name);
        $error=true;
    }
    if(!array_key_exists($selectedGroup, $groups)){
        echo '<p>невалидна група</p>';
        $error=true;
    }
    
    if(!$error){
        $result=$date.','.$name.','.$price.','.$selectedGroup."\n";
        if(file_put_contents('data.txt', $result,FILE_APPEND))
        {
            echo 'Записа е успешен';
        }
    }
    
    
}




?>
<a href="index.php">Списък</a>
<form method="POST">
    <div>
        <label>Дата:</label>
        <input type="text" name="date" id="datepicker" />
    </div>
    
    <div><label>Име:</label><input type="text" name="name" /></div>
    <div>
        <label>Цена:</label>
        <input type="text" name="price" />
    </div>
    <label>Вид</label>
    <div>
        <select name="group">
            <?php
            foreach ($groups as $key=>$value) {
                echo '<option value="'.$key.'">' . $value .
                        '</option>';
            }
            ?>
        </select>           
    </div>        
    <div><input type="submit" value="Добави" /></div>
</form>
<?php
include 'footer.php';
?>