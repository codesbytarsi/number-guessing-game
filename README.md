# 🔢 Number Guessing Game (C# Console App)
![C#](https://img.shields.io/badge/C%23-.NET-512BD4?style=flat&logo=csharp&logoColor=white)
![CLI](https://img.shields.io/badge/Interface-CLI-informational?style=flat)
![Status](https://img.shields.io/badge/Status-Learning_Project-success?style=flat)

A simple and interactive number guessing game built with **C#** as a console application.

The player chooses a difficulty level and tries to guess a randomly generated number within a limited number of attempts.

This project was created to practice **C# fundamentals**.

---

## 🌱 How the Game Works
1. The player selects a difficulty level:
    - 🟢 **Easy**: numbers from 1-50, 10 attempts
    - 🟡 **Normal**: numbers from 1-100, 8 attempts
    - 🔴 **Hard**: numbers from 1-200, 7 attempts
2. The game generates a random number based on the chosen difficulty.
3. The player enters guesses until:
    - The correct number is guessed ✅
    - OR the maximum number of attempts is reached ❌
4. After a few attempts, the game shows how many attempts are left.
5. At the end, the player can choose to **play again** or exit.

---

## ⚙ Features
- Difficulty selection (Easy / Normal / Hard)
- Input validation (non-numeric and out-of-range values)
- Limited number of attempts
- Attempts-left feedback during the game
- Replay option
- Clear win / lose messages

---

## 🎮 Example Gameplay

```text
Welcome to the number guessing game!

Choose a difficulty level:
1 - Easy
2 - Normal
3 - Hard
Your choice: 2

A number between 1 and 100 has been generated.
You have 8 attempts. Good luck!

Please enter your guess: 50
Your guess is too high.

Please enter your guess: 25
Your guess is too low.
⚠️ Attempts left: 6

Please enter your guess: 32
🎉 Congratulations, you won!
Attempts used: 3/8
```

---

## ▶ How to Run
1. Clone this repository
2. Open the project in Visual Studio (or any C# compatible IDE)
3. Run the project (`dotnet run`)
4. Play directly in the console

---

## 🧠 What I Learned
While building this project, I practiced and learned:
- Using loops (`while`, `do-while`)
- Input validation with `int.TryParse`
- Conditional logic (`if / else`)
- Random number generation
- Managing game state (attempts, win/lose conditions)
- Writing cleaner and more readable console applications
- Incremental development and meaningful Git commits

---

## 🚀 Possible Future Improvements
- Hot / Cold hints
- Score tracking
- Code refactoring using methods
- Menu-based interface
- Unit tests

---

👩‍💻 Created by **[Tarsila Fritz](https://github.com/codesbytarsi)**
