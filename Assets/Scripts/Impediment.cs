using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SIDES {
    BOTH,
    FIRST,
    SECOND, 
    NEITHER
}

abstract public class Impediment : MonoBehaviour {
    public SIDES sidesAvailableWhenOpen;
    public SIDES sidesAvailableWhenClosed;
    public bool closed;

    abstract protected void UpdateStatus();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
