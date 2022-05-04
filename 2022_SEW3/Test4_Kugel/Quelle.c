#define _CRT_SECURE_NO_WARNINGS
#include <time.h>
#include <stdio.h>
#define pi 3.14159
void kugel(float r, float* volumen, float* oberflaeche) {
	*oberflaeche = 4 * r * r * pi;
	*volumen = (4 / 3) * pi * r * r * r;
}

void main() {
	float r = 4.5;
	float volumen;
	float oberflaeche;
	kugel(r, &volumen, &oberflaeche);
	printf("Kugel mit Radius %f Volumen=%f, Oberflaeche=%f", r, volumen, oberflaeche);
}