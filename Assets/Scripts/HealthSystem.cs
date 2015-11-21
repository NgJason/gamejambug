using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {

    public float curr_Health = 0f;
    public float max_Health = 100f;
    public GameObject healthBar;


	// Use this for initialization
	void Start () {
        curr_Health = max_Health;
        InvokeRepeating('DecreasingHealth', 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void DecreasingHealth()
    {
        curr_Health -= 2f;
        float calc_Health = curr_Health / max_Health;
        SetHealthBar(calc_Health);
    }

    void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

}
