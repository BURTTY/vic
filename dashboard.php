<?php
session_start();
include 'db.php';

if (!isset($_SESSION['admin'])) {
    header("HTTP/1.1 403 Forbidden");
    exit();
}

$sql = "SELECT * FROM borrow_requests";
$result = $conn->query($sql);

$requests = [];
while ($row = $result->fetch_assoc()) {
    $requests[] = $row;
}

header("Content-Type: application/json");
echo json_encode($requests);
?>
