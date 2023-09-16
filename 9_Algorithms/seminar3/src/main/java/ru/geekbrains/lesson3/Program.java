package ru.geekbrains.lesson3;

public class Program {

    public static void main(String[] args) {

//        Employee employee1 = new Employee("AAAAA", 33);
//        Employee employee2 = new Employee("BBBBB", 41);
//
//
//        LinkedList<Employee> linkedList = new LinkedList<>();
//        linkedList.addFirst(employee1);
//        linkedList.addFirst(employee2);
//        linkedList.addFirst(new Employee("CCCCC", 50));
//        linkedList.addFirst(new Employee("CCCCC", 43));
//        linkedList.addFirst(new Employee("CCCCC", 19));
//        linkedList.addFirst(new Employee("CCCCC", 23));
//        linkedList.addFirst(new Employee("CCCCC", 61));
//
//        linkedList.addFirst(new Employee("DDDD", 41));
//        linkedList.addFirst(new Employee("FFFF", 42));
//
//
//        System.out.println(linkedList);
//        System.out.println();
//
//        linkedList.sort(new EmployeeComparator(SortType.Ascending));
//
//        System.out.println(linkedList);
//        System.out.println();
//
//        linkedList.sort(new EmployeeComparator(SortType.Descending));
//
//        System.out.println(linkedList);
//        System.out.println();
//
//        linkedList.removeFirst();
//        linkedList.removeLast();
//
//        System.out.println(linkedList);
//        System.out.println();

    }

}
class Node {
    int val;
    Node next;

    public Node(int val) {
        this.val = val;
    }
}

class Answer {
    public Node head;
    public void reverseR(Node parent, Node current) {
      if (current == null) {
        head = parent;
        return;
      }
      // pre
      // recursive
        reverseR(current, current.next);
      // post
        parent.next = null;
        current.next = parent;
      }
  public void reverse() {
      reverseR(head, head.next);
    }
  }



