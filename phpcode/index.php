<?php

$library = new COM('{BF0489DB-1A00-4D7B-A33A-15B7DB09DFC7}');
$args = ["s1", "s2"];
echo "<p>" . $library->MyMethod("a string", 25, $args) . "</p>";
foreach ($args as &$param) {
  $param = "c";
}
echo "<p>" . $library->MyMethod("a string", 25, $args) . "</p>";