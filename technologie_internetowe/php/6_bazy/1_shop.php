<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>shop - user</title>
    <link rel="stylesheet" href="5451_table.css">
</head>
<body>
    <h3>Tabela user</h3>
    <?php
        require_once './scripts/connect.php';
        require_once './scripts/function.php';
        $sql = "SELECT * FROM `user`";
        echo <<<TABLE
        <table>
        <tr>
            <th>Id</th>
            <th>Imię</th>
            <th>Nazwisko</th>
            <th>Data urodzenia</th>
            <th>Rok urodzenia</th>
        </tr>
        </table>
        TABLE;
        if($result = mysqli_query($conn, $sql)){

            while($row = mysqli_fetch_assoc($result)){

                $year = year($row['birthday']);
                if($year==0000){
                    $year = '-';
                }
                echo <<<ROW
                <tr>
                <td>{$row['id']}</td>
                <td>{$row['name']}</td>
                <td>{$row['surname']}</td>
                <td>{$row['birthday']}</td>
                <td>$year</td>
                <td><a href=".scripts/del_user.php?id=$row[id]"Usuń</a></td>
                </tr>
                ROW;
        }
            echo '</table>';
        }
        //else{
        //    echo 'error';
        //}
    ?>
</body>
</html>