 RecipeManager Class: This class is responsible for managing the recipe. It stores ingredients, steps, and the scale factor for the recipe.
AddIngredient method: Adds an ingredient with its name, quantity, and unit to the list.
AddStep method: Adds a cooking step to the list.
ScaleRecipe method: Scales all ingredient quantities by a given factor.
ResetScale method: Resets the scale factor to 1, which is the original recipe scale.
ClearRecipe method: Clears all ingredients and steps, effectively resetting the recipe.
DisplayRecipe method: Prints out the recipe to the console, including scaled ingredient quantities and steps.
Program Class: This is the entry point of the application.
Main method: Creates an instance of RecipeManager, adds an example ingredient and step, displays the recipe, scales it, displays it again, resets the scale, and finally clears the recipe.
Compile and Run Instructions:
Install Visual Studio: Ensure you have Visual Studio installed on your computer with the .NET desktop development workload.
Create a Console App Project:
Open Visual Studio.
Select “Create a new project”.
Choose “Console App” from the list of templates.
Name your project and select a location for it.
Click “Create”.
Add the Code:
Copy the provided C# code.
Paste it into the Program.cs file in your new project.
Compile the Application:
Press Ctrl + Shift + B to build the project, or
Go to the “Build” menu and select “Build Solution”.
Run the Application:
Press F5 to run the application with debugging, or
Press Ctrl + F5 to run the application without debugging.
Interact with the Application:
The console will prompt you to enter details as per the methods you call in the Main function.
Follow the prompts to add ingredients, steps, and to scale the recipe as needed.
Commit to GitHub:
Save your changes.
Use Git to commit your changes with descriptive messages.
