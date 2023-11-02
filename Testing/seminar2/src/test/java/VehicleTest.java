import lib.Car;
import lib.Motorcycle;
import lib.Vehicle;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import static org.assertj.core.api.Assertions.*;

class VehicleTest {

  private Car car;
  private Motorcycle motorcycle;
  private final int carWheelsNumber = 4;
  private final int carTestDriveSpeed = 60;
  private final int motorcycleTestDriveSpeed = 75;
  private final int vehicleParkSpeed = 0;
  private final int motorcycleWheelsNumber = 2;

  @BeforeEach
  public void prepareTestData() {
    this.car =  new Car("lada", "vesta", 2020);
    this.motorcycle =  new Motorcycle("izh", "izh", 1985);
  }

  @Test
  public void isCarInstanceOfVehicle() {
    assertThat(this.car).isInstanceOf(Vehicle.class);
  }

  @Test
  public void isCarHasFourWheels() {
    assertThat(this.car.getNumWheels()).isEqualTo(this.carWheelsNumber);
  }

  @Test
  public void isMotorcycleHasTwoWheels() {
    assertThat(this.motorcycle.getNumWheels())
            .isEqualTo(this.motorcycleWheelsNumber);
  }

  @Test
  public void isCarTestDriveSpeedValid() {
    this.car.testDrive();
    assertThat(this.car.getSpeed()).isEqualTo(carTestDriveSpeed);
  }

  @Test
  public void isMotorcycleTestDriveSpeedValid() {
    this.motorcycle.testDrive();
    assertThat(this.motorcycle.getSpeed()).isEqualTo(motorcycleTestDriveSpeed);
  }

  @Test
  public void isCarParkSpeedValid() {
    this.car.testDrive();
    this.car.park();
    assertThat(this.car.getSpeed()).isEqualTo(vehicleParkSpeed);
  }

  @Test
  public void isMotorcycleParkSpeedValid() {
    this.motorcycle.testDrive();
    this.motorcycle.park();
    assertThat(this.motorcycle.getSpeed()).isEqualTo(vehicleParkSpeed);
  }
}