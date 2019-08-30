using UnityEngine;

public class DayCycle : MonoBehaviour {
    
    public int time = 900;
    float waitT = 0.05f;

    public SkyCamera skyCamera;
    public MoonSun moonSun;
    public SkyReflections skyReflections;
    public Ground ground;
    public Stars stars;
    public Horizon horizon;
    public Clouds clouds;
    AmbientLight ambientLight;
    Colors colors;

    void Awake() {
        ambientLight = GetComponent<AmbientLight>();
        colors = GetComponent<Colors>();
    }

    void Update() {
        UpdateTime();
        UpdateSky();
    }

    void UpdateSky() {
        if(waitT > 0) { return; }
        colors.SetTime(time);
        skyCamera.SetColor(colors.background_color);
        ground.SetColor(colors.background_color);
        moonSun.SetState(time, colors.sun_main_color, colors.sun_reflection_color, colors.moon_color);
        skyReflections.SetColors(colors.sky_reflection_north_color, colors.sky_reflection_south_color);
        ambientLight.SetColor(colors.ambient_color);
        stars.SetColor(colors.stars_color);
        horizon.SetColor(colors.background_color);
        clouds.SetColor(colors.clouds_color);
    }

    void UpdateTime() {
        if(waitT <= 0) {
            time++;
            waitT = 0.09f;
            if(time >= 35999) {
                time = 0;
            }
        }
        waitT -= Time.deltaTime;
    }
}