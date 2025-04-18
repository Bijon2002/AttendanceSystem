<?php
$host = "localhost";
$user = "root";
$pass = "";
$db = "attendance_system";

// Connect to DB
$conn = new mysqli($host, $user, $pass, $db);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Get data from POST
$student_id = $_POST['student_id'];
$date = $_POST['date'];
$status = $_POST['status'];

// Insert query
$sql = "INSERT INTO attendance (student_id, date, status) 
        VALUES ('$student_id', '$date', '$status')";

if ($conn->query($sql) === TRUE) {
    echo "success";
} else {
    echo "error";
}

$conn->close();
?>
