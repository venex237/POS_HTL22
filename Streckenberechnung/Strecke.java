//Bruno Kovacevic 

package Streckenberechnung;
import java.text.DecimalFormat;

public class Strecke {
	Punkt p1;
	Punkt p2;
	double zwipu;
	
	public Strecke(Punkt p1Punkt, Punkt p2Punkt){
		p1 = p1Punkt;
		p2 = p2Punkt;
	}
	
	public double length(){ 
		zwipu = Math.pow((p1.x - p2.x), 2) + Math.pow((p1.y - p2.y), 2);
		zwipu = Math.sqrt(zwipu);
		return zwipu;
	}
	
	
	public String toString() {
		DecimalFormat f = new DecimalFormat("#0.00");
		return "p1=" + p1.toString() + ", p2=" + p2.toString() + ", Länge: " + f.format(length());
	}
}
