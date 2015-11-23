using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

	public float UpgradePercent;
	public MyEnumeratedType option;
	public UnityEngine.UI.Text UpgradeInfo;
	public string UpgradeName;
	public int WoodUpgradeCost;
	public int FoodUpgradeCost;
	public string Upgradeinformation;





	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		UpgradeInfo.text = UpgradeName + "\nCost: " + FoodUpgradeCost + " Food" + WoodUpgradeCost + " Wood" + "\nInfo:" + Upgradeinformation;

	}
	// declare the enum somewhere visible
	public enum MyEnumeratedType {
		Hunter, Lumberjack, 
	}


		
		
	}



