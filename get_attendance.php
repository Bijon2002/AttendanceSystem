<?php
$conn = new mysqli("localhost", "root", "", "attendance_system");
$result = $conn->query("SELECT * FROM attendance");
$data = [];
while($row = $result->fetch_assoc()) $data[] = $row;
echo json_encode($data);
?>
