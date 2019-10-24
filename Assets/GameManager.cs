using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public float slowness = 10f;

	public void EndGame ()
    {
        StartCoroutine(RestartLevel());
        //Debug.Log("ENDING GAME");
    }

    IEnumerator RestartLevel ()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        // before 1 sec
        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        // after 1 sec
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
