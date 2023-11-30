# FlutterFly
"Flutter Fly" is a 3D reimplementaion of the normal 2D flappy bird where you fly a bird through an enovironment trying to escape objects
while acquiring as many coins as you can. The game ends when you hit an object

## Features
- **Simulated Environment** Hand crafted 3D environment with lighting and multiple random objects that you are to avoid
- **C# scripting**: this has been used within Unity to handle game mechanics including car physics, character behaviors, environmental interactions, dynamic lighting, and core game logic, creating an interactive driving experience.
- **Game sounds** Game sounds for coins and background music
## Requirements
- Blender (for model creation and texturing)
- Unity (for deployment and physics engine)
- C# Compiler (for car logic and simulation code)

## Setup
1. **Blender Models:**
   - Open the `.blend` files in the `Assets/Models` directory to view or modify the 3D models.

2. **C# Code:**
   - Navigate to the `/Code` directory to view or edit the C# source files.
   - Compile the code using your preferred C# compiler.

3. **Unity Project:**
   - Open the Unity project from the `/Unity` directory.
   - The compiled C# code is integrated into Unity through plugins.

## How to Use
- Run the Unity project.
- Use the arrow keys to control the car within the simulation.
- Interact with the environment to explore different weather modes.

## Development
- **3D Modelling:**
  - The models are created using Blender. Refer to the `/Models` directory for all Blender assets.

- **Simulation Logic:**
  - The car's logic and physics are implemented in C#. Source files can be found in `/Code`.

- **Unity Deployment:**
  - Unity is used to piece together the models and logic and handle the rendering. Scenes and assets are located in `/Unity`.

## Contribution
- Fork the repository, create a feature branch, and submit a pull request for review.

## License
- This project is licensed under the [MIT License](LICENSE.md).


