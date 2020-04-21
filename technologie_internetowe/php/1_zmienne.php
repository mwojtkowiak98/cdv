<?php
    echo "CDV<br>";
    echo "CDV<br>";

    $name='Marcin';
    echo "Mam na imię: $name";
    echo "Mam na imię ".$name;
    echo "Mam na imię ",$name,"<br>";

    $dec=100;
    $hex=0xB;
    $oct=021;
    $bin=0b1010;

    echo $dec,"<br>";
    echo $hex,"<br>";
    echo $oct,"<br>";

    $x=5.7;

    //składnia heredoc
    $name="Anna";
    $surname="Nowak";

    echo<<<ETYKIETA
        <br>Dane użytkownika<br>
        Imię:$name<br>
        Nazwisko:$surname<br>
    ETYKIETA;

    $data=<<<SHOW
        New data<br>
    SHOW;

    echo $data;

    //składnia nowdoc
    $name="Tadek";

    echo<<<'E'
    Imię:$name<br>
    E;
?>