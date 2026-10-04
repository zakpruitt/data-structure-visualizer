# Data Structure Visualizer

## 1. Project Overview
Data Structure Visualizer is a Windows desktop application that demonstrates the behavior of common data structures through interactive graphics. It helps students and professionals understand how linked lists, stacks, queues, binary search trees, and heaps change as operations are performed, pairing visual feedback with algorithm insights.

## 2. Features
- Interactive creation and manipulation of linked lists, stacks, queues, binary search trees, and min-heaps.
- Automatic layout of graph nodes using Microsoft Automatic Graph Layout (MSAGL) for clear visualizations.
- Operation details including parameter descriptions, time complexities, and analysis for each supported method.
- Tools for saving, loading, printing, and modularizing visualizations to support study sessions and presentations.
- Built-in legend to quickly interpret node color coding across the different data structures.

## 3. Tech Stack
- C# (.NET Framework)
- Windows Forms
- Microsoft Automatic Graph Layout (MSAGL)

## 4. Getting Started
### Prerequisites
- Windows 10 or later.
- [Visual Studio](https://visualstudio.microsoft.com/) with the ".NET desktop development" workload installed.
- .NET Framework 4.7.2 or later (installed with Visual Studio by default).

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/<your-organization>/data-structure-visualizer.git
   cd data-structure-visualizer
   ```
2. Restore NuGet packages if Visual Studio does not automatically restore them:
   ```bash
   nuget restore "Data Structure Visualizer/Data Structure Visualizer.csproj"
   ```

### Configuration
- The application ships with sensible defaults and does not require custom configuration for basic use.
- Optional: adjust application settings in `App.config` if you need to change MSAGL layout parameters or default file locations.

### Run Locally
1. Open `Data Structure Visualizer.sln` in Visual Studio.
2. Set **Data Structure Visualizer** as the startup project.
3. Press `F5` or select **Debug > Start Debugging** to launch the application.

### Run Tests
- This project does not currently include automated tests. Manual validation can be performed by exercising the available operations within the application.

## 5. API Documentation
Data Structure Visualizer is a client application and does not expose a public API. Refer to the in-application help text and tooltips for usage guidance.

## 6. Project Structure
```
root
├── Data Structure Visualizer/          # Windows Forms project files
│   ├── BinarySearchTree.cs             # Binary search tree logic and visualization helpers
│   ├── LinkedList.cs                   # Linked list implementation and drawing routines
│   ├── MinHeap.cs                      # Min-heap logic and visualization helpers
│   ├── Queue.cs                        # Queue implementation
│   ├── Stack.cs                        # Stack implementation
│   ├── DataStructureForm.cs            # Main form with UI event handling
│   └── Resources/                      # Embedded resources and icons
├── packages/                           # MSAGL and other NuGet package assets
├── Data Structure Visualizer.sln       # Visual Studio solution file
└── README.md                           # Project documentation
```

## 7. Contributing
Contributions are welcome! To propose a change:
1. Fork the repository and create a feature branch.
2. Make your changes, ensuring the application builds successfully.
3. Submit a pull request with a clear description of the problem and solution.
4. If applicable, include screenshots or GIFs demonstrating UI changes.

## 8. License
This project has not yet been assigned a license. If you intend to use the code in your own project, please contact the maintainers or open an issue to discuss licensing.

## 9. Contact
For questions, suggestions, or support, please open an issue in this repository. You can also reach the maintainers via the contact information listed on their GitHub profiles.

<!-- portfolio
section: more
name: Data Structure Visualizer
year: College
summary: C# WinForms app that draws linked lists, stacks, queues, trees, and heaps.
-->
