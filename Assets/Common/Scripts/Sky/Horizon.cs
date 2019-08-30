using UnityEngine;

public class Horizon : MonoBehaviour {
    Material mat_ground, mat_horizon;

    void Awake() {
        mat_ground = GetComponent<Renderer>().materials[0];
        mat_horizon = GetComponent<Renderer>().materials[1];
    }

    public void SetColor(Color color) {
        mat_ground.color = color;
        mat_horizon.color = color;
    }
}
