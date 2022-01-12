#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h> // Ein- und Ausgabe (printf, scanf,...)
#include <stdlib.h> // Funktion rand, srand
#include <time.h>

void main() {
	// Es soll eine Zufallszahl im Bereich 0 bis 10 erzeugt werden. Der Benutzer darf solange Zahlen eingeben, bis er die Zufallszahl erraten hat.
	srand(time(NULL)); // Initialisierung des Zufallszahlengenerators
	int r = rand();	// Zufallszahl im Zahlenbereich -2^31 bis 2^31
	int zufallszahl = r % 11;	// Zahlen im Bereich 0 bis 10
	int input = -1;
	// Zufallszahl zw. 100 und 200
	// r % 101 + 100

	while (input != zufallszahl)
	{
		printf("Raten Sie die Zufallszahl (sie ist zwischen 0 und 10): ");
		scanf("%i", &input);
	}
	printf("Gratuliere Sie haben richtig geraten!!!");
}