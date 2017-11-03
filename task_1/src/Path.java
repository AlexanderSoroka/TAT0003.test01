/**
 * This class contains methods for working with path in OS Windows.
 */

public class Path {
  /**
   * This method define is path valid or not.
   * @param args - path that getting from command line.
   * @return - true if path is valid and false if isn't.
   */

  private boolean isValid(String args[]) {
    int count = 0;
    char[] pathArray = args[0].toCharArray();
    char[] notValidSymbols = {47, 58, 60, 62, 63, 42, 38, 39};
    for (int i = 0; i < pathArray.length; i++) {
      for (int j = 0; j < notValidSymbols.length; j++) {
        if (pathArray[i] == notValidSymbols[j]) {
          return false;
        }
      }
    } return true;
  }

  /**
   * this method output result of work method isValid in users friendly way.
   * @param args - path that getting from command line
   */
  public void output(String args[]) {
    if( isValid(args)) {
      System.out.println("This path exists");
    } else {
      System.out.println("This path doesn't exist.");
    }
  }
}
