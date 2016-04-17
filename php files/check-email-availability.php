<?php
	
	require_once("info.php");
	$email = $_POST["email"];
	$sql = "SELECT name FROM users WHERE UPPER(email) = UPPER('".$email."')";
	//$sql = "SELECT * FROM users";
	$result = $mysqli->query($sql);
	$num_rows = $result->num_rows;
	if ( false===$result ) {
	  //printf("error: %s\n", mysqli_error($mysqli));
	}
	if ($num_rows>0) {
		echo json_encode(["type" => "general", "message" => true]);
	}
	else{
		echo json_encode(["type" => "general", "message" => false]);
	}
?>