# Monster Chase

A small 2D game made with Unity 2020.3 and C#, uploaded in April 2022. Monsters come in from both sides, and you dodge them for as long as you can.

**The game's code and assets are on the [`master`](https://github.com/UmairTalib/Monster-Chase/tree/master) branch.** This `main` branch only holds this README and the `.gitignore`.

## Gameplay

- In the main menu, you pick one of two characters.
- Every few seconds, a monster appears on the left or the right side and runs across at a random speed.
- On-screen buttons move your character left and right and make it jump.
- Your score is the number of seconds you survive. When a monster touches you, the game is over and shows your final score, and buttons let you play again or return to the menu.

## Code

The C# scripts are in [`Assets/Scripts`](https://github.com/UmairTalib/Monster-Chase/tree/master/Assets/Scripts) on the `master` branch:

| Script | What it does |
| --- | --- |
| `MainMenuController.cs`, `GameManager.cs` | Character selection. The game manager is kept across scenes and creates the chosen character when the game scene loads. |
| `MonsterSpawner.cs`, `Monster.cs` | Spawn a random monster on a random side with a random speed, and move it |
| `Left.cs`, `Right.cs`, `Up.cs` | On-screen buttons for walking and jumping |
| `Player.cs` | Tracks whether the character is on the ground, and removes it when a monster touches it |
| `ScoreLogic.cs` | Survival-time score and the game-over panel |
| `GameplayUIController.cs` | Buttons to restart and to return to the menu |
| `Follow.cs` | Camera that follows the character horizontally, within limits |
| `Collector.cs` | Removes monsters (or the character) that enter its trigger area |
| `Utils.cs` | Shared tag, scene and animation names |

## Running it

Check out the `master` branch and open the folder in Unity 2020.3.32f1, the version the project was made with (Unity Hub can install it). Start from the `Main Menu` scene in `Assets/Scenes`.
