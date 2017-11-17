using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class Scene_Change : MonoBehaviour{

	public string sceneToChangeTo;
	private int counterscene;

	void Start(){
		SetGazedAt(false);
	}

	public void SetGazedAt(bool gazedAt){
			counterscene++;
			if (counterscene % 2 == 0){
				ChangeToScene();
			}
			return;
		}

	public void ChangeToScene(){
		SceneManager.LoadScene (sceneToChangeTo);
	}
}
