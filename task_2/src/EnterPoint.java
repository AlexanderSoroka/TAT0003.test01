import java.util.ArrayList;

/**
 * Created by Dasha on 03.11.2017.
 */
public class EnterPoint {
  public static void main(String[] args) {
    Collection userCollection = new Collection();
    ArrayList userArraylist = new ArrayList();
    userArraylist.add(6);
    userArraylist.add("hi");
    userArraylist.add("hi");
    userArraylist.add(7);
    System.out.println("Number of non-unique elemets is:" +
        + userCollection.countNonUnique(userArraylist));
  }
}
