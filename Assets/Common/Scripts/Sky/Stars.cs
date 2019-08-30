using UnityEngine;

public class Stars : MonoBehaviour {
    float rotX = 0;
    Material material;

    void Awake() {
        material = GetComponent<Renderer>().material;
    }

    void Update() {
        rotX -= 0.1f * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotX, 0, 0);
        if(rotX < -359) {
            rotX = 0;
        }
    }

    public void SetColor(Color color) {
        material.color = color;
    }
}
