<?php
include "db.php";

if (isset($_GET['id']) && isset($_GET['status'])) {
    $id = $_GET['id'];
    $status = $_GET['status'];
    $conn->query("UPDATE borrow_requests SET status='$status' WHERE id=$id");
    header("Location: ../public/dashboard.html");
}
?>
