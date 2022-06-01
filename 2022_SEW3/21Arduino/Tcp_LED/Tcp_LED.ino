#include <SPI.h>
#include <Ethernet.h>
#include <String.h>

#define LED_PIN 5

byte mac[] = { 0x12,0x34,0x56, 0x78, 0x90, 0x03};

EthernetServer server(8888);  // 8888 --> Port

String readString(){
  // wir lesen so lange bis \n kommt
  String returnValue;
  EthernetClient client = server.available(); // wenn Daten vorhanden sind bekommen wir ein Client Objekt
  if(!client){
    return returnValue; // Wenn keine Daten da, dann liefern wir NULL zurück
  }
  Serial.println("Client connected");
  while(true){
    if(client.connected() && client.available()){; // zusätzliche "Sicherheitsabfragen"
      Serial.print("Remote IP: ");
      Serial.println(client.remoteIP());
      Serial.print("RemotePort: ");
      Serial.println(client.remotePort());
      char c = client.read();  // liefert 1 char
      if(c == '\n'){
        // Ende der Nachricht
        return returnValue;
      }
      else{
        returnValue  += c;  // gelesen Buchstaben anhängen
      }
    }
  }
  return "";  // diese Zeile sollte nie erreicht werden
}

void response(){  // wir senden OK zurück
  char response[] = "OK\r\n";
  server.print(response);
  Serial.println("Response OK");
}

void setup() {
  // put your setup code here, to run once:
  pinMode(LED_PIN, OUTPUT);
  Serial.begin(9600);
  while(!Serial){
    ;
  }
  Ethernet.init(10);
  Ethernet.begin(mac);
  
  Serial.print("IP: ");
  Serial.println(Ethernet.localIP());
  server.begin(); // Server horcht auf eingehende Verbindungen
}

void loop() {
  // put your main code here, to run repeatedly:
  String value = readString();
  if (value == "on"){
    Serial.println("LED on");
    digitalWrite(LED_PIN, HIGH);
    response();
  }
  else if (value == "off"){
    Serial.println("LED off");
    digitalWrite(LED_PIN, LOW);
    response();
  }
}
