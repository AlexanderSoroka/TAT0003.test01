import java.util.Comparator;

/**
 * This class compare prices of cars.
 */
public class CompareCarPrice implements Comparator<CarStore> {

  /**
   * This function compares two stored prices
   * @param currentCar current value of car data
   * @param nextCar next data after currentCar
   * @return result of comparing.
   */
  @Override
  public int compare(CarStore currentCar, CarStore nextCar) {
    if (currentCar.carPrice > nextCar.carPrice ) {
      return 1;
    } else  if (nextCar.carPrice > currentCar.carPrice )  {
      return -1;
    } else {
      return 0;
    }
  }
}
