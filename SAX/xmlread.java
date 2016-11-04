package SAX;

import org.w3c.dom.NodeList;
import org.xml.sax.Attributes;

import java.io.File;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import org.w3c.dom.Document;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

public class xmlread {
	public static void main(String []args) {
		try {

			SAXParserFactory factory = SAXParserFactory.newInstance();
			SAXParser saxParser = factory.newSAXParser();
			DocumentBuilderFactory docFactory = DocumentBuilderFactory.newInstance();
			DocumentBuilder docBuilder = docFactory.newDocumentBuilder();
			String f= "./src/SAX/SampleXML.xml";
			Document doc = docBuilder.parse(f);
			DefaultHandler handler = new DefaultHandler() {

				boolean SAX = false;
				boolean DOM = false;
				boolean TEXT = false;
				boolean CHILD = false;

				
				public void startElement(String uri, String localName, String qName, Attributes attributes)
						throws SAXException {

					System.out.println(qName);

					if (qName.equalsIgnoreCase("SAX")) {
						SAX = true;
					}
					if (qName.equalsIgnoreCase("DOM")) {
						DOM = true;
					}

					if (qName.equalsIgnoreCase("TEXT")) {
						TEXT = true;
						
					}

					if (qName.equalsIgnoreCase("CHILD")) {
						CHILD = true;
					}

				}

				public void endElement(String uri, String localName, String qName) throws SAXException {

					System.out.println(qName);
					System.out.println(uri);

				}

				public void characters(char ch[], int start, int length) throws SAXException {

					if (SAX) {
						System.out.println(new String(ch, start, length));
						SAX = false;
					}
					if (DOM) {
						System.out.println(new String(ch, start, length));
						DOM = false;
					}
					if (TEXT) {
						System.out.println(new String(ch, start, length));
						TEXT = false;
					}

					if (CHILD) {
						System.out.println(new String(ch, start, length));
						CHILD = false;
					}

				}

			};

			saxParser.parse(f, handler);
			
			NodeList list = doc.getElementsByTagName("SAX");
			System.out.println("Total of elements : " + list.getLength());
			NodeList list2 = doc.getElementsByTagName("DOM");
			System.out.println("Total of elements : " + list2.getLength());
			NodeList list3 = doc.getElementsByTagName("Text");
			System.out.println("Total of elements : " + list3.getLength());
			NodeList list4 = doc.getElementsByTagName("CHILD");
			System.out.println("Total of elements : " + list4.getLength());

		} catch (Exception e) {
			e.printStackTrace();
		}
		

	}
}
