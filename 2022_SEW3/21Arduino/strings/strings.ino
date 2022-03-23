void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  char textA[7] = {'H', 'a', 'l', 'l', 'o', '!'};  // C
  char textB[] = "Hallo";                          // C
  String textC = "Hall";
  String textD = "o Welt";
  int value = 20;

  Serial.print("Text A: ");
  Serial.println(textA);
  // Serial.print("Text B:" + textB); --> geht NICHT!!!
  Serial.print("Text B: ");
  Serial.println(textB);
  
  Serial.print("TextC und TextD: ");  // "TextC und TextD: " ist vom Datentyp char[]
  Serial.println(textC + textD);  // erlaubt, weil vom Datentyp string
  String textE = "TextC und TextD: ";
  Serial.println(textE + textC + textD);

  Serial.print("Die Temperatur beträgt : "); Serial.println(value);
  delay(5000);
}
