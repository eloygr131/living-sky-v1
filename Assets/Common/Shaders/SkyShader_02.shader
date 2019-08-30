Shader "Unlit/SkyShader_02" {
    Properties {
        _Alpha ("Alpha", Range (0,1) ) = 1.0
        _MainTex ("MainTex", 2D) = "white" {}
        _Color ("Color", Color) = (1,1,1,1)
        _AlphaTex ("AlphaTex", 2D) = "white" {}
    }

    SubShader {
        Tags {"Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent"}
        LOD 100

        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha

        Pass {
            CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag

                #include "UnityCG.cginc"

                struct appdata_t {
                    float4 vertex : POSITION;
                    float2 texcoordA : TEXCOORD0;
                    float2 texcoordB : TEXCOORD1;
                };

                struct v2f {
                    float4 vertex : SV_POSITION;
                    half2 texcoordA : TEXCOORD0;
                    half2 texcoordB : TEXCOORD1;
                };

                sampler2D _MainTex;
                sampler2D _AlphaTex;
                float _Alpha;

                float4 _MainTex_ST;
                float4 _AlphaTex_ST;
                fixed4 _Color;

                v2f vert (appdata_t v) {
                    v2f o;
                    o.vertex = UnityObjectToClipPos(v.vertex);
                    o.texcoordA = TRANSFORM_TEX(v.texcoordA, _MainTex);
                    o.texcoordB = TRANSFORM_TEX(v.texcoordB, _AlphaTex);
                    return o;
                }

                fixed4 frag (v2f i) : SV_Target {
                    fixed4 main = tex2D(_MainTex, i.texcoordA) * _Color;
                    fixed4 alph = tex2D(_AlphaTex, i.texcoordB);

                    return fixed4(main.r, main.g, main.b, (main.a * alph.r * _Alpha));
                }
            ENDCG
        }
    }
}