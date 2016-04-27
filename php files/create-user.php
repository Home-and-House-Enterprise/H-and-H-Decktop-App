<?php
	require_once("info.php");
	function getUserID($user,$pass){
		$sql = "SELECT * FROM users WHERE UPPER(username) = UPPER('".$user."') AND password='".$pass."'";
		$result = $mysqli->query($sql);
		if ( false===$result ) {
		  //printf("error: %s\n", mysqli_error($mysqli));
		}
		$row = $result->fetch_assoc();
		//if($row = $result->fetch_assoc())

		return $row["id"];
	}
	function createSetting($id,$key,$value){
		$sql = "INSERT INTO `hnh-db`.`settings` (`user_id`, `key`, `value`) VALUES ('".$id."', '".$key."', '".$value."');";
		$result = $mysqli->query($sql);
		if ($_GET["mode"]=="debug"){
			echo "get here";
		}
		if ( false===$result ) {
			return false;
		}
		else{
			return true;
		}
	}
	if ($_GET["mode"]=="debug"){
		echo "Debugging";
		echo "output:".createSetting(1,"systemStatus","disarmed");
		echo "get here 2";
		exit("Done!");
	}
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
		//$id=getUserID($user,$pass);
	/*	if(createSetting(1,"systemStatus","disarmed")===false){
			echo json_encode(["type" => "success", "message" => true]);
		}
		else{
			echo json_encode(["type" => "success", "message" => false]);
		}*/
		
	}

?>