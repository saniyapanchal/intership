<?php
function count_char($words, $char) {
    $count = 0;
    $positions = array();
    foreach ($words as $word) {
        $count += substr_count($word, $char);
        $pos = array();
        for ($i = 0; $i < strlen($word); $i++) {
            if ($word[$i] == $char) {
                array_push($pos, $i);
            }
        }
        $positions[$word] = $pos;
    }
    return array($count, $positions);
}

echo "Enter words separated by space: ";
$words = explode(" ", trim(fgets(STDIN)));
echo "Enter a character: ";
$char = trim(fgets(STDIN));
list($count, $positions) = count_char($words, $char);
echo "'$char' appears $count times.\n";
echo "Positions in each word:\n";
print_r($positions);
?>
