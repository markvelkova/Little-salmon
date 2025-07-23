# LittleSalmon --- Developer Documentation

## Contents
1. [Introduction](#introduction)
2. [Project Structure](#project-structure)
3. [Dependencies](#dependencies)
4. [How to Run the Project](#how-to-run-the-project)
5. [Modules and Responsibilities](#modules-and-responsibilities)
    - [CustomControls/](#customcontrols)
    - [Games/](#games)
    - [LittleSalmon/](#littlesalmon)
    - [Resources/](#resources)
    - [Pet/](#pet)
    - [Stats/](#stats)
6.  [Author](#author)
---

## Introduction
**LittleSalmon** is a desktop application simulating a virtual pet similar to pou or tamagochi, developed using **C#** and **WinForms**.

---

## Project Structure
```
LittleSalmon/
├── CustomControls/      # MyButton
├── Games/               # Game logic independent on the forms components
├── LittleSalmon/        # Main application, all UserControls, helper classes (WinForms)
│   └── Resources/       # Images and icons
├── Pet/                 # Pet class with its logic
├── Stats/               # Stats class with its logic
├── .gitignore
├── LittleSalmon.sln
└── README.md
```

---

## Dependencies
- .NET 8
- System.Windows.Forms

---

## How to Run the Project
### Visual Studio
1. Open `LittleSalmon.sln` in Visual Studio.
2. Run with `Ctrl+F5`.
### Direct
1. Visit Releases on github and download zip
2. Run .exe file
---

## Modules and Responsibilities

### `CustomControls/`
Contains `MyButton.cs`, which is used everywheree in the program. In case of adding new custom controls, they should be placed in this project.

### `Games/`
Includes logic of the mini-games independent on the controls:
#### `Clicker.cs`
- function for calculating the click reward
#### `SpeedCounting.cs`
- Generates simple arithmetic equations using random operands
- Allows configurable operand count and value range
- Provides interface IEquation for different equation types - open to extenstions
- Includes SimpleEquation class to build equations and verify user answers

#### `Game_HeadsOrTails.cs`
Methods for flipping the coin and adjusting fairness:
- `FlipTheCoin()` simulates a biased or fair coin toss
- `SetRandomFairness()` assigns a random bias
- `ResetFairness()` restores a fair 50/50 coin

### `LittleSalmon/`

The main WinForms application folder containing all user controls, main forms, helper classes, and associated resources. This folder forms the core UI part of the project.
#### `Program.cs`  
  Application entry point, initializes the main form.
####  `MainForm.cs`, `MainForm.Designer.cs`, `MainForm.resx`  
  The main application form with design and localized resources.
  - **has as a static property thePet and theStats**, that is modified by `UC*`

#### `GamesUserControlParent.cs`, `GamesUserControlParent.Designer.cs`, `GamesUserControlParent.resx`  
  Class used to derive child classes of minigames, has the return event. 

#### `UCGame_*.cs`, `UCGame_*.Designer.cs`, `UCGame_*.resx`  
  UserControl components for individual mini-games:  
  - `UCGame_HeadsOrTails` 
  - `UCGame_Snake`
  - `UCGame_SpeedyCount` 
  - `UCGame_StarrySky`
  
  These use the `Game/...` classes and offers the MainForm a set of controls bounded to functions.

#### `UCIntro.cs`, `UCIntro.Designer.cs`, `UCIntro.resx`  
  The application intro screen, used to create a new game or load an old one

#### `UCMain.cs`, `UCMain.Designer.cs`, `UCMain.resx`  
  Main screen with the Pet display, used to access the other screens

#### `SerializationUnit.cs`
- wrapper for serializaion of both the pet and the stats

#### `FileHelper.cs`
`FileHelper` is an internal static class in the designed to assist with common file-related operations in the application, related to resource management and image processing.
- **`GetPathToResources(string filename)`**  
  Constructs and returns the full file path to a specified resource file located in the application's `Resources` directory.  

- **`SplitIcons(Bitmap source, int iconWidth)`**  
  Splits a horizontal strip image containing multiple icons into an array of individual icon bitmaps.  

#### `UsefulForDesign.cs`  
  Helper classes for Control handling used in different UCs. Contains tools for control centering.

---

### `Resources/`
- files either used in the application or usable for creating new icons
#### Included Files Used Directly:

| Filename                 | Description                                 |
|--------------------------|---------------------------------------------|
| `basicFish.ico`          | Program icon |              |
| `basicFishIcons.png`     | Fish icons for all states with trnsparent background. |
| `coinIcons.png`          | Coin visuals used in the HeadsOrTails game. |
| `dirtyIconTransparent.png` | Transparent variant of the dirty icon. |
| `gameIcons.png`          |Icons used instead of buttons in the game selecting with empty space for the future. |
| `starrySkyIcons.png`     | Icon set used for the Starry Sky game visuals. |

#### Files for durther development - not used directly by the program
| Filename                 | Description                                 |
|--------------------------|---------------------------------------------|
| `background.png`         | Background image, serves as the save for the default background colour. |
| `basicFish.png`          | Basic fish picture.                |
| `basicFishSeries.png`    | Fish icons for all states without trnsparent background. |
| `dirtyIcon.png`          | Dirty state icon (little sad poo). |


### `Pet/`
apart from followinf includes sample data files to chceck if loading works correctly (`arnold.json`, `jonas.json`) - not used by the program
#### `Pet.cs`
- Handles pet logic 
- gives API for feeding, sleeping etc.

#### `PetExceptions.cs`
- special exceptions used for ruined deserialization

### `Stats/`
Handles tracking of all player gameplay statistics.

#### `Stats.cs`
- Stores stats in a `Dictionary<string, int>` (e.g., “Food units fed”, “Snake record”)
- Groups SpeedyCount stats by difficulty (easy/medium/hard/insane)
- Provides methods to:
  - Update stats dynamically (`AdjustStat`)
  - Get stats by name (`GetStat`)
  - Compose complex stat keys (`GetSpeedyStatName`)
  - Reset all stats to defaults (`SetAllDefault`)
  - Load stats from a JSON string (`DeserializeFromJson`)
---

## Author
- **Markéta Velková**

---
