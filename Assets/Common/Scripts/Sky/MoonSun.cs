using UnityEngine;

public class MoonSun : MonoBehaviour {

    Material mat_sun, mat_sun_reflection, mat_moon, mat_moon_reflection;
    
    void Awake() {
        mat_sun_reflection = GetComponent<Renderer>().materials[0];
        mat_sun = GetComponent<Renderer>().materials[1];
        mat_moon_reflection = GetComponent<Renderer>().materials[2];
        mat_moon = GetComponent<Renderer>().materials[3];
    }

    void Rotate(int time) {
        Vector3 rot = new Vector3(-90+(time/100f), 0, 0);
        transform.localRotation = Quaternion.Euler(rot);
    }

    public void SetState(int time, Color sunColor, Color reflectionColor, Color moonColor) {
        Rotate(time);
        mat_sun.color = sunColor;
        mat_sun_reflection.color = reflectionColor;
        mat_moon.color = moonColor;
        mat_moon_reflection.color = moonColor;
    }
}
