using UnityEngine;

public class SkyReflections : MonoBehaviour {
    
    Material mat_south, mat_north;

    void Awake() {
        mat_south = GetComponent<Renderer>().materials[0];
        mat_north = GetComponent<Renderer>().materials[1];
    }
    
    public void SetColors(Color north_color, Color south_color) {
        mat_north.color = north_color;
        mat_south.color = south_color;
    }
}
