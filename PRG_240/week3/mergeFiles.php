<?php

	$string1 = file_get_contents("./record1.cvs");
	$string2 = file_get_contents("./record2.cvs");
	$string3 = file_get_contents("./record3.cvs");

	$final_string = $string1 . $string2 . $string3;

	file_put_contents( "merged.cvs", $final_string );

// mklink C:\xampp2\htdocs\mergeFiles.php C:\Users\Esposito\Documents\GitHub\CCSD_WORK2\PRG_240\week3\mergeFiles.php
?>

