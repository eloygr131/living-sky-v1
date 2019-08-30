using UnityEngine;

public class Colors : MonoBehaviour {
    public Color sun_main_color { get; private set; }
    public Color sun_reflection_color { get; private set; }
    public Color sky_reflection_north_color { get; private set; }
    public Color sky_reflection_south_color { get; private set; }
    public Color background_color { get; private set; }
    public Color ambient_color { get; private set; }
    public Color stars_color { get; private set; }
    public Color moon_color { get; private set; }
    public Color clouds_color { get; private set; }

    void UpdateColorValues(int time) {
        if(time <= 1600) {
            float td = time / 1600f;
            sun_main_color = new Color(1, 0.96f + (td * 0.04f), 0.26f + (td * 0.74f), 1);
            sun_reflection_color = new Color(1, 0.9098f + (td * 0.0902f), 0.0901f + (td * 0.9099f), 1f - (td * 0.5f));
            sky_reflection_north_color = new Color(1, 0.8980f + (td * 0.1020f), 0.2509f + (td * 0.7491f), 1f - td);
            sky_reflection_south_color = new Color(1, 1, 1, 0);
            ambient_color = new Color(0.058f + (td * 0.942f), 0.058f + (td * 0.942f), 0.058f + (td * 0.942f));
            background_color = new Color(0.0509f + (td * 0.3373f), 0.0627f + (td * 0.6588f), 0.2156f + (td * 0.7844f));
            stars_color = new Color(1, 1, 1, 1f - td);
            moon_color = new Color(1, 1, 1, 1);
            clouds_color = new Color(0.4901f + (td * 0.5099f), 0.4901f + (td * 0.5099f), 0.4901f + (td * 0.5099f), 1);
        }else if (time < 16400 && time > 1600) {
            sun_main_color = new Color(1, 1, 1, 1);
            sun_reflection_color = new Color(1, 1, 1, 0.5f);
            sky_reflection_north_color = new Color(1, 1, 1, 0);
            sky_reflection_south_color = new Color(1, 1, 1, 0);
            ambient_color = new Color(1f, 1f, 1f);
            background_color = new Color(0.3882f, 0.7215f, 1f);
            stars_color = new Color(1, 1, 1, 0);
            moon_color = new Color(0.6509f, 0.8392f, 1, 1);
            clouds_color = new Color(1, 1, 1, 1);
        }else if (time >= 16400 && time <= 18000) {
            float td = (time - 18000f)/ (16400f - 18000f);
            sun_main_color = new Color(1, 0.96f + (td * 0.04f), 0.26f + (td * 0.74f), 1);
            sun_reflection_color = new Color(1, 0.9098f + (td * 0.0902f), 0.0901f + (td * 0.9099f), 1f - (td * 0.5f));
            sky_reflection_north_color = new Color(1, 1, 1, 0);
            sky_reflection_south_color = new Color(1, 0.8980f + (td * 0.1020f), 0.2509f + (td * 0.7491f), 1f - td);
            ambient_color = new Color(0.058f + (td * 0.942f), 0.058f + (td * 0.942f), 0.058f + (td * 0.942f));
            background_color = new Color(0.0509f + (td * 0.3373f), 0.0627f + (td * 0.6588f), 0.2156f + (td * 0.7844f));
            stars_color = new Color(1, 1, 1, 1f - td);
            moon_color = new Color(0.6509f + ((1 - td) * 0.3491f), 0.8392f + ((1 - td) * 0.1608f), 1f, 1f);
            clouds_color = new Color(0.4901f + (td * 0.5099f), 0.4901f + (td * 0.5099f), 0.4901f + (td * 0.5099f), 1);        
        } else if (time <= 19600) {
            float td = (time - 18000f)/ (19600f - 18000f);
            sun_main_color = new Color(1, 0.96f, 0.26f, 1f);
            sun_reflection_color = new Color(1, 0.9098f, 0.0901f, 1f);
            sky_reflection_north_color = new Color(1, 1, 1, 0);
            sky_reflection_south_color = new Color(1, 0.8980f + (td * 0.1020f), 0.2509f + (td * 0.7491f), 1f - td);
            ambient_color = new Color(0.058f, 0.058f, 0.058f);
            background_color = new Color(0.0509f, 0.0627f, 0.2156f);
            stars_color = new Color(1, 1, 1, 1);
            moon_color = new Color(1, 1, 1, 1);
            clouds_color = new Color(0.4901f, 0.4901f, 0.4901f, 1);
        } else if (time < 34400 && time > 19600) {
            sun_main_color = new Color(1, 1, 1, 1);
            sun_reflection_color = new Color(1, 1, 1, 0.5f);
            sky_reflection_north_color = new Color(1, 1, 1, 0);
            sky_reflection_south_color = new Color(1, 1, 1, 0);
            ambient_color = new Color(0.058f, 0.058f, 0.058f);
            background_color = new Color(0.0509f, 0.0627f, 0.2156f);
            stars_color = new Color(1, 1, 1, 1);
            moon_color = new Color(1, 1, 1, 1);
            clouds_color = new Color(0.4901f, 0.4901f, 0.4901f, 1);
        } else if (time > 34400) {
            float td = (time - 35999f)/ (34400f - 35999f);
            sun_main_color = new Color(1, 0.96f + (td * 0.04f), 0.26f + (td * 0.74f), 1);
            sun_reflection_color = new Color(1, 0.9098f + (td * 0.0902f), 0.0901f + (td * 0.9099f), 1f - (td * 0.5f));
            sky_reflection_north_color = new Color(1, 0.8980f + (td * 0.1020f), 0.2509f + (td * 0.7491f), 1f - td);
            sky_reflection_south_color = new Color(1, 1, 1, 0);
            ambient_color = new Color(0.058f, 0.058f, 0.058f);
            background_color = new Color(0.0509f, 0.0627f, 0.2156f);
            stars_color = new Color(1, 1, 1, 1);
            moon_color = new Color(1, 1, 1, 1);
            clouds_color = new Color(0.4901f, 0.4901f, 0.4901f, 1);
        }
    }

    public void SetTime(int time) {
        UpdateColorValues(time);
    }
}