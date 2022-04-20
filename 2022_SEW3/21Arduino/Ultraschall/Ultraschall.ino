#include <HCSR04.h>
#define TRIG_PIN 12
#define ECHO_PIN 11

volatile int ausleserate;
volatile int zeitraum;
String einheit;

int readI() {
      char buf[50];
      char c='\0';    
      int i = 0;
      while(c != '\n' && i < 50) {  
        if(Serial.available()) {     // nur lesen, wenn Daten da sind
          c = Serial.read(); // bis \n
          buf[i] = c;
          i++;
        }
      }
      buf[i - 1] = '\0';    // wir überschreiben \n mit \0
      return atoi(buf);
}

String readS() {
    char buf[50];
    char c='\0';
    int i = 0;
    while(c != '\n' && i < 50) {  
      if(Serial.available()) {     // nur lesen, wenn Daten da sind
        c = Serial.read(); // bis \n
        buf[i] = c;
        i++;
      }
    }
    buf[i - 1] = '\0';    // wir überschreiben \n mit \0
    
    return String(buf);   
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  HCSR04.begin(TRIG_PIN, ECHO_PIN); 

  // Der Benutzer soll festlegen:
  // - Ausleserate(Messungen pro sec)
  // - Mittelwert über welchen Zeitraum
  // - in welcher Einheit (mm, cm, m)

  // Der Client sendet: "Initialize Ultraschallsensor"
  // Arduino sendet: "OK Begin Initialize"
  // Client sendet: <Ausleserate in Messungen pro sec>   max. 50
  // Client sendet: <Zeitraum für die Mittelwertbildung in ms> max. 200 Werte
  // Client sendet: "m" oder "cm" oder "mm"
  // Arduino sendet: "Initialize Finished"

  int initialized = 0;
  while(initialized == 0) {  
    String s = readS();
    String init = String("Initialize Ultraschallsensor");
       
    if(s.compareTo(init) == 0) {
      Serial.println("OK Begin Initialize");
      // Ausleserate: maximal Zeichenlänge? bis \n 
      ausleserate = readI();
      Serial.println(ausleserate);
      if(ausleserate > 0 && ausleserate <=50) {
        // Zeitraum      
        zeitraum = readI();
        Serial.println(zeitraum);
        if(zeitraum > 0 && (ausleserate * zeitraum/1000) <= 200) {
          // Einheit
          einheit = readS();      
          //Serial.print("Laenge:"); Serial.println(einheit.length());
          //Serial.print("Einheit: "); Serial.println(einheit);
          Serial.println(einheit);
          Serial.println("Initialize Finished");
          if(einheit.compareTo(String("mm")) || einheit.compareTo(String("cm")) || einheit.compareTo(String("m"))) {
            initialized = 1;             
          }          
        }
      }
    }
  }
}

double messwerte[200];     // Groß genug, damit alles Platz hat
int i = 0;

void loop() {  
  // put your main code here, to run repeatedly:
  double* distances = HCSR04.measureDistanceCm();    // wir bekommen ein Array als Rückgabewert  
  double dist = distances[0];
  //Serial.println(dist);
  messwerte[i] = dist;
  i++;

  int anzahlMessungen = (double)zeitraum / 1000 * ausleserate;  
  if(i == anzahlMessungen) {
    // Berechnen des Mittelwertes
    double sum = 0;
    for(int j = 0; j < anzahlMessungen; j++) {
      sum += messwerte[j];
    }

    double result = sum/anzahlMessungen;
    if(einheit.compareTo(String("m")) == 0) {
      result = result / 100;
    } else if(einheit.compareTo(String("mm")) == 0) {
      result = result * 10;
    }
    // bei cm keine Umrechnung
    
    //Serial.print("Mittelwert: "); Serial.print(sum/anzahlMessungen); Serial.println(einheit);
    Serial.println(result);
    i = 0;
  }
  delay(1000/ausleserate);        
  
  //Serial.print(dist);
  //Serial.println(" cm");
  //delay(2000);
}

// alle 5 ms auslesen und in ein Array speichern
// alle Sekunden den gleitenden Mittelwert (der letzten Sekunde) auf die serielle Schnittstelle schreiben.
