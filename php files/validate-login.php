<?php
	
	require_once("info.php");
	$name = $_POST["username"];
	$pass = $_POST["password"];
	$sql = "SELECT * FROM users WHERE UPPER(username) = UPPER('".$name."') AND password='".
	$pass."'";
	//$sql = "SELECT * FROM users";
	$result = $mysqli->query($sql);
	$num_rows = $result->num_rows;
	if ( false===$result ) {
	  //printf("error: %s\n", mysqli_error($mysqli));
	}
	if ($num_rows>0) {
		echo json_encode(["name" => "general","type" => "verified", "message" => true]);
	}
	else{
		echo json_encode(["name" => "general","type" => "verified", "message" => false]);
	}
?>