# WPF Dual-Mode Tempo Detector

A responsive desktop application built with C# and WPF to accurately determine the Beats Per Minute (BPM) of a song through two methods: manual user tapping and automatic audio file analysis.

![Tempo Detector UI Screenshot](https://i.imgur.com/uR0u4iL.png)

---

## About The Project

This project provides a simple and effective tool for musicians, DJs, and producers to quickly find the tempo of a piece of music. It is designed with a clean, modern interface and offers two modes of operation to suit different needs.

* **Manual Tap-Tempo:** A straightforward method where the user taps a button in time with the music to calculate the BPM.
* **Automatic Audio Analysis:** An advanced feature that analyzes an audio file (MP3 or WAV) to detect its tempo automatically.

---

## Features

### Current Features
* [cite_start]**Manual BPM Detection:** Users can click the "Tap" button repeatedly to calculate the tempo[cite: 4, 5]. The BPM is calculated based on the average interval of the last several taps.

### Planned Features
* **Reset Button:** A button to clear the current manual tap calculation and start over.
* **Audio File Analysis:** A feature to select an MP3 or WAV file and have the application automatically determine its BPM.
* **Advanced Analysis Algorithm:**
    1.  **Onset Detection:** Use a spectral flux algorithm to identify potential beat timestamps.
    2.  **Pattern Analysis:** Use autocorrelation on the onset signal to find the most periodic pattern and derive the final BPM.
* **Responsive UI:** A two-column layout that scales gracefully as the window is resized, with dedicated areas for both manual and automatic detection.

---

## Technology Stack

* [cite_start]**.NET** [cite: 3]
* **C#**
* [cite_start]**Windows Presentation Foundation (WPF)** [cite: 3]
* **NAudio** (for audio processing)

---

## Getting Started

To get a local copy up and running, follow these steps.

### Prerequisites
* [cite_start].NET SDK (9.0 or later) [cite: 3]
* Visual Studio 2022 or compatible IDE

### Installation
1.  Clone the repository:
    ```sh
    git clone [https://github.com/your-username/TempoDetector.git](https://github.com/your-username/TempoDetector.git)
    ```
2.  Open the solution file (`TempoDetector.sln`) in Visual Studio.
3.  Build the solution to restore NuGet packages.
4.  Run the project by pressing `F5` or clicking the "Start" button.
