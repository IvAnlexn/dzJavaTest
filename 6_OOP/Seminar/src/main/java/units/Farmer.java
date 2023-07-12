package units;

import java.util.ArrayList;

public class Farmer extends Character{

  public Farmer(Names name, int x, int y) {
    super(name, 2, 2, 1, 1, 1, 1, x, y);
  }

  @Override
  public void step(ArrayList<Character> team, ArrayList<Character> team2){
    if (state.equals(States.DEAD)) return;
    state = States.READY;
  }
  }
