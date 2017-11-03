import java.util.Scanner;

/**
 * Reads data entered by a user from a console.
 */
public class ConsoleReader {
  /**
   * Reads the data from the console.
   *
   * @return the data from the console
   */
  public String readFromConsole() {
    Scanner scanner = new Scanner(System.in);
    System.out.println("Enter a path of on object: ");
    String s = scanner.nextLine();
    return s;
  }
}
