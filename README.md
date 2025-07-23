# Term Project for NPRG035 and NPRG038: **Little Salmon - Virtual Pet**

The project is based on a concept similar to *Pou* or *Tamagotchi*, where the player performs actions that affect the state of their virtual pet and tries to keep it alive for as long as possible.

## Player Interaction Flow
After launching the application, the player reaches the intro menu and can:
- Start a new game
- Continue a previous game (loaded from a specific file format via JSON deserialization)

Both leads to the main screen when the player sees the state of the pet and can choose from various actions (further).

Closing the window results in the program offering to save the progress, the saved file is in the correct format for loading again.

## Pet's State
### displayed as a bar
- Hunger (more accuratelly stomach fullness, as 100% means 0 hunger, further as fullness) - 0 results in death
- Mood - 0 results in death
- Energy - 0 results in death
### displayed as an icon
- Dirtyness - Mood bonus when clicked

## Possible actions on the main screen
- **Feeding** – increases fullness; overfeeding decreases mood  
- **Sleeping** – increases energy; decreases fullness and mood if the pet sleeps beyond 100%
- **Cleaning** – improves mood  
- **Playing mini-games** – decreases energy and hunger, improves mood, and earns food units
- **View personal statistics** (e.g. game high scores, minutes slept, units of food fed)
- **Change name**
- **Change background colour**

## Mini-Games
The player can choose from several mini-games to earn food for the pet. Each game use a different reward system (based on playtime, wins, performance).
### Starry Sky
Simple clicking game, in a certain time interval the player must click as many times as possible on a picture of a starry sky. The reward for each click depends on the brightness of the clicked pixel. The pictures switch randomly. 
### Speedy Count
Game designed to train quick counting skills, in a minute the player tries to solve as many equations as possible. Before the start difficulty (specifies the range of the operands) and the number of operands can be chosen. The reward depends on both. There is no penalty for incorrect answer.
### Snake
Good old Nokia snake game with both normal and big bood, which dissappears after a few seconds. If the player is too quick, it is possible to reverse the snake and die instantly.
### Heads or Tails
Game with randomness, the player can choose either a fair coin or randomly unfair coin. It is possibble to just flip without consequences to observe or bet. Bad bet results in penalty, but it is not possible to loose more food than the pet has.


## Advanced C# Features Used
- Serialization and deserialization of saved state  
- LINQ to filter data for statistics from the games
- Delegates in event handling and async funtion for delayed display of the coin

## Tools Used
The project is based on Windows forms, with custom button design and original graphics (icons and similar).
