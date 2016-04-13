<?php
	
	require_once("info.php");
	$name = $_POST["username"];
	$pass = $_POST["password"];
	$sql = "SELECT * FROM users WHERE UPPER(username) = UPPER('".$name."') AND password='".
	$pass."'";
	$result = $mysqli->query($sql);
	if ( false===$result ) {
	  //printf("error: %s\n", mysqli_error($mysqli));
	}
	$row = $result->fetch_assoc();
	//if($row = $result->fetch_assoc())
		echo json_encode(["id" => $row["id"],"name" => $row["name"],"address" => $row["address"], 
		"accountType" => $row["accountType"]]);
	//}

?>