public class Main {

  public static void main(String[] args) {
    try {
      ConsoleReader path = new ConsoleReader();
      PathValidator validator = new PathValidator();
      if (validator.pathValidation(path.readFromConsole())) {
        System.out.println("The path is correct.");
      } else {
        System.out.println("The path is not correct.");
      }
    } catch (Exception e) {
      System.out.println(e.getMessage());
    }
  }
}
