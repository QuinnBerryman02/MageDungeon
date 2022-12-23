using UnityEngine;

public class LockedGate : Impediment {
    public Key gateKey; 

    void Start()
    {
        sidesAvailableWhenClosed = SIDES.NEITHER;
        sidesAvailableWhenOpen = SIDES.BOTH;
        UpdateStatus();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.L)) UpdateStatus();

        if(closed) {
            gameObject.transform.position = new Vector3(2, 0.5f, -0.377f);
            gameObject.transform.rotation = Quaternion.identity;
        } else {
            gameObject.transform.position = new Vector3(1.585f, 0.5f, 0);
            gameObject.transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }
    }

    override protected void UpdateStatus() {
        if(gateKey == null) closed = true;
        else if(gateKey.Unlock()) closed = false;
        else closed = true;
        if(closed == true) Debug.Log("Not enough keys");
    }
}