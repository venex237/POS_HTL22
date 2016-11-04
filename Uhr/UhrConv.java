package Uhr;

import java.text.SimpleDateFormat;
import java.util.Date;

public class UhrConv {

	private static final String Stunden[] = { "Null", "Ein", "Zwei", "Drei", "Vier", "Fuenf", "Sechs", "Sieben", "Acht",
			"Neun", "Zehn", "Elf", "Zwoelf", "Dreizehn", "Vierzehn", "Fuenfzehn", "Sechzehn", "Siebzehn", "Achtzehn",
			"Neunzehn", "Zwanzig", "Einundzwanzig", "Zweiundzwanzig", "Dreiundzwanzig", "Vierundzwanzig" };
	
	private static final String Minuten[] = { "Null", "Ein", "Zwei", "Drei", "Vier", "Fuenf", "Sechs", "Sieben", "Acht",
			"Neun", "Zehn", "Elf", "Zwoelf", "Dreizehn", "Vierzehn", "Fuenfzehn", "Sechzehn", "Siebzehn", "Achtzehn",
			"Neunzehn", "Zwanzig", "Einundzwanzig", "Zweiundzwanzig", "Dreiundzwanzig", "Vierundzwanzig",
			"Fuenfundzwanzig", "Sechsundzwanzig", "Siebenundzwanzig", "Achtundzwanzig", "Neunundzwanzig", "Dreiﬂig",
			"Einunddreiﬂig", "Zweiunddreiﬂig", "Dreiunddreiﬂig", "Vierunddreiﬂig", "Fuenfunddreiﬂig", "Sechsunddreiﬂig",
			"Siebenunddreiﬂig", "Achtunddreiﬂig", "Neununddreiﬂig", "Vierzig", "Einundvierzig", "Zweiundvierzig",
			"Dreiundvierzig", "Vierundvierzig", "Fuenfundvierzig", "Sechsundvierzig", "Siebenundvierzig",
			"Achtundvierzig", "Neunundvierzig", "Fuenfzig", "Einundfuenfzig", "Zweiundfuenfzig", "Dreiundfuenfzig",
			"Vierundfuenfzig", "Fuenfundfuenfzig", "Sechsundfuenfzig", "Siebenundfuenfzig", "Achtundfuenfzig",
			"Neunundfuenfzig", "Sechzig" };
	
	private static final String Sekunden[] = { "Null", "Ein", "Zwei", "Drei", "Vier", "Fuenf", "Sechs", "Sieben", "Acht",
			"Neun", "Zehn", "Elf", "Zwoelf", "Dreizehn", "Vierzehn", "Fuenfzehn", "Sechzehn", "Siebzehn", "Achtzehn",
			"Neunzehn", "Zwanzig", "Einundzwanzig", "Zweiundzwanzig", "Dreiundzwanzig", "Vierundzwanzig",
			"Fuenfundzwanzig", "Sechsundzwanzig", "Siebenundzwanzig", "Achtundzwanzig", "Neunundzwanzig", "Dreiﬂig",
			"Einunddreiﬂig", "Zweiunddreiﬂig", "Dreiunddreiﬂig", "Vierunddreiﬂig", "Fuenfunddreiﬂig", "Sechsunddreiﬂig",
			"Siebenunddreiﬂig", "Achtunddreiﬂig", "Neununddreiﬂig", "Vierzig", "Einundvierzig", "Zweiundvierzig",
			"Dreiundvierzig", "Vierundvierzig", "Fuenfundvierzig", "Sechsundvierzig", "Siebenundvierzig",
			"Achtundvierzig", "Neunundvierzig", "Fuenfzig", "Einundfuenfzig", "Zweiundfuenfzig", "Dreiundfuenfzig",
			"Vierundfuenfzig", "Fuenfundfuenfzig", "Sechsundfuenfzig", "Siebenundfuenfzig", "Achtundfuenfzig",
			"Neunundfuenfzig", "Sechzig" };

	public static void main(String[] args) {
		do {
			try {
				System.out.println(TimetoText(new Date()));
				Thread.sleep(10000);
			} catch (Exception e) {
				System.out.println(e.getMessage());
			}
		} while (true);
	}

	private static String TimetoText(Date time) {
		String[] dateFormat = new SimpleDateFormat("HH:mm:ss").format(new Date().getTime()).split(":");
		return Stunden[Integer.valueOf(dateFormat[0])] + " Uhr " + Minuten[Integer.valueOf(dateFormat[1])] + " und " + Sekunden[Integer.valueOf(dateFormat[2])] + " Sekunden";
	}

	

}
