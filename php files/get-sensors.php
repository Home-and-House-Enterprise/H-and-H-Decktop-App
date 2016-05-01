<?php
	
	require_once("info.php");
	
	$id = $_POST["fpid"];
	
	$sql = "SELECT * FROM `hnh-db`.sensors WHERE floor_plan_id = %d;";
	$sql = sprintf($sql, $id);
	$result = $mysqli->query($sql);
	//echo mysqli_error($mysqli);
	
	if ( false===$result ) {
		echo json_encode(["status" => "failed", "message" => false]);	
	}
	else{
		$num_rows = $result->num_rows;
		if ($num_rows>0) {
			$info =array("status" => "success", "message" => true);
			$list = array();
			/* fetch associative array */
			while ($row = $result->fetch_assoc()) {
				array_push($list, array("id" => $row["id"], "fpid" => $row["floor_plan_id"], 
					 "name" => $row["name"], "xpos" => $row["floor_plan_xpos"], "ypos" => $row["floor_plan_ypos"],
					 "enabled" => intval($row["enabled"] )));
			}
			$info["sensors"] = $list;
			echo json_encode($info);
		}
		else{
			echo json_encode(["status" => "failed", "message" => false]);	
		}
			
	}
	if ($result = $mysqli->query($query)) {

		/* free result set */
		$result->free();
	}
	els

?>