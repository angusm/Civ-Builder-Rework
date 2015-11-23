using UnityEngine;
using System.Collections;

public class AddWorker: MonoBehaviour {
	
	public Resources materials;
	public string WorkerType;

	
	
	public void PurchasedItem () {
		if (materials.worker >= 1) {
			materials.worker -= 1;
			if (WorkerType == "Lumberjack") {
				materials.LumberjackCount += 1;
			}
			else if (WorkerType == "Hunter") {
				materials.HunterCount +=1;
			}

		}
	
	}

}