import java.util.Comparator;

/**
 * This class compare types of cars.
 */
public class CompareCarType implements Comparator<CarStore> {

  /**
   * This function compares two stored types of cars
   * @param currentCar current value of car data
   * @param nextCar next data after currentCar
   * @return result of comparing.
   */
  @Override
  public int compare(CarStore currentCar, CarStore nextCar) {
    if (currentCar.carType.compareTo(nextCar.carType) == -1) {
      return 1;
    } else if (nextCar.carType.compareTo(currentCar.carType) == -1) {
        return -1;
    } else {
      return 0;
    }
  }
}
