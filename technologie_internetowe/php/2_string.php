<?php
$text=<<<TEXT
CDV -
Collegium
Da
Vinci<br>
TEXT;

echo $text;
echo nl2br($text);

echo strtolower($text); //zamiana na male litery
echo strtoupper($text); //zamiana na duze litery
echo ucfirst(strtolower($text)); //UpperCase First
$text1=strtolower($text);
$text1=ucfirst($text1);
echo $text1;
echo ucwords(strtolower(trim($text)));


$lorem="Lorem ipsum dolor, sit amet consectetur adipisicing elit. Nisi veniam tempora similique corrupti tenetur facilis autem perferendis sapiente sit, repudiandae recusandae, odit ipsum adipisci nam minima, eum enim aspernatur incidunt.";
echo $lorem,"<br>";
$col=wordwrap($lorem, 40, "<br>");

echo $col;

//usuwanie bialych znakow

$name=" Janusz  "; //9
echo strlen($name),"<br>"; //9
echo strlen(ltrim($name)),"<br>"; //8
echo strlen(rtrim($name)),"<br>"; //7
echo strlen(trim($name)),"<br>"; //6

$address="Poznan, ul. Polna 10, tel. (61) 123 341 123";
$find=strstr($address, 'tel');
echo $find,"<br>";

$find=stristr($address, 'Tel'); //in sensitive case Tel zamist tel + jakby dodać ,true to wyswietli 'do momentu' pojawienia sie 'tel' - domyslnie jest false
echo $find,"<br>";

$surname=substr("Janusz kowalski", 7, 5);
echo $surname,'<br>';

//przetwarzanie ciagow znakow

$login="Bączek";
$censure=array("ą", "ę", "ć", "Ą");
$replace=array("a", "e", "c", "a");

$validLogin=str_ireplace($censure, $replace, $login); //i replace powinno dzialac na sensitive case

echo "Dane przed poprawą: $login","<br>";
echo "Dane po poprawie: $validLogin","<br>";


?>