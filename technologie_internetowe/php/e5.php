<?php
$data=getdate();

$h1=$data['hours'];
$m1=$data['minutes'];
$s1=$data['seconds'];

$y1=2020;
$m1=4;
$d1=21;

$time1=mktime($h1, $m1, $s1, $m1, $d1, $y1);

$h2=0;
$m2=0;
$s2=0;
$y2=2000;
$m2=4;
$d2=20;

$time2=mktime($h2, $m2, $s2, $m2, $d2, $y2);

$seconds=abs($time1-$time2);
$minutes=floor($seconds/60);
$days=floor($minutes/(60*24));
$years=number_format($days/365, 4);

echo "Ilosc sekund: $seconds<br>";
echo "Ilosc minut: $minutes<br>";
echo "Ilosc dni: $days<br>";
echo "Ilosc lat: $years<br>";

?>