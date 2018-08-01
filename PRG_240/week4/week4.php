<!DOCTYPE html>
<html>
<head>
	<title></title>

	<script type="text/javascript">
		function OnClick()
		{
			const str = document.getElementById("ip").value;
			const regex = /^\d{1,3}\.{1}\d{1,3}\.{1}\d{1,3}\.{1}\d{1,3}$/gm;
			let m;
			while( ( m = regex.exec( str ) ) !== null )
			{
    			// This is necessary to avoid infinite loops with zero-width matches
    			if (m.index === regex.lastIndex) {
        			regex.lastIndex++;
    			}
    
    			// The result can be accessed through the `m`-variable.
    			m.forEach((match, groupIndex) =>
    			{
        			window.alert('Found match, group ${groupIndex}: ${match}');
    			});
			}
		}

	</script>

	<?php

		class BMP_Reader
		{
			private $f;

			public function __construct( $filepath )
			{
				$f = fopen( $filepath, "rb" );
			}
			
			public function __destruct()
			{
				fclose( $f );
			}
		}

		// character to byte conversion
		function c2b( $string )
		{
			return ord( $string );
		}
		function BytesAsIntBigEndian( $offset, $content )
		{
			$b1 = ( c2b( $content[ $offset + 0 ] )  );
			$b2 = ( c2b( $content[ $offset + 1 ] )  );
			$b3 = ( c2b( $content[ $offset + 2 ] )  );
			$b4 = ( c2b( $content[ $offset + 3 ] ) );
			echo "$b1 $b2 $b3 $b4<br/>";
		}


		function BytesAsWordLittleEndian( $offset, $content )
		{
			$b1 = ( c2b( $content[ $offset + 1 ] ) << 8 );
			$b2 = ( c2b( $content[ $offset + 0 ] ) );
			return ( $b1 + $b2 );
		}
		function BytesAsIntLittleEndian( $offset, $content )
		{
			$b1 = ( c2b( $content[ $offset + 3 ] ) << 24 );
			$b2 = ( c2b( $content[ $offset + 2 ] ) << 16 );
			$b3 = ( c2b( $content[ $offset + 1 ] ) << 8 );
			$b4 = ( c2b( $content[ $offset + 0 ] )  );
			return ( $b1 + $b2 + $b3 + $b4 );
		}

		function ReadBMPHeader()
		{
			// 01 - open files
			$E = "<br/>";
			$f = fopen( "beach.bmp", "rb");

			// 02 - Go to the END of file
			fseek( $f, 0, SEEK_END );

			// 03 - After seeking, let's tell
			$size2 = ftell( $f );
			echo "file size = $size2$E";
			// 04 - we rewind
			fseek( $f, 0, SEEK_SET );

			// 05 - read data
			$content = fread( $f, $size2 );
			//$content = ord( $content );

			// $bytes = Array();
			// for( $i = 0; $i < $size2; $i++ ) {
			// 	$bytes[] = ord( $content[ $i ] );
			// }

			$c1 = dechex( ord( $content[0] ) );
			$c2 = dechex( ord( $content[1] ) );


			echo "HEADER's first 2 bytes = $c1$c2<br/>";



			$sz3 = BytesAsIntLittleEndian( 2, $content );
			echo "found (unreliable) size = $sz3$E";
			$sum1 = ord( $content[5] ) + ord( $content[6] );
			$sum2 = ord( $content[7] ) + ord( $content[8] );
			if( ( 0 == $sum1 ) && ( 0 == $sum2 ) ) {
				echo "The reserved fields check out$E";
			} else {
				echo "The reserved fields do NOT check out$E";
				die( "I don't want to live on this planet anymore!$E");
			}

			$offsetStartImageData = BytesAsIntLittleEndian( 10, $content );
			echo "Our pixel data starts at position...$offsetStartImageData$E";
			//$v = String2Hex( $content );

			if( BytesAsIntLittleEndian( 14, $content ) != 40 ) {
				echo "The size of BITMAPINFOHEADER structure, must be 40, But it's not... Oh, the humanity!!!$E";
				die( "I don't want to live on this planet anymore!$E");
			} else {
				echo "The size of BITMAPINFOHEADER structure, must be 40... Ant it is - Winning!!$E";
			}

			$w = BytesAsIntLittleEndian( 18, $content );
			$h = BytesAsIntLittleEndian( 22, $content );

			echo "The image's dimensions are: w = $w, h = $h$E";

			// number of planes in the image, must be 1
			$NumPlanes = BytesAsWordLittleEndian( 26, $content );
			if( 1 != $NumPlanes ) {
				die( "The number of planes should 1, and it's not... Bye, oh cruel world!$E");
			} else {
				echo "Num planes is 1, continuing$E";
			
			}

			$numBitsPerPixel = BytesAsWordLittleEndian( 28, $content );

			$check = ( $numBitsPerPixel == 1 ) || ( $numBitsPerPixel == 4 ) || ( $numBitsPerPixel == 8 )  || ( $numBitsPerPixel == 24 );

			if( $check == false ) {
				die( "Improper number of bits per pixels - AKA Alien Format$E");
			} else {
				echo "Valid number of bits per pixel, that number is $numBitsPerPixel$E";
			}

			$compression_string = "";
			$compression = BytesAsWordLittleEndian( 30, $content );
			switch( $compression ) {
				case 0 : {
					$compression_string = "none";
				} break;

				case 1 : {
					$compression_string = "RLE-4";
				} break;

				case 2 : {
					$compression_string = "RLE-8";
				} break;

				default : {
					die( "Not a valid compression scheme$E");
				}
			}

			echo "The compression used is $compression_string$E";

			$raw_data_sz = BytesAsIntLittleEndian( 34, $content );
			echo "Size of pixel data is $raw_data_sz$E";

			$h_rez_in_pix_per_meter = BytesAsIntLittleEndian( 38, $content );

			echo "The H RES. (number of pixels per meter) is $h_rez_in_pix_per_meter$E";

			$v_rez_in_pix_per_meter = BytesAsIntLittleEndian( 42, $content );

			echo "The V RES. (number of pixels per meter) is $v_rez_in_pix_per_meter$E";

			$numColors = BytesAsIntLittleEndian( 46, $content );
			echo "The number of colors in our picture is = $numColors$E";

			$numImportantColor = BytesAsIntLittleEndian( 50, $content );
			echo "The number of IMPORTANT colors in our picture is = $numImportantColor$E";
		}
		?>
</head>
<body>
	<?php
		function checkInput()
		{
			// $dom = new DOMDocument();
			// $dom->loadHTML("week4.php");
			// $input = $dom->getElementsById('ip');
			// $content = $input->getAttribute();
			echo '<script language="javascript">';
			echo 'alert("The content you have entered is whatever")';
			echo '</script>';

		}
	?>
	<form id="thatForm">
		<table>
			<tr>
				<td>Enter IP Address</td>
				<td><input type="text" id="ip"/></td>
			</tr>
		</table>
		<input type="button" onclick="OnClick()" value="Validate Input">
	</form>
</body>
</html>

