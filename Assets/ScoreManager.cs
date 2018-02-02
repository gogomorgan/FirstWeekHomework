using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public GUIText potatoscoreText;
    public GUIText eggplantscoreText;
    public int potatoscore;
    public int eggplantscore;

    // Use this for initialization
    void Start () {
        potatoscore = 0;
        eggplantscore = 0;
        UpdateScore();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateScore()
    {
        potatoscoreText.text = "Potato Score: " + potatoscore;
        eggplantscoreText.text = "Eggplant Score: " + eggplantscore;
    }

}
