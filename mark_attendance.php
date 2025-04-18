<?php
$conn = new mysqli("localhost", "root", "", "attendance_system");
$data = json_decode(file_get_contents("php://input"));
$sql = "INSERT INTO attendance (student_id, date, status) VALUES ('$data->student_id', '$data->date', '$data->status')";
$conn->query($sql);
echo json_encode(["status" => "ok"]);
?>
