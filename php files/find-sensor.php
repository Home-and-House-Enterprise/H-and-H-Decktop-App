<?php
	
	require_once("info.php");
	
	$id = $_POST["id"];
	
	$sql = "SELECT * FROM `hnh-db`.sensors WHERE floor_plan_id = 1 and id=%d;";
	$sql = sprintf($sql, $id);
	$result = $mysqli->query($sql);
	//echo mysqli_error($mysqli);
	
	if ( false===$result ) {
		echo json_encode(["status" => "failed", "message" => false]);	
	}
	else{
		$num_rows = $result->num_rows;
		if ($num_rows>0) {
			echo json_encode(["status" => "success", "message" => true]);
		}
		else{
			echo json_encode(["status" => "failed", "message" => false]);	
		}
			
	}

?>