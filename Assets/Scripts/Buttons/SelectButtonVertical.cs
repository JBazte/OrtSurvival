using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButtonVertical : MonoBehaviour
{
    
    public int maxButton;
    public int selected = 0;
    public VerticalLayoutGroup group;

	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            if (selected < maxButton)
            {
                selected++;
            }
            else
            {
                selected = 1;
            }
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                if (selected > maxButton)
                {
                    selected--;
                }
                else
                {
                    selected = maxButton;
                }
            }
        }	
	}
}
