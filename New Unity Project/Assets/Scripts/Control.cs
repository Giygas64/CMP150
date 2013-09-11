using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Control : MonoBehaviour {

    public string Name = "Control";
    private List<KeyboardInput> inputs = new List<KeyboardInput>();
    public bool IsActive
    {
        get { return isActive; }
    }
    private bool isActive = false;


	void Start () 
    {
        foreach (var input in gameObject.GetComponents<KeyboardInput>())
        {
            if (inputs.Contains(input)) continue;
            inputs.Add(input);

        }
	}
	
	// Update is called once per frame
	void Update () 
    {
        isActive = false;
        foreach (var input in inputs)
        {
            if (input.IsActive)
            {
                isActive = true;
                break;
            }
        }
        


	}
}
