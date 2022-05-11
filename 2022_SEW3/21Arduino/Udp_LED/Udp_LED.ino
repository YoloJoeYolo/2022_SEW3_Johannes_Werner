#include <Ethernet.h>
#include <EthernetUdp.h>
#include <String.h>

#define LED 5
byte mac[] = { 0x12,0x34,0x56, 0x78, 0x90, 0x03};

unsigned int localPort = 8888;  // Port zum horchen auf eingehenden Nachrichten

EthernetUDP Udp;  // Ein Objekt vom Datentyp EthernetUDP
char packetBuffer[UDP_TX_PACKET_MAX_SIZE];    //Buffer für die eingehenden Pakete 

void setup() {
  // put your setup code here, to run once:
  Ethernet.init(10);
  Ethernet.begin(mac);  // IP. Gateway, Subnet, DNS vom DHCP
  Serial.begin(9600);
  while(!Serial){
    // warten bis der serielle Kommunikationspartner verfügbar
    
  }

  // Fehlerbehandlung
  if(Ethernet.hardwareStatus() == EthernetNoHardware){
    Serial.println("Kein Ethernet Shield vorhanden");
    while (true){
      delay(100); // ohne Ethernet Shield, machen wir nichts
    }
  }
  if(Ethernet.linkStatus() == LinkOFF){
    Serial.println("Kein Ethernet Kabel verbunden");
  }
  Serial.print("IP: ");
  Serial.println(Ethernet.localIP());

  Udp.begin(localPort);   // wir horchen auf unseren Port auf UDP-Pakete 
}

void loop() {
  // put your main code here, to run repeatedly:
  int packetSize = Udp.parsePacket();   // Anzahl der bytes die für mich bereitstehen
  if(packetSize > 0){
    Serial.print("Packet empfangen. Groeße: ");
    Serial.println(packetSize);
    Serial.print("From: ");
    IPAddress remote = Udp.remoteIP();
    for(int i = 0; i < 4; i++){
      Serial.print(remote[i], DEC);     //umwandeln in Dezimalzahlen 
      if(i<3){
        Serial.print(".");
      }
    }
    Serial.print(" Port: ");
    Serial.println(Udp.remotePort());

    //lesen der Daten (payload)
    int read = Udp.read(packetBuffer, UDP_TX_PACKET_MAX_SIZE);  // read: wieviele bytes wurden gelesen 
    packetBuffer[read] = '\0';          // \0 dranhängen, damit wir en println machen können
    Serial.println("Connect: ");
    Serial.println(packetBuffer);  

    String result = String(packetBuffer);
    // hier mein Code um die LED ein oder auszuschalten
    if(result == "on"){
       digitalWrite(LED, HIGH);
    }
    else if(result == "off"){
      digitalWrite(LED, LOW);
    }

    Udp.beginPacket(Udp.remoteIP(), Udp.remotePort());
    char replyBuffer[] = "03ACK";
    Udp.write(replyBuffer);
    Udp.endPacket();
  }  
}
