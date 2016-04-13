<?php
	$mysqli = new mysqli("localhost", "hnh-user","hnhteam", "hnh-db");
	if (mysqli_connect_errno()) {
		printf("Connect failed: %s\n", mysqli_connect_error());
		exit();
	}
	
?>