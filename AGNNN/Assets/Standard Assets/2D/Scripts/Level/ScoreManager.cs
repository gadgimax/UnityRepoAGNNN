using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {


    public static int gems;

    Text text;

    

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        //gems = 0;

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gems < 0)
            gems = 0;

        text.text = "   " + gems; 
	}
    public static void AddPoints (int pointsToAdd)
    {
        gems += pointsToAdd;
            }
    public static void PointsToTake (int pointsToTake)
    {
        gems -= pointsToTake;
    }


}
