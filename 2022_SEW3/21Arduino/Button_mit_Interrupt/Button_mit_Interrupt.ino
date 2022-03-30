/*
  Button

  Turns on and off a light emitting diode(LED) connected to digital pin 13,
  when pressing a pushbutton attached to pin 2.

  The circuit:
  - LED attached from pin 13 to ground through 220 ohm resistor
  - pushbutton attached to pin 2 from +5V
  - 10K resistor attached to pin 2 from ground

  - Note: on most Arduinos there is already an LED on the board
    attached to pin 13.

  created 2005
  by DojoDave <http://www.0j0.org>
  modified 30 Aug 2011
  by Tom Igoe

  This example code is in the public domain.

  https://www.arduino.cc/en/Tutorial/BuiltInExamples/Button
*/

// constants won't change. They're used here to set pin numbers:
const int buttonPin = 2;     // the number of the pushbutton pin
const int ledPin =  13;      // the number of the LED pin

// variables will change:
volatile int buttonState = 0;         // variable for reading the pushbutton status
// volatile teilt dem Compiler mit, dass sich diese Variable ändern kann. <------------------------------------- WICHTIG!!!

void setup() {
  // initialize the LED pin as an output:
  pinMode(ledPin, OUTPUT);
  // initialize the pushbutton pin as an input:
  pinMode(buttonPin, INPUT);

  attachInterrupt(digitalPinToInterrupt(buttonPin), pin_ISR, CHANGE); // bei einem Interrupt (CHANGE: wenn sich Wert ändert) wird pin_ISR aufgerufen
}

void loop() { 
  // vorerst nichts zu tun, für "andere" Sachen reserviert.
}

void pin_ISR(){
  // Code der bei einem Interrupt ausgeführt wird
  buttonState = digitalRead(buttonPin);
  digitalWrite(ledPin, buttonState);
}
