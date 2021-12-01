#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main() {
	printf("Geben Sie Ihren Vornamen und Nachnamen ein (max. 50 und 50 Zeichen): ");
	char firstName[50];	// ich reserviere Speicherplatz für 49 Zeichen + \0
	char secondName[50];
	scanf("%s %s", &firstName, &secondName); // in die Variable firstName wird der eingebenen Wert gespeichert
	printf("Hallo %s %s, ich w\x81nsche dir einen sch\x94nen Tag!", &firstName, &secondName);

	printf("\nGeben Sie Ihren Vornamen und Nachnamen ein (max. 100 Zeichen): ");
	char name[100];
	fgets(name, 100, stdin);
	printf("Hallo %s, ich w\x81nsche dir einen sch\x94nen Tag!", &name);
	return 0;
}