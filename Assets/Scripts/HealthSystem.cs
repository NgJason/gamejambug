using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthSystem : MonoBehaviour {


    public float curr_Health = 0f;
    public float max_Health = 100f;
    // Each healthBar is about 10%, so make ten for full health
    public Slider healthBar;

	// Use this for initialization
	void Start () {
        curr_Health = max_Health;
        
        healthBar.value = curr_Health;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void DecreaseHealth(float damage)
    {
        healthBar.value = healthBar.value - damage;
    }

}
