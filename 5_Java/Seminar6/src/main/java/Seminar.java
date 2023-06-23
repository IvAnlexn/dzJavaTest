import java.util.HashMap;
import java.util.Iterator;

public class Seminar {
  public static void main(String[] args) {
    CustomSet mySet = new CustomSet();
    System.out.println(mySet.isEmpty());
    mySet.add(1);
    mySet.add(2);
    mySet.add(1);
    for (Iterator<Integer> it = mySet.iterator(); it.hasNext(); ) {
      int num = it.next();
      System.out.println(num);
    }
    System.out.println(mySet.isEmpty());
    System.out.println(mySet.get(1));
    System.out.println(mySet.contains(2));
    System.out.println(mySet.toString());
    System.out.println(mySet.remove(1));
    System.out.println(mySet.remove(1));
    System.out.println(mySet.remove(2));
    System.out.println(mySet.isEmpty());
  }
}

class CustomSet {
  private HashMap<Integer, Object> set = new HashMap<>();
  private static final Object PRESENT = new Object();

  public boolean add(int value) {
    return set.putIfAbsent(value, PRESENT) == null;
  }

  public boolean remove(int value) {
    return set.remove(value) == PRESENT;
  }

  public boolean isEmpty() {
    return set.isEmpty();
  }

  public boolean contains(int value) {
    return set.containsKey(value);
  }

  public int get(int id) {
    return (int) set.keySet().toArray()[id];
  }

  public Iterator<Integer> iterator() {
    return set.keySet().iterator();
  }

  public String toString() {
    return set.keySet().toString();
  }
}
