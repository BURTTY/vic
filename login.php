<?php
session_start();

// Fixed Admin Credentials
$fixed_username = "admin";
$fixed_password = "admin123";

$username = $_POST['username'] ?? '';
$password = $_POST['password'] ?? '';

if ($username === $fixed_username && $password === $fixed_password) {
    $_SESSION['admin'] = true;
    echo "success";
} else {
    echo "error";
}
?>
