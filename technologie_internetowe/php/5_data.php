<?php
    echo date("Y"),'<br>';
    echo date("Y-F-d"),'<br>'; //Y-m-d
    echo date("H-i-s"),'<br>';

    echo "Dzien tygodnia: ",date("w"),'<br>'; //weekday
    echo "Numer tygodnia: ",date("W"),'<br>'; 
    echo "Dzien roku: ",date("z"),'<br>'; //odejmwane od 0

    $data = getdate();
    echo '<pre>';
    print_r($data);
    echo '<pre>';

    echo "Dzien tygodnia: ",$data['weekday'],'<br>';
    echo "Dzien tygodnia: ",$data['wday'],'<br>';

    //znaczniki czasu
    $r1=2020;
    $m1=4;
    $d1=21;

    $time1=mktime(0, 0, 0, $m1, $d1, $r1);
    echo $time1,'<br>';
?>