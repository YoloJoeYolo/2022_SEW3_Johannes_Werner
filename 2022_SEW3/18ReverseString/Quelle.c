// Der Benutzer soll einen Text eingeben.
// Danach, soll der Text umgedreht werden.
// Definiere dazu zuerst eine Funktion mit dem Namen ; stringLenght

#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h> 
#include<string.h>

int stringLength(char text[]) {
	int length = 0;
	// wir suchen den Index von '\0'
	while (text[length] != '\0')
	{
		length++;
	}
	return length - 2;	// -1 weill, länge != index und \n auch wegschneiden 
}

int stringLength2(char* text) {
	//char temp[] = text;
	int length = 0;
	while (text[length] != '\0')
	{
		length++;
	}
	return length - 2;
}

int main() {
	// Ein Array von char mit einer Länge von 201 Zeichen deklarieren
	// Einen Text mit der Länge von max. 200 Zeichen per Console einlesen.

	char input[201];
	printf("Geben Sie eine Text ein: ");
	fgets(&input, 200, stdin);
	int length = stringLength(input); 
	// int length = strlen(input) // aus string.h

	// hier den Text "umdrehen"
	
	for (int i = 0; i < length/2; i++)
	{
		char temp = input[i];
		input[i] = input[length - i];
		input[length - i] = temp;
	}

	printf("%s", input);
	return 0;
}