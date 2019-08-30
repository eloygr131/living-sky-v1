using UnityEngine;

public class Clouds : MonoBehaviour {
    float offsX = 0;
    Material material;

    void Awake() {
        material = GetComponent<Renderer>().material;
    }

    void Update() {
        offsX += 0.008f * Time.deltaTime;
        material.SetTextureOffset("_MainTex", new Vector2(offsX, 0));
        if(offsX > 1) {
            offsX = 0;
        }
    }

    public void SetColor(Color color) {
        material.color = color;
    }
}
