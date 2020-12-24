using UnityEngine;
using System.Collections;

public class SettingsControls : MonoBehaviour {

	public GameObject menu;
                   public GameObject settings;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Настройки
	public void LowQuality()
	{
        Debug.Log("Set low quality!");
		QualitySettings.SetQualityLevel (0,true);
	}
	public void MediumQuality()
	{
        Debug.Log("Set medium quality!");
		QualitySettings.SetQualityLevel (2,true);
	}
	public void UltraQuality()
	{
        Debug.Log("Set ultra quality!");
		QualitySettings.SetQualityLevel (4,true);
	}

   public void GoMenu() 
   {
        if (settings!=null) settings.SetActive(false);
        if (menu!=null) menu.SetActive(true);
   }
}