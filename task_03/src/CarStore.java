import java.util.ArrayList;
import java.util.Collections;

/**
 * This class create cars: models,Brands,types and prices and
 *  sort information.
 */
public class CarStore {
  String carBrand;
  String carMode;
  String carType;
  int carPrice;
  ArrayList<CarStore> store = new ArrayList<>();
  public void setCarBrand(String brand){
    this.carBrand = brand;
  }
  public void setCarMode(String model){
    this.carMode = model;
  }
  public void setCarType(String type) {
    this.carType = type;
  }
  public void setCarPrice(int price) {
    this.carPrice = price;
  }
  public String getCarBrand(){
    return carBrand;
  }
  public String getCarMode() {
    return carMode;
  }
  public String getCarType() {
    return carType;
  }
  public int getCarPrice() {
    return carPrice;
  }

  /**
   * Create array of car data
   * @param dataOfASingleCar single car data
   * @return formed array
   */
  public ArrayList<CarStore> createDataOfASingleCar(CarStore dataOfASingleCar ) {
    store.add(dataOfASingleCar);
    return store;
  }
  public ArrayList<CarStore> getCreatedDataOfCars(){
    return store;
  }
  public ArrayList<CarStore> sortByPrice() {
    //for (int i = 0; i < store.size(); i++) {
      Collections.sort(store ,new CompareCarPrice());
      return store;
  }
  public void outputCars() {
    for(int i = 0; i < store.size(); i++) {
      System.out.println(store.get(i).carBrand);
      System.out.println(store.get(i).carMode);
      System.out.println(store.get(i).carType);
      System.out.println(store.get(i).carPrice);
    }
  }
}

