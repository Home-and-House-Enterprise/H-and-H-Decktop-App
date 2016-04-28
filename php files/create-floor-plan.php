<?php
	
	require_once("info.php");
	
	$id = $_POST["id"];
	$name = $_POST["name"];
	$picture = $_POST["picture"];
	
	$sql = "INSERT INTO `hnh-db`.`floor_plans` ( userid, name, picture) VALUES ('%d', '%s', '%s');";
	$sql = sprintf($sql, $id, $name, $picture);
	$result = $mysqli->query($sql);
	//echo mysqli_error($mysqli);
	
	if ( false===$result ) {
		echo json_encode(["type" => "success", "message" => false]);	
	}
	else{
		echo json_encode(["type" => "success", "message" => true]);
			
	}

?>