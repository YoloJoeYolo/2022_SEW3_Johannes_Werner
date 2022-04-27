#include <SPI.h>
#include <Ethernet.h>

byte mac[] = { 0x12,0x34,0x56, 0x78, 0x90, 0x03};

void setup() {
  Serial.begin(19200);
  // put your setup code here, to run once:
  Ethernet.init(10);  // 10 = CS PIN
  Serial.println("Initialize Ethernet with DHCP");
  if(Ethernet.begin(mac) == 0){
    // Fehler!!!
    if(Ethernet.hardwareStatus() == EthernetNoHardware){
      Serial.println("Ethernet Shield nicht vorhanden");
    }
    else if (Ethernet.linkStatus() == LinkOFF){
      Serial.println("Ethernet Kabel nicht verbunden");
    }
    while(true){
      // gute Idee? keine bessere Lösung aktuell
      delay(1);
    }
  }
  Serial.print("IP: ");
  Serial.println(Ethernet.localIP());

}

void loop() {
  // put your main code here, to run repeatedly:

}
