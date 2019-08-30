using UnityEngine;

public class AmbientLight : MonoBehaviour {
    
    public void SetColor(Color color) {
        RenderSettings.ambientLight = color;
    }
}
