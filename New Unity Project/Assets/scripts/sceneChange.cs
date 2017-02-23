using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {

	public void LoadScene(string labor) {
		UnityEngine.SceneManagement.SceneManager.LoadScene (1);
	}
}
