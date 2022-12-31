# CabMaker
CabMaker is a graphical frontend for `makecab.exe` that allows the user to easily package CAB archives. This application is based on a backend of `makecab.exe` and [sapientcoder/CabMaker](https://github.com/sapientcoder/CabMaker).

## Introduction
CabMaker is a graphical frontend for makecab.exe written in C# WinForms. It allows the user to quickly and easily package CAB archives with `MSZIP`, `LZX` or `None` compression. Individual files and folders with subfolders can be imported into a checkbox list of files, and checked files are used for the creation of a Cabinet file.

## Creating CAB archives
1. Use the `Add Folder` and `Add File` buttons in the `Files` area to add files for your Cabinet into the list box below
2. Check the boxes of files you want to save to your CAB
3. Browse for the location of the `Output File`, under the `Compressor` group *(where your cab will be saved)*
4. Browse for the path of the first folder with `CAB Root Dir`, *(Optional: if your CAB will contain subfolders)*
5. Select the type of CAB compression (`None`, `MSZIP`, or `LZX`) *(LZX compression allows you to select the memory block sizes for the compression)*
6. Click `Make CAB`

## CabMaker Save Settings
CabMaker uses `IsolatedStorage` to save specific user settings within the cache, and are saved when the application is closed, and reloaded upon opening.

### Saved Settings
- `Output File` textbox
- `CAB Root DIR` textbox
- `Compression Type` dropdown
- `Compression Memory` dropdown
- `Save on Exit` checkbox

### Saving and Loading Settings
- Any saved settings are automatically loaded when the application runs
- To **enable automatic saving** when the application is closed, check the `Save on Exit` checkbox
- To **disable automatic saving** when the application is closed, uncheck the `Save on Exit` checkbox, and manually `Save Settings` from the Main Menu
- To **manually save the settings** without needing to close the application, click `Save Settings` from the Main Menu

## Screenshots

![image](CabMaker.PNG)