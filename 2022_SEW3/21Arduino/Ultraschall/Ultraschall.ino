#include <HCSR04.h>
#define TRIG_PIN 12
#define ECHO_PIN 11


int i = 0;
int ausleserate;
int zeitraum;
String einheit;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  HCSR04.begin(TRIG_PIN, ECHO_PIN);

  // Der Benutzer soll festlegen:
  // - Ausleserate (Messungen pro sec)
  // - Mittelwert über welchen Zeitraum
  // - in welcher Einheit (mm, cm, m)

  // Der Client sendet "Initialize Ultraschallsensor"
  // Arduino sendet: "OK Begin Initialize"
  // Client sendet: <Ausleserate in Messungen pro sec>
  // Client sendet: <Zeitraum für die Mittelwertbildug in ms>
  // Client sendet: "m" oder "cm" oder "mm"
  // Arduino sendet: "Initialize Finished"

  int initialized = 0;
  while(initialized == 0){
   char buf[200];
    int i = 0;
    char c = '\0'; // damit wir beim nächsten Mal wieder lesen
    while(c != '\n' && i < 200){
      if(Serial.available()){  // nur lesen, wenn Daten da sind
        c = Serial.read(); // bis \n
        buf[i] = c;
        i++;
      }
    }
    buf[i-1] = '\0'; // wir überschreiben \n mit \0
    String s = String(buf);
    String init = String("Initialize Ultraschallsensor");
    if(s.compareTo(init) == 0){
      Serial.println("OK Begin Initialize");
      // Ausleserate: maximal Zeichenlänge? bis \n
      c = '\0';
      i = 0;
      while(c != '\n' && i < 200){
        if(Serial.available()){  // nur lesen, wenn Daten da sind
          c = Serial.read(); // bis \n
          buf[i] = c;
          i++;
        }
      }
      buf[i-1] = '\0'; // wir überschreiben \n mit \0
      ausleserate = atoi(buf);
      //Serial.println(ausleserate);
      
      c = '\0';
      i = 0;
      while(c != '\n' && i < 200){
        if(Serial.available()){  // nur lesen, wenn Daten da sind
          c = Serial.read(); // bis \n
          buf[i] = c;
          i++;
        }
      }
      buf[i-1] = '\0'; // wir überschreiben \n mit \0
      zeitraum = atoi(buf);
      //Serial.println(zeitraum);

      c = '\0';
      i = 0;
      while(c != '\n' && i < 200){
        if(Serial.available()){  // nur lesen, wenn Daten da sind
          c = Serial.read(); // bis \n
          buf[i] = c;
          i++;
        }
      }
      buf[i-1] = '\0'; // wir überschreiben \n mit \0
      einheit = String(buf);
      //Serial.println(einheit);

      if(ausleserate <= 1000 && ausleserate > 0 && zeitraum > 0 && (einheit == "m" || einheit == "cm" || einheit == "mm")){
        initialized = 1;
        Serial.println("Initialize Finished");
      }
    } 
  }
}

double messwerte[350]; // Groß genug, damit alles Platz hat

void loop() {
  // put your main code here, to run repeatedly:
  /*double* distances = HCSR04.measureDistanceCm(); // wir bekommen ein Array als Rückgabewert
  Serial.print(distances[0]);
  Serial.println(" cm");
  delay(2000);*/

  double* distances = HCSR04.measureDistanceCm();
  double dist = distances[0];
  messwerte[i] = dist;
  i++;
  int anzahlMessungen = zeitraum * 1000 / ausleserate;
  if(i == anzahlMessungen-1){
    // Berechnen des Mittelwertes
    double sum = 0;
    for(int j = 0; j < anzahlMessungen+1; j++){
      sum += messwerte[j];
    }
    double result = sum/ anzahlMessungen;
    if(einheit.compareTo(String("m")) == 0){
      result= result / 100;
    }
    else if(einheit.compareTo(String("m")) == 0){
      result= result *10;
    }
    // bei cm keine Umrechnung
    Serial.print("Mittelwert der letzten Sekunde: "); Serial.print(result); Serial.print(" "); Serial.println(einheit);
    i = 0;
  }
  delay(1000/ausleserate);
}

// alle 5 ms auslesen und in ein Array speichern
// alle Sekunden den gleitenden Mittelwert (der letzten Sekunde) auf die Serielle Schnittstelle schreiben.
