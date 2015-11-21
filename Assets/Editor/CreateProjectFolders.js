#pragma strict

//generate folders in our project

import System.IO;

//add menu item to generate folders w/ names
@MenuItem("Project Tools/Make Folders")
static function MakeFolders()
{
	var projectPath	: String = Application.dataPath + "/";
	
	Directory.CreateDirectory(projectPath + "Music");
	Directory.CreateDirectory(projectPath + "Prefabs");
	Directory.CreateDirectory(projectPath + "Scenes");
	Directory.CreateDirectory(projectPath + "Scripts");
	Directory.CreateDirectory(projectPath + "Sounds");
	Directory.CreateDirectory(projectPath + "Sprites");
	
	AssetDatabase.Refresh();
}