Shader "Unlit/AleksanderShader"
{
    Properties
    {
        _MainTexture ("Texture", 2D) = "white" {}
        //RGBA
        _Color("Colour", Color) = (1,1,1,1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vertexFunction
            #pragma fragment fragmentFunction

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertexPosition : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            fixed4 _Color;
            sampler2D _MainTexture;

            v2f vertexFunction(appdata IN)
            {
                v2f OUT;
                OUT.vertexPosition = UnityObjectToClipPos(IN.vertex);
                OUT.uv = IN.uv;
                return OUT;
            }

            fixed4 fragmentFunction(v2f IN) : SV_Target
            {
                fixed4 pixelColor = tex2D(_MainTexture, IN.uv);
                return pixelColor * _Color;
            }

            ENDCG
        }
    }
}
