﻿

#include "../ShaderLibrary/Common.hlsl"

CBUFFER_START(UnityPerMaterial)
	float4 _BaseColor;
CBUFFER_END

float4 UnlitPassVertex (float3 positionOS : POSITION) : SV_POSITION {
	float3 positionWS = TransformObjectToWorld(positionOS);
	return TransformWorldToHClip(positionWS);
}

float4 UnlitPassFragment () : SV_TARGET {
	return _BaseColor;
}
