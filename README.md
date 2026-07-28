# ⏱️ Desktop Timer Application (Windows Forms)

A functional, interactive **Countdown Timer** desktop application built using **C# and Windows Forms**. This project demonstrates state manipulation, time-tracking logic, and event-driven control through C#'s native `System.Windows.Forms.Timer`.

---

## 🚀 Features

*   **Custom Time Input:** Accepts precise user inputs for Hours, Minutes, and Seconds via Masked Text Boxes.
*   **Real-Time Countdown:** Dynamically updates the display second-by-second using the `Timer.Tick` event.
*   **Complete Lifecycle Controls:**
    *   **Start:** Reads input values and initiates countdown.
    *   **Pause / Stop:** Freezes time progression instantly without clearing the values.
    *   **Continue:** Resumes countdown seamlessly from the paused state.
    *   **Reset:** Halts active timers and resets all input fields back to `00`.
*   **Auto-Formatting:** Features dynamic zero-padding (`Prefix = '0'`) to ensure a clean `00:00:00` visual format throughout execution.

---

## 🛠️ Tools & Technologies Used

*   **Language:** C# (C-Sharp)
*   **Framework:** .NET Framework / Windows Forms
*   **Component:** `System.Windows.Forms.Timer`
*   **IDE:** Visual Studio

---

## 📂 Code Organization & Logic Flow

The architecture in `Form1.cs` is divided into clear modular responsibilities:

### 1. Time-Cascading Logic (`SetTimer`)
Handles the mathematical conversion across hours, minutes, and seconds when a boundary is reached:
*   When `Seconds` reach `0`, it borrows `1` from `Minutes` and sets `Seconds` to `60`.
*   When `Minutes` reach `0`, it borrows `1` from `Hours` and sets `Minutes` to `59`.
*   Automatically disables the timer when `Hours == 0 && Minutes == 0 && Seconds == 0`.

### 2. UI Formatting (`UpDateToTimer`)
Ensures standard two-digit timer output by evaluating integer lengths and applying dynamic character prefixes before updating the form text fields.

### 3. State Management Events
Clean separation between control handlers (`Start`, `Stop`, `Continue`, `Reset`) and tick events, preventing race conditions or timer overlap.

---

## 📖 How It Works

1. Enter your target **Hours**, **Minutes**, and **Seconds**.
2. Click **Start** to trigger input parsing and enable the timer ticks.
3. Use **Stop** and **Continue** to manage pauses during operation.
4. Click **Reset** to clear all counters back to zero.

---

## 💡 Learning & Development Context

> **Note:** This project is part of my active technical training curriculum. It focuses on mastering event loops, form control parsing, variable encapsulation, and boundary-condition logic handling in C#.

---

## 👨‍💻 Developer
Developed with passion by **Anwer El-Sayed** 🚀
**Email** : anwr2021alssayed@gmail.com 
