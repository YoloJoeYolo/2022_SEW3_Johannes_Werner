// Der Benutzer soll einen Text eingeben.
// Danach, soll der Text umgedreht werden.
// Definiere dazu zuerst eine Funktion mit dem Namen ; stringLenght

#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h> 

int main() {
	// Ein Array von char mit einer Länge von 201 Zeichen deklarieren
	// Einen Text mit der Länge von max. 200 Zeichen per Console einlesen.

	char input[201];
	printf("Geben Sie eine Text ein: ");
	fgets(&input, 200, stdin);
	printf("Die Laenge ist %i", stringLength(input));

	return 0;
}

int stringLength(char text[]) {
	int length = 0;
	// wir suchen den Index von '\0'
	for (int i = 0; i < 201; i++)
	{
		if (text[i] != '\0')
		{
			length++;
		}
		else
		{
			return length;
		}
	}
	
}