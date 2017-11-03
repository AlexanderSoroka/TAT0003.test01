/**
 * This class checks the path to the file.
 */
public class PathValidator {

  /**
   * Checks the validity of the path to the file.
   *
   * @param path the path to the file
   * @return true if the path is correct
   */
  public boolean pathValidation(String path) {
    boolean starts = path.startsWith(":", 2);
    boolean firstSlash = path.startsWith("\\", 3);
    boolean slashes = path.contains("\\");
    return ((starts && firstSlash) || slashes);
  }
}
