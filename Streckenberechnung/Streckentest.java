//Bruno Kovacevic

package Streckenberechnung;

public class Streckentest {

	public static void main(String[] args) {
		Strecke[] strecke = new Strecke[4];
		strecke[0] = new Strecke(new Punkt(3, 5), new Punkt(7, 6));
		strecke[1] = new Strecke(new Punkt(3, 6), new Punkt(8, 7));
		strecke[2] = new Strecke(new Punkt(4, 7), new Punkt(9, 7));
		strecke[3] = new Strecke(new Punkt(10, 11), new Punkt(12, 13));
		
		for(int i =0; i<strecke.length; i++)
		{
			System.out.println(strecke[i].toString());
		}
		double low = 1000000.0;
		int merken = 0;
		for (int j = 0; j < strecke.length; j++) {
			if (strecke[j].length() < low) {
				merken = j;
				low = strecke[j].length();
			}
		}
		System.out.println();
		System.out.println("Die Kuerzeste Strecke ist:");
		System.out.println(strecke[merken].toString());
	}
}

