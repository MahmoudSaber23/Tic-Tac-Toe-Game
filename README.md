# 🎮 Tic-Tac-Toe Game

A simple and interactive **Tic-Tac-Toe game** built with **C# Windows Forms**.

The project provides a clean graphical interface where two players can enter their names and play against each other in a classic 3×3 Tic-Tac-Toe board.

---

## ✨ Features

* 👥 **Two-Player Gameplay**

  * Enter custom names for both players.
  * Players take turns automatically.

* ❌⭕ **X / O Gameplay**

  * Player 1 plays with **X**.
  * Player 2 plays with **O**.

* 🏆 **Automatic Winner Detection**

  * Detects horizontal winning combinations.
  * Detects vertical winning combinations.
  * Detects diagonal winning combinations.

* 🤝 **Draw Detection**

  * Automatically detects when all 9 cells are occupied without a winner.

* 🎯 **Winning Combination Highlight**

  * The three winning cells are highlighted when a player wins.

* 🔄 **Restart Game**

  * Restart the current game without closing the application.

* 🚫 **Invalid Move Protection**

  * Prevents players from selecting an already occupied cell.

* 🖥️ **Graphical User Interface**

  * Built using Windows Forms.
  * Includes player information, current turn, winner status, and game controls.

---

## 🛠️ Technologies Used

| Technology               | Purpose                  |
| ------------------------ | ------------------------ |
| **C#**                   | Programming language     |
| **Windows Forms**        | Graphical User Interface |
| **.NET Framework 4.7.2** | Application framework    |
| **Visual Studio**        | Development environment  |

The project targets **.NET Framework 4.7.2** and uses `System.Windows.Forms` for the graphical interface.

---

## 🎮 How to Play

### 1. Enter Player Names

When the application starts, enter the names of:

* **Player 1**
* **Player 2**

Both names are required before starting the game.

### 2. Start the Game

Click the **Play** button to open the game board.

### 3. Take Turns

Players take turns selecting an empty cell.

* **Player 1 → X**
* **Player 2 → O**

The current player's name is displayed on the screen.

### 4. Win the Game

A player wins by placing three of their symbols in a row:

```text
X | X | X
--+---+--
O | O | ?
--+---+--
? | ? | ?
```

Winning combinations can be:

* Horizontal
* Vertical
* Diagonal

### 5. Draw

If all nine cells are occupied and neither player has three symbols in a row, the game ends in a **Draw**.

### 6. Restart

Click **Restart Game** to clear the board and start a new round.

---

## 🧠 Game Logic

The game logic is implemented in `GamePlayfrm.cs`.

The application keeps track of:

* Current player
* Number of played moves
* Game state
* Winner
* Draw state

After every move, the application checks all possible winning combinations:

```text
Rows:
1 2 3
4 5 6
7 8 9

Columns:
1 4 7
2 5 8
3 6 9

Diagonals:
1 5 9
3 5 7
```

Once a winning combination is found, the corresponding cells are highlighted and the game is marked as over.

---

## 📂 Project Structure

```text
Tic-Tac-Toe-Game/
│
├── Properties/
│   ├── Resources.resx
│   ├── Resources.Designer.cs
│   ├── Settings.settings
│   └── Settings.Designer.cs
│
├── Resources/
│   ├── X.png
│   ├── O.png
│   ├── question-mark-96.png
│   └── ...
│
├── Program.cs
│
├── Playfrm.cs
├── Playfrm.Designer.cs
├── Playfrm.resx
│
├── GamePlayfrm.cs
├── GamePlayfrm.Designer.cs
├── GamePlayfrm.resx
│
├── App.config
│
├── Tic-Tac-Toe Game.csproj
├── Tic-Tac-Toe Game.slnx
│
└── README.md
```

### Main Components

#### `Program.cs`

The application's entry point.

#### `Playfrm.cs`

Handles the initial player setup screen and validates that both player names have been entered before starting the game.

#### `GamePlayfrm.cs`

Contains the main game logic, including:

* Player turns
* Move handling
* Win detection
* Draw detection
* Game reset
* Winner display
* Winning-cell highlighting

#### `Resources/`

Contains the graphical resources used by the game, including the **X**, **O**, and question-mark images.

---

## 🚀 Getting Started

### Prerequisites

Make sure you have:

* Windows
* **Visual Studio**
* **.NET Framework 4.7.2**
* Desktop development tools for Windows Forms

### Installation

Clone the repository:

```bash
git clone https://github.com/MahmoudSaber23/Tic-Tac-Toe-Game.git
```

Navigate to the project directory:

```bash
cd Tic-Tac-Toe-Game
```

Open the solution/project in **Visual Studio**.

Then:

1. Restore/build the project.
2. Select the desired configuration (`Debug` or `Release`).
3. Press **Start ▶** or `F5`.
4. Enter both player names.
5. Start playing.

---




