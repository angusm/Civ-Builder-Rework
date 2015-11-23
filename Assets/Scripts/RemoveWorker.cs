using UnityEngine;
using System.Collections;

public class RemoveWorker : MonoBehaviour {
	
	public Resources materials;
	public string WorkerType;
	
	
	
	public void Clicked () {
		if (WorkerType == "Hunter") {
			if (materials.HunterCount >= 1) {
				materials.HunterCount -= 1;
				materials.worker += 1;
			}
		} else if (WorkerType == "Lumberjack") {
			if (materials.LumberjackCount >= 1) {
				materials.LumberjackCount -= 1;
				materials.worker += 1;
			}
		}


	}
	
}