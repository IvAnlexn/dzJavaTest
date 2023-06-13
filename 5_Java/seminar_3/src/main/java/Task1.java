import java.util.ArrayList;
import java.util.ListIterator;
import java.util.Random;

public class Task1 {
  public static void main(String[] args) {
    ArrayList<Integer> list = new ArrayList<>();
    Random rand = new Random();
    while (list.size() < 10) {
      list.add(rand.nextInt(100));
    }
    ArrayList<Integer> oddList = removeEven(list);
    Integer max = getMax(oddList);
    Integer min = getMin(oddList);
    Integer mean = getMean(oddList);

  }

  public static ArrayList<Integer> removeEven(ArrayList<Integer> list) {
    ListIterator<Integer> iterator = list.listIterator();
    while (iterator.hasNext()) {
      int i = iterator.next();
      if (i % 2 == 0) iterator.remove();
    }
    return list;
  }

  public static Integer getMax(ArrayList<Integer> list) {
    Integer max = list.get(0);
    for (int i = 1; i < list.size(); i++) {
      if (list.get(i) > max) max = list.get(i);
    }
    return max;
  }
  public static Integer getMin(ArrayList<Integer> list) {
    Integer min = list.get(0);
    for (int i = 1; i < list.size(); i++) {
      if (list.get(i) < min) min = list.get(i);
    }
    return min;
  }
  public static Integer getMean(ArrayList<Integer> list) {
    Integer sum = 0;
    for (int i = 0; i < list.size(); i++) {
      sum+=list.get(i);
    }
    return sum / list.size();
  }
}