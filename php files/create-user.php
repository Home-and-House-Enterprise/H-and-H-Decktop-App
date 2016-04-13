<?php
	
	require_once("info.php");
	$name = $_POST["name"];
	$user = $_POST["username"];
	$pass = $_POST["password"];
	$sql = "INSERT INTO `hnh-db`.`users` (`username`, `name`, `password`) VALUES ('".$user."', '".$name."','".$pass."');";
	$result = $mysqli->query($sql);
	if ( false===$result ) {
		echo json_encode(["type" => "success", "message" => false]);
	}
	else{
		echo json_encode(["type" => "success", "message" => true]);
	}
?>