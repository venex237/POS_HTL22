package XML;

import org.xml.sax.Attributes;

import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

public class xmlread {
	public static void main(String []args) {

		try {

			SAXParserFactory factory = SAXParserFactory.newInstance();
			SAXParser saxParser = factory.newSAXParser();

			DefaultHandler handler = new DefaultHandler() {

				boolean GG = false;
				boolean BG = false;
				boolean IPAddr = false;
				boolean Host = false;

				
				public void startElement(String uri, String localName, String qName, Attributes attributes)
						throws SAXException {

					System.out.println(qName);

					if (qName.equalsIgnoreCase("GoodGuys")) {
						GG = true;
					}
					if (qName.equalsIgnoreCase("BadGuys")) {
						BG = true;
					}

					if (qName.equalsIgnoreCase("IPAddress")) {
						IPAddr = true;
					}

					if (qName.equalsIgnoreCase("Hostname")) {
						Host = true;
					}

				}

				public void endElement(String uri, String localName, String qName) throws SAXException {

					System.out.println(qName);

				}

				public void characters(char ch[], int start, int length) throws SAXException {

					if (GG) {
						System.out.println(new String(ch, start, length));
						GG = false;
					}
					if (BG) {
						System.out.println(new String(ch, start, length));
						BG = false;
					}
					if (IPAddr) {
						System.out.println(new String(ch, start, length));
						IPAddr = false;
					}

					if (Host) {
						System.out.println(new String(ch, start, length));
						Host = false;
					}

				}

			};

			saxParser.parse("C:/Users/Venex237/workspace/HUEDerWoche/src/XML/GoodGuyBadGuy.xml", handler);

		} catch (Exception e) {
			e.printStackTrace();
		}

	}
}
