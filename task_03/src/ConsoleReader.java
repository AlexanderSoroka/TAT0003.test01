import java.util.Scanner;

/**
 * This class get information entered by user from console.
 */
public class ConsoleReader {
  Scanner scanner =  new Scanner(System.in);

  /**
   * This method request user to enter data from console.
   * @param output message to user.
   * @return data entered by user size.
   */
  public String consoleReadString(String output) {
    System.out.println(output);
    String sizeOfArray = scanner.nextLine();
    return sizeOfArray;
  }
  /**
   * This method request user to enter data from console.
   * @param output message to user.
   * @return data entered by user size.
   */
  public int consoleReadInteger(String output) {
    System.out.println(output);
    int sizeOfArray = scanner.nextInt();
    scanner.nextLine();
    return sizeOfArray;
  }
  public String askUserToContinue() {
    System.out.println("Enter <Yes> to continue, press < No > otherwise");
    return scanner.nextLine();
  }
}