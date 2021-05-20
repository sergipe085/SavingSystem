# SavingSystem
 This is an open-source saving system to Unity made in C#.

<h3> How to Use

first you need to add a GameObject and add the class "SavingSystem" to it, then add the class "SaveableEntity" to the object you want to save data to and add the interface "ISaveable" to the classes you want to save data to. Then just implement the "ISaveable" interface by returning the information you want to save in the "CaptureState ()" mathod and using that information in the "RestoreState ()" method.

