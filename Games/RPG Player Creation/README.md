# C++ RPG: Character Creation and Battle System

Welcome to the **C++ RPG: Character Creation and Battle System** project! This is a simple console-based RPG game developed in C++ that allows users to create characters of various classes, select their race, and engage in combat. The project demonstrates the use of Object-Oriented Programming (OOP) principles like classes, inheritance, and polymorphism to simulate different player classes with unique attacks.

## Features

- **Character Creation**: Create characters of different classes such as **Warrior**, **Priest**, and **Mage**.
- **Race Selection**: Choose from five distinct races, including **Human**, **Elf**, **Dwarf**, **Troll**, and **Orc**.
- **Class-Specific Abilities**: Each character class comes with its own unique attack method.
- **Dynamic Polymorphism**: Each player class has a unique `attack()` function, showcasing polymorphism in action.
- **Simple Menu Interface**: Easy-to-use console menus for creating characters, selecting races, and displaying the player information.

## Gameplay Mechanics

1. **Character Class Options**:
    - **Warrior**: High HP, physical attack-focused with a powerful sword.
    - **Priest**: Moderate HP and MP, focuses on holy magic for combat.
    - **Mage**: Balanced HP and MP, uses arcane missiles to attack enemies.

2. **Race Selection**:
    - Choose from five available races: **Human**, **Elf**, **Dwarf**, **Troll**, and **Orc**.
    - Each race offers a unique role-playing aspect, though it doesn't directly affect the gameplay mechanics in this version of the game.

3. **Attack Mechanism**:
    - When a player is created, each class has a distinct `attack()` method.
    - The attack message will be printed to the console when the player attacks an enemy.

## Code Structure

### `Player` Class

The base class that stores common attributes such as name, race, hit points (HP), and magic points (MP). It also defines a virtual `attack()` method which is overridden in derived classes.

### Derived Classes

- **Warrior**: Inherits from `Player`, representing a warrior character with a sword attack.
- **Priest**: Inherits from `Player`, representing a priest character who uses holy wrath in combat.
- **Mage**: Inherits from `Player`, representing a mage character who uses arcane magic to deal damage.

### Main Menu System

The program presents a console menu where users can:
1. Select the character class they wish to create.
2. Choose the race of their character.
3. Create multiple characters and store them in a list.
4. Display information about all created characters.

### Attack System

Once the characters are created, they are stored in a list, and the program will print each character’s name, race, and their unique attack when prompted.
