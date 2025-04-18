<?php
$conn = new mysqli("localhost", "root", "", "attendance_system");
$data = json_decode(file_get_contents("php://input"));
$sql = "INSERT INTO students (student_id, name, course) VALUES ('$data->student_id', '$data->name', '$data->course')";
$conn->query($sql);
echo json_encode(["status" => "ok"]);
?>
