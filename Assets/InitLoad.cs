using UnityEngine;
using System.Collections;

public class InitLoad : MonoBehaviour {


	public GameObject load;
    public Vungle_me vungle;
    public GameObject Error;

    void Start () 
	{
        ShowLoad();
	}


    public void ShowLoad()
    {
        load.SetActive(true);
        StartCoroutine(rectum());

    }

    IEnumerator rectum()
    {
        yield return new WaitForSeconds(25);
        vungle.Show();
        yield return new WaitForSeconds(2);
        Error.SetActive(true);
    }


    
}
