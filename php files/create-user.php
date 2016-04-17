<?php
	
	require_once("info.php");
	$name = $_POST["name"];
	$user = $_POST["username"];
	$pass = $_POST["password"];
	$email = $_POST["email"];
	$sql = "INSERT INTO `hnh-db`.`users` (`username`, `name`, `email`,`password`) VALUES ('".$user."', '".$name."', '".$email."','".$pass."');";
	$result = $mysqli->query($sql);
	if ( false===$result ) {
		echo json_encode(["type" => "success", "message" => false]);
	}
	else{
		echo json_encode(["type" => "success", "message" => true]);
	}
?>