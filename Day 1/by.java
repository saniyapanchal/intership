import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter words separated by space: ");
        String[] words = scanner.nextLine().split(" ");
        System.out.println("Enter a character: ");
        char c = scanner.next().charAt(0);

        int count = 0;
        Map<String, List<Integer>> positions = new HashMap<>();
        for (String word : words) {
            List<Integer> indices = new ArrayList<>();
            for (int i = 0; i < word.length(); i++) {
                if (word.charAt(i) == c) {
                    count++;
                    indices.add(i);
                }
            }
            positions.put(word, indices);
        }

        System.out.println("'" + c + "' appears " + count + " times.");
        System.out.println("Positions in each word: " + positions);
    }
}
