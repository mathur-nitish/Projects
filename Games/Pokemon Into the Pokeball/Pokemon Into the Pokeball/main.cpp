#include<iostream>
#include<cstdlib>
#include<time.h>
#include<string>
#include<vector>
using namespace std;

enum PokeTYPE { FIRE,WATER,THUNDER,ROCK };
int defaultPokeBalls = 5;
double giveDamage;


class Pokemon {
public:
	Pokemon(string PokeName, int TYPE_num,double HP) {
		this->name = PokeName;
		this->TYPE = getTYPE(TYPE_num);
		this->HP = HP;
		this->HP_Capacity = HP;
	}
	PokeTYPE getTYPE(int num) {
		switch (num) {
		case 1:
			return FIRE;
			break;
		case 2:
			return WATER;
			break;
		case 3:
			return THUNDER;
			break;
		case 4:
			return ROCK;
			break;
		}
	}
	virtual double attack(int damage) {
		return damage;
	}
	void receiveDamage(double Damage) {
		HP -= Damage;
	}
	virtual void printAttackList() {

	}
	string getname() const {
		return name;
	}
	double gethealth() {
		return HP;
	}
	void resetHealth() {
		this->HP = HP_Capacity;
	}
	virtual int selectAttack(int input) {
		return input;
	}
private:
	string name;
	PokeTYPE TYPE;
	double HP;
	double damage;
	double HP_Capacity;
};

class Pikachu : public Pokemon {
public:
	Pikachu(string name,int TYPE_num,double HP) : Pokemon("Pikachu", 3, 200) {
	}
	void printAttackList() {
		cout << "\n\t1:ThunderClap";
		cout << "\n\t2:ThunderShock";
	}
	int selectAttack(int input) {
		return attack(input);
	}
	double attack(int Damage_num) {
		if (Damage_num == 1) {
			cout << "Pikaachuuuu!" << endl;
			return 30;
		}
		else if (Damage_num == 2) {
			cout << "Pikaaaaachuuuuuuuuu!" << endl;
			return 68;
		}
	}
	
};

class Bulbasaur : public Pokemon {
public:
	Bulbasaur(string name,int n,int hp) : Pokemon("Bulbasaur", 2, 150) {
	}

	void printAttackList() {
		cout << "\n\t1:Vine Whip";
		cout << "\n\t2:Razor Leaf";
	}
	int selectAttack(int input) {
		return attack(input);
	}
	double attack(int Damage_num) {
		if (Damage_num == 1) {
			//cout << "Bulbsaur!" << endl;
			return 67;
		}
		else if (Damage_num == 2) {
			//cout << "Pikaaaaachuuuuuuuuu!" << endl;
			return 28;
		}
	}
};

class Charmander : public Pokemon {
public:
	Charmander(string name,int n,int hp) : Pokemon("Charmander", 1, 120) {
	}
	void printAttackList() {
		cout << "\n\t1:Flamethrower";
		cout << "\n\t2:Flame Charge";
	}
	int selectAttack(int input) {
		return attack(input);
	}


	double attack(int Damage_num) {
		if (Damage_num == 1) {
			cout << "Flameeeeee!" << endl;
			return 30;
		}
		else if (Damage_num == 2) {
			cout << "Woooooh!" << endl;
			return 68;
		}
	}
};

class Squirtle : public Pokemon {
public:
	Squirtle(string name, int n, int hp) : Pokemon("Squirtle", 1, 145) {
	}
	void printAttackList() {
		cout << "\n\t1:Water Gun";
		cout << "\n\t2:Tackle";
	}
	int selectAttack(int input) {
		return attack(input);
	}
	double attack(int Damage_num) {
		if (Damage_num == 1) {
			//cout << "Pikaachuuuu!" << endl;
			return 30;
		}
		else if (Damage_num == 2) {
			//cout << "Pikaaaaachuuuuuuuuu!" << endl;
			return 48;
		}
	}
};

class Eevee : public Pokemon {
public:
	Eevee(string name, int n, int hp) : Pokemon("Eevee", 1, 145) {
	}
	void printAttackList() {
		cout << "\n\t1:Dark";
		cout << "\n\t2:Shift";
	}
	int selectAttack(int input) {
		return attack(input);
	}
	double attack(int Damage_num) {
		if (Damage_num == 1) {
			//cout << "....." << endl;
			return 22;
		}
		else if (Damage_num == 2) {
			//cout << "Aqua Taillllll!" << endl;
			return 78;
		}
	}
};

class Pidgey : public Pokemon {
public:
	Pidgey(string name, int n, int hp) : Pokemon("Pidgey", 1, 145) {
	}
	void printAttackList() {
		cout << "\n\t1:Gust";
		cout << "\n\t2:Tackle";
	}
	int selectAttack(int input) {
		return attack(input);
	}


	double attack(int Damage_num) {
		if (Damage_num == 1) {
			return 52;
		}
		else if (Damage_num == 2) {
			return 68;
		}
	}
};

class Butterfree : public Pokemon {
public:
	Butterfree(string name, int n, int hp) : Pokemon("Butterfree", 1, 145) {
	}
	void printAttackList() {
		cout << "\n\t1 : Gust";
		cout << "\n\t2 : Stun Spore";
	}
	int selectAttack(int input) {
		return attack(input);
	}

	double attack(int Damage_num) {
		if (Damage_num == 1) {
			return 79;
		}
		else if (Damage_num == 2) {
			return 15;
		}
	}
};


class Player {
public:
	Player(string name, int numOfPokeBalls, Pokemon* currentPokemon) {
		this->playerName = name;
		this->numOfPokeBalls = numOfPokeBalls;
		this->CurrentPokemon = currentPokemon;
		updatePokemonList(currentPokemon);
	}
	vector<Pokemon*>list;
	void updatePokemonList(Pokemon* p) {
		if (list.size() < 3) {
			list.push_back(p);
		}
		else {
			cout << "Maximum Pokemon Limit Reached!" << endl;
		}
	}
	void Check_Update_NumOfPokeBalls() {
		if (numOfPokeBalls >= 0) {
			numOfPokeBalls--;
		}
		else {
			cout << "No more Pokeballs left!";
		}
	}
	string getname() const {
		return playerName;
	}
	void setNumOfPokeBalls(int n) {
		this->numOfPokeBalls += n;
	}
	int getNumOfPokeballs()  {
		return numOfPokeBalls;
	}
private:
	string playerName;
	int numOfPokeBalls;
	Pokemon* CurrentPokemon;
};

// Function Declaration
void printAll(vector<Pokemon*> playerList);
Player* createPlayer(string name, int numofPokeballs, Pokemon* currentPokemon);
Pokemon* WildPokemonGenerator();
void chooseYourPokemon(Player* temp, Pokemon* wildPokemon);
void startBattle(Player* Player, Pokemon* Player_Pokemon, Pokemon* wild_pokemon);
Pokemon* chooseFirstPokemon();
void FirstPokemonDisplay();
int takeDecision();
void gameplay();
string printMainMenu();
bool throwpokeball(Player* P, Pokemon* wild_pokemon);


int main() {
	string player_Name = printMainMenu();

	Player* temp = createPlayer(player_Name, defaultPokeBalls, chooseFirstPokemon());
	gameplay();
	int choice;
	cin >> choice;
	cin.get();
	while (choice != 3) {
		if (choice == 1) {
			Pokemon* isWild = WildPokemonGenerator();
			if (isWild) {
				int dec = takeDecision();
				if (dec == 1) {
					chooseYourPokemon(temp,isWild);
				}
			}
		}
		else if(choice==2) {
			cout << "Welcome to shop!" << endl;
			cout << "\tHow many Pokeballs do you want?" << endl;
			int numOfPoke;
			cin >> numOfPoke;
			temp->setNumOfPokeBalls(numOfPoke);
		}

		// Prompting What to do next?
		gameplay();
		cin >> choice;
		cin.get();
	}
	cout << "\t\tYour Information" << endl;
	cout << "Name : " << temp->getname() << endl;
	cout << "Pokemons : " << endl;
	printAll(temp->list);
	cout << "Total number of PokeBalls left : ";
	cout << temp->getNumOfPokeballs() << endl;


	system("pause");
	return 0;
}

Player* createPlayer(string name, int numofPokeballs, Pokemon* currentPokemon) {
	Player* temp = new Player(name, numofPokeballs, currentPokemon);
	return temp;
}

Pokemon* chooseFirstPokemon() {
	cout << "\nWhich of the following Pokemon do want to have with your"
		<< "Journey?" << endl;
	FirstPokemonDisplay();
	int choice;
	cin >> choice;
	cin.get();
	if (choice == 1) {
		Pokemon* p = new Pikachu("Pickahu",3,200);
		return p;
	}
	else if (choice == 2) {
		Pokemon* p = new Bulbasaur("Bulbasuar",2,150);
		return p;
	}
	else if (choice == 3) {
		Pokemon* p = new Charmander("Charmander",1,120);
		return p;
	}
	else {
		cout << "Invalid Option!" << endl;
		chooseFirstPokemon();
	}

}

void FirstPokemonDisplay() {
	cout << "\t 1 : For Pikachu!" << endl;;
	cout << "\t 2 : For Bulbasaur!" << endl;
	cout << "\t 3 : For Charmander!" << endl;
}

void gameplay() {
	cout << "\n 1 : To Walk Around!";
	cout << "\n 2 : Go to Shop";
	cout << "\n 3 : Exit" << endl;;
}

Pokemon* WildPokemonGenerator() {
	int range = 3;
	int index = rand() % range;
	if (index == 0) {
		cout << "No encounter with Pokemon!" << endl;
		return NULL;
	}
	else{
		int random = rand() % 7;
		Pokemon* wild[4] = { new Squirtle("Squirtle",1,150), new Eevee("Eevee",3,120), new Butterfree("Butterfree",1,90),
			new Pidgey("Pidgey",3,110)};
		/*Pokemon* wildPokemon = new Pokemon(names[random], rand() % range, (rand() % 5) * 20);*/
		int n = rand() % 4;
		Pokemon* wildPokemon = wild[n];
		cout << "You have encountered a Unkown Pokemon!" << endl;
		return wildPokemon;
	}

}

int takeDecision() {
	cout << "\t1 : To Battle!" << endl;
	cout << "\t2 : To Walk Away!" << endl;

	int decision;
	cin >> decision;
	cin.get();
	if (decision == 1) {
		return decision;
	}
	else if (decision == 2) {
		return decision;
	}
}

void chooseYourPokemon(Player* temp, Pokemon* wildPokemon) {	//to be invoked by main
	cout << "Choose Your Pokemon!" << endl;
	printAll(temp->list);
	int choice;
	cin >> choice;
	cin.get();
	if (choice == 1) {
		startBattle(temp, temp->list[0], wildPokemon);
	}
	else if (choice == 2) {
		startBattle(temp, temp->list[1], wildPokemon);
	}
	else if (choice == 3) {
		startBattle(temp, temp->list[2], wildPokemon);
	}
}

void startBattle(Player* Player, Pokemon* Player_Pokemon, Pokemon* wild_pokemon) {
	cout << "\t\tBattle Begins!" << endl;
	bool gotPokemon = false;
	while (Player_Pokemon->gethealth() > 0 || wild_pokemon->gethealth() > 0 || !gotPokemon) {
		cout << "\t" << Player_Pokemon->getname()
			<< "\t\t\t" << wild_pokemon->getname()
			<< endl << "\tHP : " << Player_Pokemon->gethealth() << "\t\tHP : " << wild_pokemon->gethealth()
			<< endl;
		cout << "\tAttacks Available : " << endl
			<< "";
		Player_Pokemon->printAttackList();
		cout << endl;
		int input;
		cin >> input;
		cin.get();
		double wild_Health = wild_pokemon->gethealth();
		double Player_Pokemon_damage = Player_Pokemon->selectAttack(input);
		if (wild_Health > 0) {
			wild_pokemon->receiveDamage(Player_Pokemon_damage);
			if (wild_pokemon->gethealth() > 0) {
				Player_Pokemon->receiveDamage(wild_pokemon->selectAttack(rand() % 1));
				if (Player_Pokemon->gethealth() <= 0) {
					cout << "\t" << Player_Pokemon->getname()
						<< "\t\t" << wild_pokemon->getname()
						<< endl << "\tHP : " << 0 << "\t\tHP : " << wild_pokemon->gethealth()
						<< endl;
					cout << "You have lost the fight!" << endl;
					break;
				}
			}
			else {
				cout << "You have completely Defeated pokemon!" << endl;
				break;
			}
			cout << "\t" << Player_Pokemon->getname()
				<< "\t\t" << wild_pokemon->getname()
				<< endl << "\tHP : " << Player_Pokemon->gethealth() << "\t\tHP : " << wild_pokemon->gethealth()
				<< endl;

			cout << "Do you want to Throw Pokeball?" << endl;
			cout << "\t1 : Throw Pokeball" << endl;
			cout << "\t2 : Continue" << endl;
			int n;
			cin >> n;
			if (n == 1) {
				gotPokemon = throwpokeball(Player, wild_pokemon);
				if (gotPokemon) {
					break;
				}
			}
			else if (n == 2) {
				continue;
			}
		}
		else {
			cout << "You have completely Defeated pokemon!" << endl;
			break;
		}
	}

	//cout << "Congratulations! You have caught a Pokemon!" << endl;
	Player_Pokemon->resetHealth();
	wild_pokemon->resetHealth();

}

bool throwpokeball(Player* P, Pokemon* wild_pokemon) {
	if (P->list.size() != 3) {
		P->Check_Update_NumOfPokeBalls();
		if (wild_pokemon->gethealth() <= 25) {
			cout << "Pokemon Caught!" << endl;
			P->updatePokemonList(wild_pokemon);
			return true;
		}
		else {
			cout << "Pokemon break free!" << endl;
			return false;
		}
	}
	return false;
}

string printMainMenu() {
	cout << "\t\tWelcome to Pokemon:Into the Pokeball!" << endl;
	cout << "\nEnter your name!" << endl;
	string name;
	getline(cin, name);
	return name;
}

void printAll(vector<Pokemon*> playerList) {
	for (Pokemon* player : playerList) {
		cout << "\t"<<player->getname() << endl;
	}
}
