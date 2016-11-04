//Bruno Kovacevic

package Kovacevic;

public class Punkt {

	int x;
	int y;
	//String ausg = "Punkt [x=" +x +", " + "y=" + y +"]"; 
	
	public Punkt (int xPunkt, int yPunkt){
		x = xPunkt;
		y = yPunkt;
	}
	
	public int getX(){
		return x;
	}
	
	public int getY(){
		return y;
	}
	
	
	public String toString(){
		//return ausg;
		return "Punkt [x=" + x + ", y=" + y + "]";
	}
	
}
