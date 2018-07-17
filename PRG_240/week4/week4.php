<?php
	// 01 - open files
	$E = "<br/>";
	$f = fopen( "beach.bmp", "rb");
	$size_file = filesize( "beach.bmp");
	echo "The file size is = $size_file$E";
	// 02 - grab data

?>