#include<iostream>
#include<map>
#include<string>
using namespace std;

class Dictionary {
private:
	map<string, string> Dictionary;

public:
	void setWordDefinition(string word,string definition) {
		// setting up the new user entered definition for the entered or specified
		// word

		auto iter = Dictionary.find(word);
		if (iter != Dictionary.end()) {
			iter->second = definition;
		}
		// if there exists no word that the user wants to modify the value of--
		else {
			Dictionary[word] = definition;
		}
	}
	void getDefination(string word) {
		// get the definition for the word the user asked for.
		auto iter = Dictionary.find(word);
		if (iter != Dictionary.end()) {
			cout << iter->second << endl;
		}
		else {
			cout << "Not Found!" << endl;
		}

	}

	void printAll() {
		// print all the words, current dictionary is containing.
		// using syntactic sugar or iterator loop for printing the keys and values
		for (auto i : Dictionary) {
			cout << i.first << " : " << i.second << endl;
		}
	}

};

void UIMenu(Dictionary& MyDictionary);
void AddWord(Dictionary& MyDictionary);
void SearchforaWord(Dictionary& MyDictionary);

int main() {
	Dictionary MyDictionary;
	int choice;
	UIMenu(MyDictionary);
	cin >> choice;
	cin.get();
	while (choice != 0) {
		switch (choice) {
		case 1:
			SearchforaWord(MyDictionary);
			break;
		case 2:
			AddWord(MyDictionary);
			break;
		case 3:
			MyDictionary.printAll();
			break;
		}
		cout << endl;
		UIMenu(MyDictionary);
		cin >> choice;
		cin.get();
	}

	return 0;
}

void UIMenu(Dictionary& MyDictionary)
{
	// printing the main Ui menu for the Dictionary Term Project
	cout << "\t\t" << "Welcome to Dictionary!"
		<< endl;
	cout << "1.Search for a word." << endl;
	cout << "2.Modify the definition for a word." << endl;
	cout << "3.Print all the words" << endl;
}

void SearchforaWord(Dictionary& MyDictionary) {
	string word;
	cout << "Enter the word, you want to know the definition of" << endl;
	getline(cin, word);
	// calling the getDefinition function for our MyDictionary instance of class Dictionary
	MyDictionary.getDefination(word);
}

void AddWord(Dictionary& MyDictionary) {
	string word;
	string definition;
	cout << "Enter the word." << endl;
	getline(cin, word);
	cout << "Enter the Definition" << endl;
	getline(cin, definition);
	MyDictionary.setWordDefinition(word, definition);
}




