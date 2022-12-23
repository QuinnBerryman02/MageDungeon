using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KEYTYPE {
    NORMAL,
    FRAGILE
}

public class Key : MonoBehaviour {
    public KEYTYPE type;
    public int amount;
    // Start is called before the first frame update
    void Start() {
    }

    public bool Unlock() {
        if(amount < 1) return false;
        switch (type) {
            case KEYTYPE.NORMAL: amount -= 0; break;
            case KEYTYPE.FRAGILE: amount -= 1; break;
            default: break;
        }
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
