/**
 * This is an entry point class
 */
public class EntryPoint {
  public static void main(String[] args) {
    CarStore carStore = new CarStore();
    String answer = "Yes";

    ConsoleReader readFromConsole = new ConsoleReader();
    while (answer.compareTo("Yes") == 0) {
      carStore.setCarBrand(readFromConsole.consoleReadString("Enter car brand:"));
      carStore.setCarMode(readFromConsole.consoleReadString("Enter car model:"));
      carStore.setCarType(readFromConsole.consoleReadString("Enter car type:"));
      carStore.setCarPrice(readFromConsole.consoleReadInteger("Enter car price"));
      carStore.createDataOfASingleCar(carStore);
      answer = readFromConsole.askUserToContinue();
    }
    carStore.sortByPrice();
    carStore.outputCars();
  }
}
