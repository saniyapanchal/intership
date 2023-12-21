def count_char(words, char):
    return sum(word.count(char) for word in words), {word: [i for i, c in enumerate(word) if c == char] for word in words}

words = input("Enter words separated by space: ").split()
char = input("Enter a character: ")
count, positions = count_char(words, char)
print(f"'{char}' appears {count} times.")
print("Positions in each word:", positions)