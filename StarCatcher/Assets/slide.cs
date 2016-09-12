using UnityEngine;
using System.Collections;

public class slide : MonoBehaviour {

    private CharacterController myCC;
    public int slideDuration = 20;
    public float slideTime = 0.01f;
	
    IEnumerator Slide ()
    {
        int i = 0;
        while (i < slideDuration)
        {
            i++;
            yield return new WaitForSeconds(slideTime);
            print("sliding");
        }
        //While iterations
        //Wait for secs
        //Move the character controller
    }

	void Start () {
        myCC = GetComponent<CharacterController>();
        StartCoroutine(Slide());
	
	}
	
	
}
