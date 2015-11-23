using UnityEngine;
using System.Collections;

public class Resources: MonoBehaviour {
	
	public float food = 0.00f;
	public float wood = 0.00f;
	//public float skins = 0.00f;
	public float worker = 0f;
	public int LumberjackCount = 0;
	public int HunterCount = 0;
	public int populationmax = 10;
	public float population;
	public int foodmax;
	public int woodmax;
	public float woodspeed;
	public float foodspeed;
	public float attractionspeed;
	public float attraction;



	public UnityEngine.UI.Text fooddisplay;
	public UnityEngine.UI.Text wooddisplay;
	//public UnityEngine.UI.Text skinsdisplay;
	public UnityEngine.UI.Text workerdisplay;
	
	void start () {
		foodmax = 100;
		woodmax = 100;
		foodspeed = 1;
		woodspeed = 1;


	}
	
	// Update is called once per frame
	void Update () {
		attractionspeed = 0.1f;
		fooddisplay.text = Mathf.Round(food) +" Food" ;
		wooddisplay.text = Mathf.Round(wood) +" Wood" ;
		//skinsdisplay.text = skins +" Skins" ;
		workerdisplay.text = Mathf.Round(worker) +" Workers";
		population = LumberjackCount + HunterCount + worker;
		
	}
	
	
}