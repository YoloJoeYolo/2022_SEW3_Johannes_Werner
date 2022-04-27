#include <SPI.h>  // Zur Kommunikation von Arduino mit Ethernet-Shield
#include <Ethernet.h>

byte mac[] = { 0x12,0x34,0x56, 0x78, 0x90, 0x03};
IPAddress dnsServer(172, 16, 230, 10);
IPAddress gateway(172, 16, 221, 254);
IPAddress subnet(255, 255 ,255, 0);
IPAddress ip(172, 16, 221, 103);

void setup() {
  Serial.begin(9600);
  // put your setup code here, to run once:
  Ethernet.begin(mac, ip, dnsServer, gateway, subnet);
  Serial.print("IP: ");
  Serial.println(Ethernet.localIP());
}

void loop() {
  // put your main code here, to run repeatedly:

}
