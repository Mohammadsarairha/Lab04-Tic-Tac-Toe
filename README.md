# Tic-Tac-Toe Game

## Description

A user will be able to start a game and play tic tac toe with a friend in a console window , Introductory presentation project to learn some C#. This project is a tic tac toe game as a windows console project to learn object oriented design concepts

## Create a Console project

Create a Console App project using .NET Core with either the 'dotnet' command line or the Visual Studio new project dialog.

Name the project 'Tic-Tac-Toe-Game' in a folder where you can find it later.

Run the project and ensure it builds and runs.

## Design the game model

This is a good time to figure out what the application will do and break that down into 'models' to represent the data of the application. A game might consist of the following:

### class Board

- Contain Tic Tac Toe Gameboard states.

- Also contain DisplayBoard function to display board in console.

### class Position

- Position on the gameboard being initialized.

### class Player

- Contain the name of a player and the marker placed on the board for claimed cells.

- Flag to determine if it is the user's turn.

- TakeTurn is function to start trun for current player .

- GetPosition to clam input number from user .

- PositionForNumber its function its take border place from GetPosition function and return index for this number.

### class Game

- Contain Properties for 2 Players and board and give it initial value

1. Play function

    - Play function contain the logic for the actual playing of Tic Tac Toe.

    - Give PlayerOne and PlayerTwo values "Player 1" , "Player 2" .

    - Also Marker for both player Player 1 = X and Player 2 = O.

    - Always Player 1 begin the game.

    - Tracking the board if all index is fully by X or O end the game and return Draw

    - Check if Player IsTurn to start player round.

    - Check if Player win every round, and return current player .

    - Take Next player and switch round to anouther player .

2. CheckForWinner function

    - Contain matrix have all chances in separate array inside this matrix.

    - If all rows have same Marker return win player.

### class Program

- Its contain StartGame function that creates your players and instantiates the game class.

- Its only function need to call it in your Main method.

- Determined who the winner is output the celebratory message to the correct player.

## Visualization

### Step 1 : Display boarder in console

```bash
|1||2||3|
|4||5||6|
|7||8||9|
Player 1 it is your turn
Please select a location
```

### Step 2 : Waiting player 1 to input location

```bash
1
|X||2||3|
|4||5||6|
|7||8||9|
Player 2 it is your turn
Please select a location
```

### Step 3 : Waiting player 2 to input location

```bash
7
|X||2||3|
|4||5||6|
|O||8||9|
Player 1 it is your turn
Please select a location
```

### Step 4 : player 1 turn

```bash
5
|X||2||3|
|4||X||6|
|O||8||9|
Player 2 it is your turn
Please select a location
```

### Step 5 : player 2 turn

```bash
9
|X||2||3|
|4||X||6|
|O||8||O|
Player 1 it is your turn
Please select a location
```

### Step 6 : player 1 turn

```bash
8
|X||2||3|
|4||X||6|
|O||X||O|
Player 2 it is your turn
Please select a location
```

### Step 7 : player 2 turn

```bash
3
|X||2||O|
|4||X||6|
|O||X||O|
Player 1 it is your turn
Please select a location
```

### Step 8 : player 1 turn

```bash
2
|X||X||O|
|4||X||6|
|O||X||O|
Player 1 is win
```

### Draw : for draw situations

```bash
2
|O||X||X|
|X||O||O|
|O||X||X|
Draw
```


## Conclusion

This was not a lesson on good game design, but rather how to evolve an application and OOP object model as usage requirements change.