<?php
include "db.php";
$result = $conn->query("SELECT * FROM borrow_requests");
echo json_encode($result->fetch_all(MYSQLI_ASSOC));
?>
