using UnityEngine;

public class LockedGate : Device, Impediment {

    void Start() {
        on = false;
        release = Release.NEVER;
        key = Key.FindOrCreate("Gate Key", KEYTYPE.NORMAL);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.E)) {
            Vector3 dist = GameObject.FindWithTag("Player").transform.position - gameObject.transform.position;
            if(dist.magnitude < 1) {
                Interact();
            }
        }
    }

    bool Impediment.IsClosed() {
        return !on;
    }

    SIDES Impediment.GetOpenSides() {
        return SIDES.BOTH;
    }

    SIDES Impediment.GetClosedSides() {
        return SIDES.NEITHER;
    }

    public override void OnTurnOn()
    {
        gameObject.transform.position = new Vector3(1.585f, 0.5f, 0);
        gameObject.transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
    }

    public override void OnTurnOff()
    {
        gameObject.transform.position = new Vector3(2, 0.5f, -0.377f);
        gameObject.transform.rotation = Quaternion.identity;
    }
}