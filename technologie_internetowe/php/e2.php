<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form method="POST">
        <input type="text" name="login" placeholder="Login"><br>
        <input type="submit" value="Sprawdz">
    </form>

    <?php
        $censure=array("biały", "czarny");
        $replace=array("_#***#_");

        if(!empty($_POST['login'])){
            $validLogin = str_ireplace($censure, $replace, $_POST['login']);
            echo<<<E
            Dane przed poprawą: $_POST[login]<br>
            Dane po poprawie: $validLogin<br>
            E;
        }
    ?>
</body>
</html>