<?php
	
	require_once("info.php");
	
	$id = $_POST["id"];
	$name = $_POST["name"];
	$fpID = $_POST["fpid"];
	$xpos = $_POST["xpos"];
	$ypos = $_POST["ypos"];
	$enabled = $_POST["enabled"];
	
	$sql = "UPDATE `hnh-db`.`sensors` SET `floor_plan_id`='%d', `name`='%s', `floor_plan_xpos`='%d', `floor_plan_ypos`='%d', `enabled`='%s' WHERE `id`='%d';";
	$sql = sprintf($sql, $fpID,$name ,$xpos ,$ypos,$enabled,$id);
	$result = $mysqli->query($sql);
	//echo mysqli_error($mysqli);
	
	if ( false===$result ) {
		echo json_encode(["status" => "failed", "message" => false]);	
	}
	else{
		
			echo json_encode(["status" => "success", "message" => true]);
		
			
	}

?>