<?php
include 'db.php';

$name = $_POST['name'] ?? '';
$section = $_POST['section'] ?? '';
$item = $_POST['item'] ?? '';
$date_time = $_POST['date_time'] ?? '';

if (!empty($name) && !empty($section) && !empty($item) && !empty($date_time)) {
    $stmt = $conn->prepare("INSERT INTO borrow_requests (name, section, item, date_time, status) VALUES (?, ?, ?, ?, 'Pending')");
    $stmt->bind_param("ssss", $name, $section, $item, $date_time);
    
    if ($stmt->execute()) {
        echo "success";
    } else {
        echo "error";
    }
} else {
    echo "error";
}
?>
