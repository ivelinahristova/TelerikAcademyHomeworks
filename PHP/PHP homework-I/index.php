<?php
include 'header.php';


?>
         <a href="cost.php">Добави нов разход</a>
         <form method="post">
          <select name="kind">
            <?php
            foreach ($kinds as $key=>$value) {
                echo '<option value="'.$key.'">' . $value .
                        '</option>';
            }
            ?>
           
        </select>   
         <input type="submit" value="филтрирай">
         </form>
         <table border="1">
    <tr>
        <td>Дата</td>
        <td>Име</td>
        <td>Сума</td>
        <td>Вид</td>
    </tr>
    <?php
    if($_POST){
        $value=0;
        $group = (int)$_POST['kind'];
        if(file_exists('data.txt')){
        $result = file('data.txt');
        foreach ($result as $value) {
            $columns=  explode(',', $value); 
            if($columns[3] == $group || $group==6)
            {
            echo '<tr>
                <td>'.$columns[0].'</td>
                <td>'.$columns[1].'</td>
                <td>'.$columns[2].'</td>
                <td>'.$groups[trim($columns[3])].'</td>
                </tr>';
            $value +=(int)$columns[2];
            }
        }
        echo '<p>Общата сума е </p>'.$value.'.';
    }
    }
    ?>

    
</table>
     <?php
    include 'footer.php';
    ?>