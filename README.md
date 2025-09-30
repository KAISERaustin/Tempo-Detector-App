# WPF Dual-Mode Tempo Detector

A responsive desktop application built with C# and WPF to accurately determine the Beats Per Minute (BPM) of a song through two methods: manual user tapping and automatic audio file analysis.

---

## About The Project

This project provides a simple and effective tool for musicians, DJs, and producers to quickly find the tempo of a piece of music. It is designed with a clean, modern interface and offers two modes of operation to suit different needs.

* **Manual Tap-Tempo:** A straightforward method where the user taps a button in time with the music to calculate the BPM.
* **Automatic Audio Analysis:** An advanced feature that analyzes an audio file (MP3 or WAV) to detect its tempo automatically.

---

## Features

### Current Features
* **Manual BPM Detection:** Users can click the "Tap" button repeatedly to calculate the tempo. The BPM is calculated based on the average interval of the last several taps.

---

## Technology Stack

* **.NET**
* **C#**
* **Windows Presentation Foundation (WPF)**
* **NAudio** 

---

## Getting Started

To get a local copy up and running, follow these steps.

### Prerequisites
* .NET SDK (9.0 or later)
* Visual Studio 2022 or compatible IDE

### Installation
1.  Clone the repository:
    ```sh
    git clone [https://github.com/your-username/TempoDetector.git](https://github.com/your-username/TempoDetector.git)
    ```
2.  Open the solution file (`TempoDetector.sln`) in Visual Studio.
3.  Build the solution to restore NuGet packages.
4.  Run the project by pressing `F5` or clicking the "Start" button.
