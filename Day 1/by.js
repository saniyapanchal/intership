function countChar(words, char) {
    let count = 0;
    let positions = {};
    for (let word of words) {
        positions[word] = [];
        for (let i = 0; i < word.length; i++) {
            if (word[i] === char) {
                positions[word].push(i);
                count++;
            }
        }
    }
    return [count, positions];
}

let words = prompt("Enter words separated by space: ").split(" ");
let char = prompt("Enter a character: ");
let [count, positions] = countChar(words, char);
console.log(`'${char}' appears ${count} times.`);
console.log("Positions in each word:", positions);
