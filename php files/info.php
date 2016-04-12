<?php
	
	$db=mysql_connect ("localhost", "hnh-user", "hnhteam")
	or die ('I cannot connect to the database.');
	if(!$db){
		die( "Connection failed");
	}
	$isSelected= mysql_select_db ("hnh-db");
?>