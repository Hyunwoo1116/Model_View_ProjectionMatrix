Shader "Unlit/MVPTestShader"
{
    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            float4x4 _MVP;

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
            };

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = mul(_MVP, v.vertex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                // 단색 출력
                return fixed4(1, 0, 0, 1); // 빨강
            }
            ENDCG
        }
    }
}