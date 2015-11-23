using UnityEngine;
using System.Collections;

public class ResourcesPerSec : MonoBehaviour {
	public UnityEngine.UI.Text PerSecDiplay;
	public Resources materials;
	public AddWorker addworker;
	
	void Start () {
		StartCoroutine (AutoTick ());

		}

	void Update () {
		PerSecDiplay.text = GetFoodPerSec () + " Food/Sec" + "\n" + GetWoodPerSec () + " Wood/Sec" + "\n" + GetWorkerPerSec () + " Workers/Sec";
	
	}

	public float GetFoodPerSec () {
		float foodtick = materials.HunterCount * materials.foodspeed;
		return foodtick;
	}
	public float GetWoodPerSec () {
		float woodtick = materials.LumberjackCount * materials.woodspeed ;
		return woodtick;
	}
	public float GetWorkerPerSec () {
		float workertick = materials.attraction * materials.attractionspeed;
		return workertick;
	}

	public void AutoResourcesPerSec () {
		materials.food += GetFoodPerSec () / 10;
		materials.wood += GetWoodPerSec () / 10;
	}
	
	public void AutoWorkersPerSec () {
		if (materials.population < materials.populationmax) {
			materials.worker += GetWorkerPerSec () / 10;
		}
	}

	IEnumerator AutoTick () {
		while (true) {
			AutoResourcesPerSec ();
			AutoWorkersPerSec ();
			yield return new WaitForSeconds (0.10f);
		}
		
	}

}
