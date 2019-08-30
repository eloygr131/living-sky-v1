using UnityEngine;

public class SkyCamera : MonoBehaviour {

    Camera cam;

    void Awake() {
        cam = GetComponent<Camera>();
    }
    
    void Update() {
        transform.rotation = Camera.main.transform.rotation;
    }

    public void SetColor(Color color) {
        cam.backgroundColor = color;
    }
}
