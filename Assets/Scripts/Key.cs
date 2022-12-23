using System.Collections;
using System.Collections.Generic;

public enum KEYTYPE {
    NORMAL,
    FRAGILE
}

public class Key {
    private static List<Key> allKeys = new List<Key>();
    public string keyName;
    public KEYTYPE type;
    public int amount;

    public Key(string keyName, KEYTYPE type) {
        this.keyName = keyName;
        this.type = type;
        amount = 0;
        allKeys.Add(this);
    }

    public void GainKeys(int n) {
        amount += n;
    }

    public void SetKeyAmount(int n) {
        amount = n;
    }

    public bool Unlock(int cost) {
        if(amount < cost) return false;
        switch (type) {
            case KEYTYPE.NORMAL: amount -= 0; break;
            case KEYTYPE.FRAGILE: amount -= cost; break;
            default: break;
        }
        return true;
    }

    public static Key FindOrCreate(string name, KEYTYPE type) {
        foreach (Key k in allKeys) {
            if(k.keyName.Equals(name) && k.type.Equals(type)) return k;
        }
        return new Key(name, type);
    }

    public static void AddOrIncrement(List<Key> keys, Key key) {
        foreach (Key k in keys) {
            if(k.keyName.Equals(key.keyName) && k.type.Equals(key.type)) { key.GainKeys(1); return; }
        }
        keys.Add(key);
        key.GainKeys(1);
    }
}
