using UnityEngine;

public enum Release {
    NEVER,
    DISTANCE,
    TIME,
    RELOAD
}

abstract public class Device : MonoBehaviour {
    public bool on; 
    public Release release;
    public Key key;
    abstract public void OnTurnOn();
    abstract public void OnTurnOff();

    private bool CanUse() {
        if(key == null) return true;
        else return key.Unlock(1);
    }

    public void Interact() {
        Debug.Log(CanUse() + " " + on);
        if(!CanUse()) return;
        if(on) OnTurnOff(); else OnTurnOn();
        on = !on;
        //do something with release maybe
    }
}