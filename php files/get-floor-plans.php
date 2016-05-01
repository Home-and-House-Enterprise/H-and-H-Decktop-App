<?php
	
	require_once("info.php");
	
	$id = $_POST["userid"];
	
	$sql = "SELECT * FROM `hnh-db`.floor_plans WHERE userid = %d;";
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
				array_push($list, array("id" => $row["id"], "userid" => $row["userid"], 
					 "name" => $row["name"], "picture" => $row["picture"]));
			}
			$info["floorPlans"] = $list;
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