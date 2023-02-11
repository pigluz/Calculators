#ifdef _WIN32
#include <Windows.h>
#else
#include <unistd.h>
#endif
#include <iostream>
#include <cstdlib>

using namespace std;
using std::cout;

int main()
{
	string imie, nazwisko, miasto, szkola, wybor;
	char oper;
	float wiek, num1, num2, result;

	cout << "Witaj w kalkulatorze!" << endl;
	Sleep(1000);
	cout << "Najpierw zacznijmy od pytan" << endl;

	cout << "Jak sie nazywasz?" << endl;
	cin >> imie;

	cout << "Jakie masz nazwisko?" << endl;
	cin >> nazwisko;

	cout << "Ile masz lat?" << endl;
	cin >> wiek;

	cout << "Gdzie mieszkasz?" << endl;
	cin >> miasto;

	cout << "Do jakiej szkoly chodzisz?" << endl;
	cin >> szkola;

	cout << "Dobrze." << endl;
	Sleep(500);
	cout <<
		"Imie: " << imie <<
		"\nNazwisko: " << nazwisko <<
		"\nWiek: " << wiek <<
		"\nMiasto: " << miasto <<
		"\nSzkola: " << szkola << endl;

	Sleep(1000);
	cout << "Czy te dane sa poprawne?" << endl;
	cin >> wybor;

	if (wybor == "Tak") {
		cout << "Dobrze! Przejdzmy dalej." << endl;
	}
	else {
		cout << "No to pa, lol..." << endl;
		return 0;
	};

	Sleep(1000);
	cout << "Dobrze " << imie << "\nPrzejdzmy do kalkulatora!" << endl;
	
	cout << "Podaj pierwsza liczbe: ";
		cin >> num1;

	cout << "Podaj druga liczbe: ";
		cin >> num2;

	cout << "Podaj operatora: (+  -  /  *) ";
		cin >> oper;


		switch (oper) {
			case '+':
				result = num1 + num2;
				cout << "Twoj wynik to: " << result;
				break;

			case '-':
				result = num1 - num2;
				cout << "Twoj wynik to: " << result;
				break;

			case '/':
				result = num1 / num2;
				cout << "Twoj wynik to: " << result;
				break;
			case '*':

				result = num1 * num2;
				cout << "Twoj wynik to: " << result;
				break;

			default:
				cout << "Zly operator...";
				break;
		}
	return 0;
};