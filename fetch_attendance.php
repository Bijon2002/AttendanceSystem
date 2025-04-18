<?php
header('Content-Type: application/json');

$conn = new mysqli("localhost", "root", "", "attendance_system");

$result = $conn->query("SELECT * FROM attendance");

$data = array();
while ($row = $result->fetch_assoc()) {
    $data[] = $row;
}

echo json_encode($data);
$conn->close();
?>
