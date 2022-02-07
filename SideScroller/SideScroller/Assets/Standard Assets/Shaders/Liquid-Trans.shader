// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:2865,x:32719,y:32712,varname:node_2865,prsc:2|diff-3982-RGB,spec-3395-OUT,emission-3054-OUT,alpha-821-OUT,refract-5975-OUT,voffset-9722-OUT;n:type:ShaderForge.SFN_Multiply,id:9161,x:31447,y:33317,cmnt:Triangle Wave,varname:node_9161,prsc:2|A-8947-R,B-1742-OUT;n:type:ShaderForge.SFN_NormalVector,id:1866,x:31783,y:33601,prsc:2,pt:True;n:type:ShaderForge.SFN_Multiply,id:4252,x:32103,y:33498,varname:node_4252,prsc:2|A-9161-OUT,B-1866-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1742,x:31105,y:33526,ptovrint:False,ptlb:Bulge Intensity,ptin:_BulgeIntensity,varname:_BulgeScale,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:4042,x:31759,y:32889,cmnt:Glow,varname:node_4042,prsc:2|A-4460-OUT,B-9621-OUT;n:type:ShaderForge.SFN_Color,id:3982,x:30665,y:32802,ptovrint:False,ptlb:Glow Color,ptin:_GlowColor,varname:_GlowColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.75,c2:0.9793103,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:8940,x:31302,y:32372,ptovrint:False,ptlb:Normals 02,ptin:_Normals02,varname:_Normals,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:bbab0a6f7bae9cf42bf057d8ee2755f6,ntxv:3,isnm:True|UVIN-5946-OUT;n:type:ShaderForge.SFN_Tex2d,id:5604,x:30693,y:32606,ptovrint:False,ptlb:Glow Texture,ptin:_GlowTexture,varname:_Emissive,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f93153eeced86674dabe5a3383a1b95d,ntxv:0,isnm:False|UVIN-754-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9621,x:31389,y:33030,ptovrint:False,ptlb:Glow Power,ptin:_GlowPower,varname:_EmissivePower,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Lerp,id:9722,x:32466,y:33437,varname:node_9722,prsc:2|A-5665-OUT,B-4252-OUT,T-4093-R;n:type:ShaderForge.SFN_Vector1,id:5665,x:32086,y:33424,varname:node_5665,prsc:2,v1:0;n:type:ShaderForge.SFN_VertexColor,id:4093,x:32058,y:33694,varname:node_4093,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:8947,x:30893,y:33295,ptovrint:False,ptlb:BuldgeShape,ptin:_BuldgeShape,varname:node_2012,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c3b39832eb62546e396e844ba48af8ba,ntxv:0,isnm:False|UVIN-2077-OUT;n:type:ShaderForge.SFN_Multiply,id:5718,x:31035,y:32622,varname:node_5718,prsc:2|A-5604-RGB,B-3982-RGB;n:type:ShaderForge.SFN_Lerp,id:4460,x:31389,y:32881,varname:node_4460,prsc:2|A-3982-RGB,B-5718-OUT,T-1112-OUT;n:type:ShaderForge.SFN_Slider,id:1112,x:30723,y:33052,ptovrint:False,ptlb:Glow Color - Texture,ptin:_GlowColorTexture,varname:node_5924,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_TexCoord,id:4954,x:29463,y:33157,varname:node_4954,prsc:2,uv:0;n:type:ShaderForge.SFN_Lerp,id:3054,x:31994,y:32889,varname:node_3054,prsc:2|A-7008-OUT,B-4042-OUT,T-8054-OUT;n:type:ShaderForge.SFN_Vector1,id:7008,x:31759,y:33024,varname:node_7008,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:8054,x:31602,y:33111,ptovrint:False,ptlb:Glow Off - On,ptin:_GlowOffOn,varname:_NormalStrength_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_ValueProperty,id:1562,x:29185,y:33400,ptovrint:False,ptlb:U Speed Bulge,ptin:_USpeedBulge,varname:node_3605,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:9627,x:29185,y:33493,ptovrint:False,ptlb:V Speed Bulge,ptin:_VSpeedBulge,varname:_node_3605_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:7878,x:29463,y:33371,varname:node_7878,prsc:2|A-1562-OUT,B-9627-OUT;n:type:ShaderForge.SFN_Multiply,id:6405,x:29974,y:33276,varname:node_6405,prsc:2|A-150-T,B-7878-OUT;n:type:ShaderForge.SFN_Time,id:150,x:29741,y:33188,varname:node_150,prsc:2;n:type:ShaderForge.SFN_Add,id:2077,x:30243,y:33243,varname:node_2077,prsc:2|A-4954-UVOUT,B-6405-OUT;n:type:ShaderForge.SFN_TexCoord,id:1054,x:29571,y:31776,varname:node_1054,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:573,x:29277,y:32129,ptovrint:False,ptlb:U Speed Norm2,ptin:_USpeedNorm2,varname:_USpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:1091,x:29277,y:32222,ptovrint:False,ptlb:V Speed Norm2,ptin:_VSpeedNorm2,varname:_VSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:9002,x:29555,y:32100,varname:node_9002,prsc:2|A-573-OUT,B-1091-OUT;n:type:ShaderForge.SFN_Multiply,id:3272,x:30066,y:32005,varname:node_3272,prsc:2|A-371-T,B-9002-OUT;n:type:ShaderForge.SFN_Time,id:371,x:29833,y:31917,varname:node_371,prsc:2;n:type:ShaderForge.SFN_Add,id:5946,x:30335,y:31972,varname:node_5946,prsc:2|A-1054-UVOUT,B-3272-OUT;n:type:ShaderForge.SFN_Slider,id:821,x:32164,y:32952,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:_OcclusionStength_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:5975,x:32366,y:32713,varname:node_5975,prsc:2|A-9770-OUT,B-2149-OUT;n:type:ShaderForge.SFN_ComponentMask,id:9770,x:32041,y:32633,varname:node_9770,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-6452-OUT;n:type:ShaderForge.SFN_Slider,id:2149,x:32014,y:32826,ptovrint:False,ptlb:Refraction Strength,ptin:_RefractionStrength,varname:_Opacity_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Tex2d,id:4808,x:31135,y:32031,ptovrint:False,ptlb:Normals 01,ptin:_Normals01,varname:_Normals_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:bbab0a6f7bae9cf42bf057d8ee2755f6,ntxv:3,isnm:True|UVIN-1162-OUT;n:type:ShaderForge.SFN_TexCoord,id:5984,x:29588,y:31274,varname:node_5984,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:7357,x:29294,y:31627,ptovrint:False,ptlb:U Speed Norm1,ptin:_USpeedNorm1,varname:_USpeedGlow_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:7084,x:29294,y:31720,ptovrint:False,ptlb:V Speed Norm1,ptin:_VSpeedNorm1,varname:_VSpeedGlow_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:5432,x:29572,y:31598,varname:node_5432,prsc:2|A-7357-OUT,B-7084-OUT;n:type:ShaderForge.SFN_Multiply,id:9691,x:30083,y:31503,varname:node_9691,prsc:2|A-5315-T,B-5432-OUT;n:type:ShaderForge.SFN_Time,id:5315,x:29850,y:31415,varname:node_5315,prsc:2;n:type:ShaderForge.SFN_Add,id:1162,x:30352,y:31470,varname:node_1162,prsc:2|A-5984-UVOUT,B-9691-OUT;n:type:ShaderForge.SFN_Blend,id:6452,x:31677,y:32077,varname:node_6452,prsc:2,blmd:1,clmp:True|SRC-4808-RGB,DST-8940-RGB;n:type:ShaderForge.SFN_TexCoord,id:1993,x:29555,y:32368,varname:node_1993,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:9873,x:29261,y:32721,ptovrint:False,ptlb:U Speed Glow,ptin:_USpeedGlow,varname:_USpeedNorm3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:9480,x:29261,y:32814,ptovrint:False,ptlb:V Speed Glow,ptin:_VSpeedGlow,varname:_VSpeedNorm3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:6786,x:29539,y:32692,varname:node_6786,prsc:2|A-9873-OUT,B-9480-OUT;n:type:ShaderForge.SFN_Multiply,id:6348,x:30050,y:32597,varname:node_6348,prsc:2|A-7826-T,B-6786-OUT;n:type:ShaderForge.SFN_Time,id:7826,x:29817,y:32509,varname:node_7826,prsc:2;n:type:ShaderForge.SFN_Add,id:754,x:30319,y:32564,varname:node_754,prsc:2|A-1993-UVOUT,B-6348-OUT;n:type:ShaderForge.SFN_TexCoord,id:1871,x:29699,y:31904,varname:node_1871,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:5853,x:29405,y:32257,ptovrint:False,ptlb:U Speed Norm3,ptin:_USpeedNorm3,varname:_USpeedNorm3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:9985,x:29405,y:32350,ptovrint:False,ptlb:V Speed Norm3,ptin:_VSpeedNorm3,varname:_VSpeedNorm3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:9601,x:29683,y:32228,varname:node_9601,prsc:2|A-5853-OUT,B-9985-OUT;n:type:ShaderForge.SFN_Multiply,id:9643,x:30194,y:32133,varname:node_9643,prsc:2|A-6906-T,B-9601-OUT;n:type:ShaderForge.SFN_Time,id:6906,x:29961,y:32045,varname:node_6906,prsc:2;n:type:ShaderForge.SFN_Add,id:1663,x:30463,y:32100,varname:node_1663,prsc:2|A-1871-UVOUT,B-9643-OUT;n:type:ShaderForge.SFN_Vector1,id:3395,x:32375,y:32544,varname:node_3395,prsc:2,v1:0.9;n:type:ShaderForge.SFN_Slider,id:2877,x:32174,y:32406,ptovrint:False,ptlb:Refraction Strength_copy,ptin:_RefractionStrength_copy,varname:_RefractionStrength_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;proporder:821-4808-7357-7084-8940-573-1091-2149-3982-5604-9873-9480-9621-1112-8054-1742-8947-1562-9627;pass:END;sub:END;*/

Shader "Shader Forge/Liquid-Trans" {
    Properties {
        _Opacity ("Opacity", Range(0, 1)) = 1
        _Normals01 ("Normals 01", 2D) = "bump" {}
        _USpeedNorm1 ("U Speed Norm1", Float ) = 0
        _VSpeedNorm1 ("V Speed Norm1", Float ) = 0
        _Normals02 ("Normals 02", 2D) = "bump" {}
        _USpeedNorm2 ("U Speed Norm2", Float ) = 0
        _VSpeedNorm2 ("V Speed Norm2", Float ) = 0
        _RefractionStrength ("Refraction Strength", Range(0, 10)) = 1
        _GlowColor ("Glow Color", Color) = (0.75,0.9793103,1,1)
        _GlowTexture ("Glow Texture", 2D) = "white" {}
        _USpeedGlow ("U Speed Glow", Float ) = 0
        _VSpeedGlow ("V Speed Glow", Float ) = 0
        _GlowPower ("Glow Power", Float ) = 3
        _GlowColorTexture ("Glow Color - Texture", Range(0, 1)) = 0
        _GlowOffOn ("Glow Off - On", Range(0, 1)) = 0
        _BulgeIntensity ("Bulge Intensity", Float ) = 1
        _BuldgeShape ("BuldgeShape", 2D) = "white" {}
        _USpeedBulge ("U Speed Bulge", Float ) = 0
        _VSpeedBulge ("V Speed Bulge", Float ) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform sampler2D _GrabTexture;
            uniform float4 _TimeEditor;
            uniform float _BulgeIntensity;
            uniform float4 _GlowColor;
            uniform sampler2D _Normals02; uniform float4 _Normals02_ST;
            uniform sampler2D _GlowTexture; uniform float4 _GlowTexture_ST;
            uniform float _GlowPower;
            uniform sampler2D _BuldgeShape; uniform float4 _BuldgeShape_ST;
            uniform float _GlowColorTexture;
            uniform float _GlowOffOn;
            uniform float _USpeedBulge;
            uniform float _VSpeedBulge;
            uniform float _USpeedNorm2;
            uniform float _VSpeedNorm2;
            uniform float _Opacity;
            uniform float _RefractionStrength;
            uniform sampler2D _Normals01; uniform float4 _Normals01_ST;
            uniform float _USpeedNorm1;
            uniform float _VSpeedNorm1;
            uniform float _USpeedGlow;
            uniform float _VSpeedGlow;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 screenPos : TEXCOORD7;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(8)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD9;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float node_5665 = 0.0;
                float4 node_150 = _Time + _TimeEditor;
                float2 node_2077 = (o.uv0+(node_150.g*float2(_USpeedBulge,_VSpeedBulge)));
                float4 _BuldgeShape_var = tex2Dlod(_BuldgeShape,float4(TRANSFORM_TEX(node_2077, _BuldgeShape),0.0,0));
                v.vertex.xyz += lerp(float3(node_5665,node_5665,node_5665),((_BuldgeShape_var.r*_BulgeIntensity)*v.normal),o.vertexColor.r);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.screenPos = o.pos;
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float4 node_5315 = _Time + _TimeEditor;
                float2 node_1162 = (i.uv0+(node_5315.g*float2(_USpeedNorm1,_VSpeedNorm1)));
                float3 _Normals01_var = UnpackNormal(tex2D(_Normals01,TRANSFORM_TEX(node_1162, _Normals01)));
                float4 node_371 = _Time + _TimeEditor;
                float2 node_5946 = (i.uv0+(node_371.g*float2(_USpeedNorm2,_VSpeedNorm2)));
                float3 _Normals02_var = UnpackNormal(tex2D(_Normals02,TRANSFORM_TEX(node_5946, _Normals02)));
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (saturate((_Normals01_var.rgb*_Normals02_var.rgb)).rg*_RefractionStrength);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                d.boxMax[0] = unity_SpecCube0_BoxMax;
                d.boxMin[0] = unity_SpecCube0_BoxMin;
                d.probePosition[0] = unity_SpecCube0_ProbePosition;
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.boxMax[1] = unity_SpecCube1_BoxMax;
                d.boxMin[1] = unity_SpecCube1_BoxMin;
                d.probePosition[1] = unity_SpecCube1_ProbePosition;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_3395 = 0.9;
                float3 specularColor = float3(node_3395,node_3395,node_3395);
                float3 directSpecular = 1 * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 indirectSpecular = (gi.indirect.specular)*specularColor;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuseColor = _GlowColor.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float node_7008 = 0.0;
                float4 node_7826 = _Time + _TimeEditor;
                float2 node_754 = (i.uv0+(node_7826.g*float2(_USpeedGlow,_VSpeedGlow)));
                float4 _GlowTexture_var = tex2D(_GlowTexture,TRANSFORM_TEX(node_754, _GlowTexture));
                float3 emissive = lerp(float3(node_7008,node_7008,node_7008),(lerp(_GlowColor.rgb,(_GlowTexture_var.rgb*_GlowColor.rgb),_GlowColorTexture)*_GlowPower),_GlowOffOn);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,_Opacity),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform sampler2D _GrabTexture;
            uniform float4 _TimeEditor;
            uniform float _BulgeIntensity;
            uniform float4 _GlowColor;
            uniform sampler2D _Normals02; uniform float4 _Normals02_ST;
            uniform sampler2D _GlowTexture; uniform float4 _GlowTexture_ST;
            uniform float _GlowPower;
            uniform sampler2D _BuldgeShape; uniform float4 _BuldgeShape_ST;
            uniform float _GlowColorTexture;
            uniform float _GlowOffOn;
            uniform float _USpeedBulge;
            uniform float _VSpeedBulge;
            uniform float _USpeedNorm2;
            uniform float _VSpeedNorm2;
            uniform float _Opacity;
            uniform float _RefractionStrength;
            uniform sampler2D _Normals01; uniform float4 _Normals01_ST;
            uniform float _USpeedNorm1;
            uniform float _VSpeedNorm1;
            uniform float _USpeedGlow;
            uniform float _VSpeedGlow;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 screenPos : TEXCOORD7;
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(8,9)
                UNITY_FOG_COORDS(10)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float node_5665 = 0.0;
                float4 node_150 = _Time + _TimeEditor;
                float2 node_2077 = (o.uv0+(node_150.g*float2(_USpeedBulge,_VSpeedBulge)));
                float4 _BuldgeShape_var = tex2Dlod(_BuldgeShape,float4(TRANSFORM_TEX(node_2077, _BuldgeShape),0.0,0));
                v.vertex.xyz += lerp(float3(node_5665,node_5665,node_5665),((_BuldgeShape_var.r*_BulgeIntensity)*v.normal),o.vertexColor.r);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.screenPos = o.pos;
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float4 node_5315 = _Time + _TimeEditor;
                float2 node_1162 = (i.uv0+(node_5315.g*float2(_USpeedNorm1,_VSpeedNorm1)));
                float3 _Normals01_var = UnpackNormal(tex2D(_Normals01,TRANSFORM_TEX(node_1162, _Normals01)));
                float4 node_371 = _Time + _TimeEditor;
                float2 node_5946 = (i.uv0+(node_371.g*float2(_USpeedNorm2,_VSpeedNorm2)));
                float3 _Normals02_var = UnpackNormal(tex2D(_Normals02,TRANSFORM_TEX(node_5946, _Normals02)));
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (saturate((_Normals01_var.rgb*_Normals02_var.rgb)).rg*_RefractionStrength);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_3395 = 0.9;
                float3 specularColor = float3(node_3395,node_3395,node_3395);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 diffuseColor = _GlowColor.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * _Opacity,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform float _BulgeIntensity;
            uniform sampler2D _BuldgeShape; uniform float4 _BuldgeShape_ST;
            uniform float _USpeedBulge;
            uniform float _VSpeedBulge;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float2 uv1 : TEXCOORD2;
                float2 uv2 : TEXCOORD3;
                float4 posWorld : TEXCOORD4;
                float3 normalDir : TEXCOORD5;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float node_5665 = 0.0;
                float4 node_150 = _Time + _TimeEditor;
                float2 node_2077 = (o.uv0+(node_150.g*float2(_USpeedBulge,_VSpeedBulge)));
                float4 _BuldgeShape_var = tex2Dlod(_BuldgeShape,float4(TRANSFORM_TEX(node_2077, _BuldgeShape),0.0,0));
                v.vertex.xyz += lerp(float3(node_5665,node_5665,node_5665),((_BuldgeShape_var.r*_BulgeIntensity)*v.normal),o.vertexColor.r);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos(v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform float _BulgeIntensity;
            uniform float4 _GlowColor;
            uniform sampler2D _GlowTexture; uniform float4 _GlowTexture_ST;
            uniform float _GlowPower;
            uniform sampler2D _BuldgeShape; uniform float4 _BuldgeShape_ST;
            uniform float _GlowColorTexture;
            uniform float _GlowOffOn;
            uniform float _USpeedBulge;
            uniform float _VSpeedBulge;
            uniform float _USpeedGlow;
            uniform float _VSpeedGlow;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float node_5665 = 0.0;
                float4 node_150 = _Time + _TimeEditor;
                float2 node_2077 = (o.uv0+(node_150.g*float2(_USpeedBulge,_VSpeedBulge)));
                float4 _BuldgeShape_var = tex2Dlod(_BuldgeShape,float4(TRANSFORM_TEX(node_2077, _BuldgeShape),0.0,0));
                v.vertex.xyz += lerp(float3(node_5665,node_5665,node_5665),((_BuldgeShape_var.r*_BulgeIntensity)*v.normal),o.vertexColor.r);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float node_7008 = 0.0;
                float4 node_7826 = _Time + _TimeEditor;
                float2 node_754 = (i.uv0+(node_7826.g*float2(_USpeedGlow,_VSpeedGlow)));
                float4 _GlowTexture_var = tex2D(_GlowTexture,TRANSFORM_TEX(node_754, _GlowTexture));
                o.Emission = lerp(float3(node_7008,node_7008,node_7008),(lerp(_GlowColor.rgb,(_GlowTexture_var.rgb*_GlowColor.rgb),_GlowColorTexture)*_GlowPower),_GlowOffOn);
                
                float3 diffColor = _GlowColor.rgb;
                float node_3395 = 0.9;
                float3 specColor = float3(node_3395,node_3395,node_3395);
                o.Albedo = diffColor + specColor * 0.125; // No gloss connected. Assume it's 0.5
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
