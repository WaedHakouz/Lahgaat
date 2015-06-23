using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class LoadSave {
	
	public static int ID;
	public static bool exist = true;
	//it's static so we can call it from anywhere
	public static void Save( int id) {
		LoadSave.ID = id;
		BinaryFormatter bf = new BinaryFormatter();
		//Application.persistentDataPath is a string, so if you wanted you can put that into debug.log if you want to know where save games are located
		FileStream file = File.Create (Application.persistentDataPath + "/ID.sv"); //you can call it anything you want
		bf.Serialize(file, LoadSave.ID);
		file.Close();
	}   
	
	public static void Load() {
		if (File.Exists (Application.persistentDataPath + "/ID.sv")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/ID.sv", FileMode.Open);
			LoadSave.ID = (int) bf.Deserialize (file);
			file.Close ();
		} 


		else {

			exist=false;
		}
	}
}