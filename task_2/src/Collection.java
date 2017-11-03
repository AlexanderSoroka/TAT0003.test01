import java.util.ArrayList;

public class Collection {
  int count = 0;

  /**
   * This method count non-unique objects in collection.
   * @param userCollection - is collection which user intuts
   * @return - number of nin-unique elements.
   */
  public int countNonUnique(ArrayList userCollection) {
    for (int i = 0; i < userCollection.size() - 1; i++) {
      if (userCollection.get(i).equals(userCollection.get(i+1))) {
        count++;
      }
      if (userCollection.get(userCollection.size()).equals(userCollection.get(i))) {
        count++;
      }
    } return count;
  }
}
