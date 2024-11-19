# Low-Level Design - UML Diagram
![image](https://github.com/user-attachments/assets/464b762d-2041-4dd0-8b2f-2745e6a5c64f)


# Chess Game

This is a simple, command-line-based chess game implemented in C# that simulates a two-player game of chess. The game follows the traditional chess rules, where players take turns moving their pieces on an 8x8 board. The game includes basic functionality like piece movement validation, turn-based play, and special chess moves such as castling and pawn promotion.

## About the Game

### Objective
The primary objective of the game is to checkmate the opponent's King. The game ends when one player's King is placed under a threat of capture (check) and there is no way for the player to escape from the threat. Alternatively, the game can end in a stalemate, draw, or resignation.

### Gameplay
- **Players:** Two players take turns; one controls the white pieces, and the other controls the black pieces.
- **Board:** The game is played on a standard 8x8 chessboard. Each player begins with 16 pieces placed in the back two rows:
  - Row 1 (White): Rook, Knight, Bishop, Queen, King, Bishop, Knight, Rook
  - Row 2 (White): Eight Pawns
  - Row 7 (Black): Eight Pawns
  - Row 8 (Black): Rook, Knight, Bishop, Queen, King, Bishop, Knight, Rook
- **Pieces:** The game includes all standard chess pieces:
  - **Pawns**: Move forward one square (or two squares on their first move) and capture diagonally.
  - **Rooks**: Move horizontally or vertically any number of squares.
  - **Knights**: Move in an "L" shape, either two squares in one direction and one square perpendicular, or vice versa. Knights are the only pieces that can "jump" over other pieces.
  - **Bishops**: Move diagonally any number of squares.
  - **Queens**: Combine the movement of the Rook and Bishop, moving horizontally, vertically, or diagonally any number of squares.
  - **Kings**: Move one square in any direction. The King also has special moves like castling and pawn promotion.

### Special Moves
- **Pawn Promotion:** When a Pawn reaches the opponent’s back row, it can be promoted to any other piece (except another Pawn or King). Typically, a Pawn is promoted to a Queen.
- **Castling:** This is a special move involving the King and a Rook. The King moves two squares towards a Rook, and the Rook moves to the square next to the King. Castling can only be done if neither the King nor the Rook has moved before, and there are no pieces between them.
- **En Passant:** This special move allows a Pawn to capture another Pawn that has just moved two squares forward from its starting position, bypassing the capturing Pawn’s attacking range. The capture is performed as though the opposing Pawn had only moved one square forward.

### Turn-Based Play
- Players alternate turns, starting with White. Each player can only move one piece per turn.
- The game checks if the move made is valid for the selected piece.
- After each valid move, the board is updated and displayed.
- If a move results in a piece being captured, it is removed from the board.

### Move Validation
Each move is validated based on the type of piece selected and its allowed movement. For example:
- A **Rook** cannot move diagonally, and it cannot jump over other pieces.
- A **Knight** can "jump" over other pieces but must follow its unique "L" shape movement.

If a move is invalid, the game will reject it and ask the player to try again.

### Board Display
The game visually represents the chessboard after each turn. The board is displayed in a simple text-based format with the first letter of each piece type (e.g., `R` for Rook, `P` for Pawn, `K` for King).

### Winning the Game
The game ends when a player achieves checkmate by placing the opponent's King in a position where it cannot escape capture. A game can also end in a draw or stalemate if neither player can win, or if there are no legal moves left.

## Features

- **Basic Chess Pieces**: The game supports all standard chess pieces, each with its own movement rules.
- **Turn-Based Play**: The game alternates turns between the two players.
- **Move Validation**: The game checks if each move is valid based on the piece and position.
- **Game Display**: The chessboard is displayed after each turn.
- **Special Moves**: The game includes pawn promotion, castling, and en passant.
- **Interactive Interface**: Players input moves in the format `row col`, and the game updates after each valid move.

## How to Play

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/your-username/chess-game.git
    ```
2. **Navigate to the Project Directory:**
    ```bash
    cd chess-game
    ```
3. **Run the Game:**
    ```bash
    dotnet run
    ```
4. **Make Moves:**
    The game will ask you to input the source and target positions of the piece you want to move in the format `row col` (e.g., "1 0" for the position (1, 0)).
5. **Continue Playing:**
    The game will alternate turns between the two players, displaying the updated board after each move.

## Conclusion

This project aims to provide a basic but functional chess game that can be played through a command-line interface. It simulates all traditional chess rules, and includes special moves such as castling and pawn promotion. Players can enjoy a game of chess against each other by simply entering their moves as text.
