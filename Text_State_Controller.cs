using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0,sheets_1, lock_1, cell_mirror,freedom, corridor_0,
						stairs_0,floor,closet_door,stairs_1,corridor_1,in_closet,stairs_2,corridor_2,corridor_3,
						courtyard };
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.cell){
			state_cell();
		} else if (myState == States.sheets_0) {
			state_sheets_0();
		} else if (myState == States.mirror) {
			state_mirror();
		} else if (myState == States.lock_0) {
			state_lock_0();
		} else if (myState == States.cell_mirror) {
			state_cell_mirror();
		} else if (myState == States.sheets_1) {
			state_sheets_1();
		} else if (myState == States.lock_1) {
			state_lock_1();
		} else if (myState == States.freedom) {
			state_freedom();
		} else if (myState == States.corridor_0) {
			state_corridor_0();
		} else if (myState == States.stairs_0) {
			state_stairs_0();
		} else if (myState == States.floor) {
			state_floor();
		} else if (myState == States.closet_door) {
			state_closet_door();
		}  else if (myState == States.corridor_1) {
			state_corridor_1();
		} else if (myState == States.stairs_1) {
			state_stairs_1();
		} else if (myState == States.stairs_2) {
			state_stairs_2();
		} else if (myState == States.in_closet) {
			state_in_closet();
		} else if (myState == States.corridor_2) {
			state_corridor_2();
		} else if (myState == States.corridor_3) {
			state_corridor_3();
		} else if (myState == States.corridor_3) {
			state_corridor_3();
		} else if (myState == States.courtyard) {
			state_courtyard();
		}
			
		}
		
	#region states
	void state_cell() {
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, and the door " +
					"is locked from the outside. \n\n" +
					"Press S to view Sheets, M to view Mirror and L to view Lock" ;
					
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_0;
		} else if (Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0;
		} 
	 	
	}
	void state_sheets_0() {
		text.text = "You can't believe you sleep in these things. Surely it's " +
					"time somebody changed them. The pleasures of prison life " +
					"I guess! \n\n" +
					"Press R to Return to roaming your cell" ;
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
			}
		}
	void state_mirror() {
		text.text = "You are in front of a mirror now. Think what you can " +
					"do to escape. No idea? \n" +
					"Search you might find something. You got an idea!. Good "+
					"Come one proceed with it. \n " +
					"Press T to Take the idea and go forward R to Return to " +
					"roaming your cell" ;
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		} else if(Input.GetKeyDown(KeyCode.T)){
			myState = States.cell_mirror;
		}
	}
	void state_lock_0() {
		text.text = "You have the lock now!. Use it to open the door " +
					" and escape. Bye!. Are you afraid? \n\n" +
					"Press R to Return to roaming your cell" ;
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	void state_cell_mirror() {
		text.text = "You have sheets again! and Lock again!. It's again the  " +
					"pleasure of prison. :( \n\n" +
					"Press S to view Sheets again, L to view Lock again and " +
					"R to Return to your recent cell" ;
		
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_1;
		} else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_1;
		} else if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
	}
	void state_sheets_1() {
		text.text = "You found the sheets. are they useful ? " +
					"I guess not!. If not. \n\n" +
					"Press R to Return to cell mirror" ;
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
	}
	void state_lock_1() {
		text.text = "Yes! You found it. " +
					"Use the lock to open and have freedom. \n\n" +
					"Press O to Open the lock of prison" ;
		
		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.freedom;
		}
	}
	void state_freedom() {
		text.text = "Now you are free bird! but remember, change your dress " +
					"and escape. \n\n " +
					"Press R to Restart the Game! or Press C to move to higher level" +
					"to escape. " ;
			
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		} else if(Input.GetKeyDown(KeyCode.C)){
			myState = States.corridor_0;
		}
	}
	void state_corridor_0() {
		text.text = "You are in the corridor now. You have access to " +
					"stairs, floor and closet door \n\n " +
					"Press S to run to Stairs, F to walk on Floor and D for Closet Door" ;
		
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.stairs_0;
		} else if(Input.GetKeyDown(KeyCode.F)){
			myState = States.floor;
		} else if(Input.GetKeyDown(KeyCode.D)){
			myState = States.closet_door;
		}
	}
	void state_stairs_0() {
		text.text = "You have go to floor for hairclip to enter closet " +
					"\n\n" +
					"Press R to Return to Corridor" ;
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_0;
		}
	}
	void state_floor() {
		text.text = "You are on the floor and you found a hairclip " +
					" Please take it to enter the other corridor and "+
					"use closet to change the dress \n\n" +
					"Press C to Enter other corridor or R to Return to " +
					"exisiting Corridor" ;
		
		if(Input.GetKeyDown(KeyCode.C)){
			myState = States.corridor_1;
		} else if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_0;
		}
	}
	void state_closet_door() {
		text.text = "You have go to floor for hairclip to enter closet " +
					"\n\n" +
					"Press R to Return to Corridor" ;
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_0;
		}
	}
	void state_corridor_1() {
		text.text = "Here you have the hair clip to enter the corridor "+
					"Now either enter stairs 1 to run or enter in_closet " +
					"to dress up \n\n"+
					"Press S to run to stairs or I to enter in_closet" ;
					
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.stairs_1;
		} else if (Input.GetKeyDown(KeyCode.I)){
			myState = States.in_closet;
		}
	}
	void state_stairs_1() {
		text.text = "Please change the dress and run. Find in_closet. " +
					"\n\n" +
					"Press R to Return to Corridor 1" ;
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_1;
		}
	}
	void state_in_closet() {
		text.text = "Please change the dress and run. Go to Corridor 2 or " +
					"go to corridor 3 \n\n" +
					"Press J to Run to corridor 2 or K to Corridor 3" ;
		
		if(Input.GetKeyDown(KeyCode.J)){
			myState = States.corridor_2;
		} else if(Input.GetKeyDown(KeyCode.K)){
			myState = States.corridor_3;
		}
	}
	void state_corridor_2() {
		text.text = "Please climb stairs 2 and run " +
					"\n\n" +
					"Press S to Run to stairs 1 or R to Return to corridor 1" ;
		
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.stairs_2;
		} if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_1;
		}
	}
	void state_stairs_2() {
		text.text = "Sorry you are stuck. Run back and find a way. " +
					"\n\n" +
					"Press R to Run to Corridor 2" ;
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_2;
		}
	}
	void state_corridor_3() {
		text.text = "You entered corridor 3 and now enter courtyard to escape " +
					"\n\n" +
					"Press Y to Run to Courtyard" ;
		
		if(Input.GetKeyDown(KeyCode.Y)){
			myState = States.courtyard;
		}
	}
	void state_courtyard() {
		text.text = "Now no one can catch you. You changed dress and you are free " +
					"\n\n" +
					"Press R to Restart the Game!" ;
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	#endregion
}
	
