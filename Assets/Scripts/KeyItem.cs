using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour {
    public string keyNameVisible;
    public KEYTYPE typeVisible;
    private Key key;
    // Start is called before the first frame update
    void Start() {
        
    }

    void OnTriggerEnter(Collider other) {
        Key.AddOrIncrement(GameObject.FindWithTag("Player").GetComponent<Player>().keys, key);
        gameObject.SetActive(false);
        GameObject.Destroy(gameObject);
        Debug.Log(GameObject.FindWithTag("Player").GetComponent<Player>().keys);
    }

    // Update is called once per frame
    void Update() {
        if(key == null || (!keyNameVisible.Equals(key.keyName) || !typeVisible.Equals(key.type))) {
            key = Key.FindOrCreate(keyNameVisible, typeVisible);
        }
    }
}
