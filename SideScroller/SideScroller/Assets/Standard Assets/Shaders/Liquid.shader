// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:2865,x:32719,y:32712,varname:node_2865,prsc:2|diff-1120-OUT,spec-3304-OUT,gloss-9483-OUT,normal-401-OUT,emission-7743-OUT,difocc-8660-OUT,spcocc-8660-OUT,voffset-5300-OUT;n:type:ShaderForge.SFN_Slider,id:3304,x:31916,y:32148,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:_Metallic,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:9483,x:31916,y:32259,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Gloss,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:1;n:type:ShaderForge.SFN_Multiply,id:8438,x:31383,y:33253,cmnt:Triangle Wave,varname:node_8438,prsc:2|A-9348-R,B-6666-OUT;n:type:ShaderForge.SFN_NormalVector,id:6409,x:31719,y:33537,prsc:2,pt:True;n:type:ShaderForge.SFN_Multiply,id:9056,x:32039,y:33434,varname:node_9056,prsc:2|A-8438-OUT,B-6409-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6666,x:31041,y:33462,ptovrint:False,ptlb:Bulge Intensity,ptin:_BulgeIntensity,varname:_BulgeScale,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Lerp,id:401,x:32010,y:32526,varname:node_401,prsc:2|A-9737-OUT,B-396-RGB,T-6316-OUT;n:type:ShaderForge.SFN_Tex2d,id:6328,x:31924,y:31614,ptovrint:False,ptlb:Albedo,ptin:_Albedo,varname:_Albedo,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9cdbf47311d3fc6478633eae4bafc7ff,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:8891,x:31695,y:32825,cmnt:Glow,varname:node_8891,prsc:2|A-965-OUT,B-3860-OUT;n:type:ShaderForge.SFN_Color,id:6590,x:30601,y:32738,ptovrint:False,ptlb:GlowColor,ptin:_GlowColor,varname:_GlowColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.75,c2:0.9793103,c3:1,c4:1;n:type:ShaderForge.SFN_Vector3,id:9737,x:31709,y:32411,varname:node_9737,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_Tex2d,id:396,x:31709,y:32519,ptovrint:False,ptlb:Normals,ptin:_Normals,varname:_Normals,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:bbab0a6f7bae9cf42bf057d8ee2755f6,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:7450,x:30629,y:32542,ptovrint:False,ptlb:Glow Texture,ptin:_GlowTexture,varname:_Emissive,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f93153eeced86674dabe5a3383a1b95d,ntxv:0,isnm:False|UVIN-6943-OUT;n:type:ShaderForge.SFN_Color,id:6313,x:31924,y:31797,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:_Colour,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.2391481,c3:0.1102941,c4:1;n:type:ShaderForge.SFN_Slider,id:6316,x:31552,y:32702,ptovrint:False,ptlb:Normal Strength,ptin:_NormalStrength,varname:_NormalStrength,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_ValueProperty,id:3860,x:31325,y:32966,ptovrint:False,ptlb:Emissive Power,ptin:_EmissivePower,varname:_EmissivePower,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Lerp,id:5300,x:32402,y:33373,varname:node_5300,prsc:2|A-9538-OUT,B-9056-OUT,T-958-R;n:type:ShaderForge.SFN_Vector1,id:9538,x:32022,y:33360,varname:node_9538,prsc:2,v1:0;n:type:ShaderForge.SFN_VertexColor,id:958,x:31994,y:33630,varname:node_958,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1120,x:32294,y:31814,varname:node_1120,prsc:2|A-6328-RGB,B-6313-RGB;n:type:ShaderForge.SFN_Tex2d,id:4594,x:32107,y:33023,ptovrint:False,ptlb:Occlusion,ptin:_Occlusion,varname:node_3095,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:3969,x:32075,y:33209,ptovrint:False,ptlb:Occlusion Stength,ptin:_OcclusionStength,varname:node_5137,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Lerp,id:8660,x:32447,y:33055,varname:node_8660,prsc:2|A-4594-R,B-407-OUT,T-3969-OUT;n:type:ShaderForge.SFN_Vector1,id:407,x:32232,y:33130,varname:node_407,prsc:2,v1:0;n:type:ShaderForge.SFN_Tex2d,id:9348,x:30829,y:33231,ptovrint:False,ptlb:BuldgeShape,ptin:_BuldgeShape,varname:node_2012,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c3b39832eb62546e396e844ba48af8ba,ntxv:0,isnm:False|UVIN-1198-OUT;n:type:ShaderForge.SFN_Multiply,id:6492,x:30971,y:32558,varname:node_6492,prsc:2|A-7450-RGB,B-6590-RGB;n:type:ShaderForge.SFN_Lerp,id:965,x:31325,y:32817,varname:node_965,prsc:2|A-6590-RGB,B-6492-OUT,T-4210-OUT;n:type:ShaderForge.SFN_Slider,id:4210,x:30659,y:32988,ptovrint:False,ptlb:Glow Color - Texture,ptin:_GlowColorTexture,varname:node_5924,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_TexCoord,id:4592,x:29415,y:32983,varname:node_4592,prsc:2,uv:0;n:type:ShaderForge.SFN_Lerp,id:7743,x:31930,y:32825,varname:node_7743,prsc:2|A-640-OUT,B-8891-OUT,T-7897-OUT;n:type:ShaderForge.SFN_Vector1,id:640,x:31695,y:32960,varname:node_640,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:7897,x:31538,y:33047,ptovrint:False,ptlb:Glow Off - On,ptin:_GlowOffOn,varname:_NormalStrength_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_ValueProperty,id:3605,x:29121,y:33336,ptovrint:False,ptlb:U Speed Bulge,ptin:_USpeedBulge,varname:node_3605,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:9115,x:29121,y:33429,ptovrint:False,ptlb:V Speed Bulge,ptin:_VSpeedBulge,varname:_node_3605_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:682,x:29399,y:33307,varname:node_682,prsc:2|A-3605-OUT,B-9115-OUT;n:type:ShaderForge.SFN_Multiply,id:7152,x:29910,y:33212,varname:node_7152,prsc:2|A-6280-T,B-682-OUT;n:type:ShaderForge.SFN_Time,id:6280,x:29677,y:33124,varname:node_6280,prsc:2;n:type:ShaderForge.SFN_Add,id:1198,x:30179,y:33179,varname:node_1198,prsc:2|A-4592-UVOUT,B-7152-OUT;n:type:ShaderForge.SFN_TexCoord,id:6366,x:29485,y:32280,varname:node_6366,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:6630,x:29191,y:32633,ptovrint:False,ptlb:U Speed Glow,ptin:_USpeedGlow,varname:_USpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:2471,x:29191,y:32726,ptovrint:False,ptlb:V Speed Glow,ptin:_VSpeedGlow,varname:_VSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:3269,x:29469,y:32604,varname:node_3269,prsc:2|A-6630-OUT,B-2471-OUT;n:type:ShaderForge.SFN_Multiply,id:7846,x:29980,y:32509,varname:node_7846,prsc:2|A-1996-T,B-3269-OUT;n:type:ShaderForge.SFN_Time,id:1996,x:29747,y:32421,varname:node_1996,prsc:2;n:type:ShaderForge.SFN_Add,id:6943,x:30249,y:32476,varname:node_6943,prsc:2|A-6366-UVOUT,B-7846-OUT;proporder:6328-6313-9483-3304-396-6316-6666-9348-3605-9115-4594-3969-7450-6590-3860-4210-7897-6630-2471;pass:END;sub:END;*/

Shader "Shader Forge/Liquid" {
    Properties {
        _Albedo ("Albedo", 2D) = "white" {}
        _Colour ("Colour", Color) = (1,0.2391481,0.1102941,1)
        _Gloss ("Gloss", Range(0, 1)) = 0.8
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Normals ("Normals", 2D) = "bump" {}
        _NormalStrength ("Normal Strength", Range(0, 1)) = 0
        _BulgeIntensity ("Bulge Intensity", Float ) = 1
        _BuldgeShape ("BuldgeShape", 2D) = "white" {}
        _USpeedBulge ("U Speed Bulge", Float ) = 0
        _VSpeedBulge ("V Speed Bulge", Float ) = 0
        _Occlusion ("Occlusion", 2D) = "white" {}
        _OcclusionStength ("Occlusion Stength", Range(0, 1)) = 0
        _GlowTexture ("Glow Texture", 2D) = "white" {}
        _GlowColor ("GlowColor", Color) = (0.75,0.9793103,1,1)
        _EmissivePower ("Emissive Power", Float ) = 3
        _GlowColorTexture ("Glow Color - Texture", Range(0, 1)) = 0
        _GlowOffOn ("Glow Off - On", Range(0, 1)) = 0
        _USpeedGlow ("U Speed Glow", Float ) = 0
        _VSpeedGlow ("V Speed Glow", Float ) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform float _BulgeIntensity;
            uniform sampler2D _Albedo; uniform float4 _Albedo_ST;
            uniform float4 _GlowColor;
            uniform sampler2D _Normals; uniform float4 _Normals_ST;
            uniform sampler2D _GlowTexture; uniform float4 _GlowTexture_ST;
            uniform float4 _Colour;
            uniform float _NormalStrength;
            uniform float _EmissivePower;
            uniform sampler2D _Occlusion; uniform float4 _Occlusion_ST;
            uniform float _OcclusionStength;
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
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD10;
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
                float node_9538 = 0.0;
                float4 node_6280 = _Time + _TimeEditor;
                float2 node_682 = float2(_USpeedBulge,_VSpeedBulge);
                float2 node_1198 = (o.uv0+(node_6280.g*node_682));
                float4 _BuldgeShape_var = tex2Dlod(_BuldgeShape,float4(TRANSFORM_TEX(node_1198, _BuldgeShape),0.0,0));
                v.vertex.xyz += lerp(float3(node_9538,node_9538,node_9538),((_BuldgeShape_var.r*_BulgeIntensity)*v.normal),o.vertexColor.r);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normals_var = UnpackNormal(tex2D(_Normals,TRANSFORM_TEX(i.uv0, _Normals)));
                float3 normalLocal = lerp(float3(0,0,1),_Normals_var.rgb,_NormalStrength);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
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
                float4 _Occlusion_var = tex2D(_Occlusion,TRANSFORM_TEX(i.uv0, _Occlusion));
                float node_8660 = lerp(_Occlusion_var.r,0.0,_OcclusionStength);
                float3 specularAO = node_8660;
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float4 _Albedo_var = tex2D(_Albedo,TRANSFORM_TEX(i.uv0, _Albedo));
                float3 diffuseColor = (_Albedo_var.rgb*_Colour.rgb); // Need this for specular when using metallic
                float specularMonochrome;
                float3 specularColor;
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, _Metallic, specularColor, specularMonochrome );
                specularMonochrome = 1-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * (UNITY_PI / 4) );
                float3 directSpecular = 1 * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular) * specularAO;
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 directDiffuse = ((1 +(fd90 - 1)*pow((1.00001-NdotL), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                indirectDiffuse *= node_8660; // Diffuse AO
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float node_640 = 0.0;
                float4 node_1996 = _Time + _TimeEditor;
                float2 node_6943 = (i.uv0+(node_1996.g*float2(_USpeedGlow,_VSpeedGlow)));
                float4 _GlowTexture_var = tex2D(_GlowTexture,TRANSFORM_TEX(node_6943, _GlowTexture));
                float3 node_8891 = (lerp(_GlowColor.rgb,(_GlowTexture_var.rgb*_GlowColor.rgb),_GlowColorTexture)*_EmissivePower); // Glow
                float3 emissive = lerp(float3(node_640,node_640,node_640),node_8891,_GlowOffOn);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
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
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform float _BulgeIntensity;
            uniform sampler2D _Albedo; uniform float4 _Albedo_ST;
            uniform float4 _GlowColor;
            uniform sampler2D _Normals; uniform float4 _Normals_ST;
            uniform sampler2D _GlowTexture; uniform float4 _GlowTexture_ST;
            uniform float4 _Colour;
            uniform float _NormalStrength;
            uniform float _EmissivePower;
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
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
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
                float node_9538 = 0.0;
                float4 node_6280 = _Time + _TimeEditor;
                float2 node_682 = float2(_USpeedBulge,_VSpeedBulge);
                float2 node_1198 = (o.uv0+(node_6280.g*node_682));
                float4 _BuldgeShape_var = tex2Dlod(_BuldgeShape,float4(TRANSFORM_TEX(node_1198, _BuldgeShape),0.0,0));
                v.vertex.xyz += lerp(float3(node_9538,node_9538,node_9538),((_BuldgeShape_var.r*_BulgeIntensity)*v.normal),o.vertexColor.r);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normals_var = UnpackNormal(tex2D(_Normals,TRANSFORM_TEX(i.uv0, _Normals)));
                float3 normalLocal = lerp(float3(0,0,1),_Normals_var.rgb,_NormalStrength);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float4 _Albedo_var = tex2D(_Albedo,TRANSFORM_TEX(i.uv0, _Albedo));
                float3 diffuseColor = (_Albedo_var.rgb*_Colour.rgb); // Need this for specular when using metallic
                float specularMonochrome;
                float3 specularColor;
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, _Metallic, specularColor, specularMonochrome );
                specularMonochrome = 1-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * (UNITY_PI / 4) );
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 directDiffuse = ((1 +(fd90 - 1)*pow((1.00001-NdotL), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
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
                float node_9538 = 0.0;
                float4 node_6280 = _Time + _TimeEditor;
                float2 node_682 = float2(_USpeedBulge,_VSpeedBulge);
                float2 node_1198 = (o.uv0+(node_6280.g*node_682));
                float4 _BuldgeShape_var = tex2Dlod(_BuldgeShape,float4(TRANSFORM_TEX(node_1198, _BuldgeShape),0.0,0));
                v.vertex.xyz += lerp(float3(node_9538,node_9538,node_9538),((_BuldgeShape_var.r*_BulgeIntensity)*v.normal),o.vertexColor.r);
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
            uniform float _Metallic;
            uniform float _Gloss;
            uniform float _BulgeIntensity;
            uniform sampler2D _Albedo; uniform float4 _Albedo_ST;
            uniform float4 _GlowColor;
            uniform sampler2D _GlowTexture; uniform float4 _GlowTexture_ST;
            uniform float4 _Colour;
            uniform float _EmissivePower;
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
                float node_9538 = 0.0;
                float4 node_6280 = _Time + _TimeEditor;
                float2 node_682 = float2(_USpeedBulge,_VSpeedBulge);
                float2 node_1198 = (o.uv0+(node_6280.g*node_682));
                float4 _BuldgeShape_var = tex2Dlod(_BuldgeShape,float4(TRANSFORM_TEX(node_1198, _BuldgeShape),0.0,0));
                v.vertex.xyz += lerp(float3(node_9538,node_9538,node_9538),((_BuldgeShape_var.r*_BulgeIntensity)*v.normal),o.vertexColor.r);
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
                
                float node_640 = 0.0;
                float4 node_1996 = _Time + _TimeEditor;
                float2 node_6943 = (i.uv0+(node_1996.g*float2(_USpeedGlow,_VSpeedGlow)));
                float4 _GlowTexture_var = tex2D(_GlowTexture,TRANSFORM_TEX(node_6943, _GlowTexture));
                float3 node_8891 = (lerp(_GlowColor.rgb,(_GlowTexture_var.rgb*_GlowColor.rgb),_GlowColorTexture)*_EmissivePower); // Glow
                o.Emission = lerp(float3(node_640,node_640,node_640),node_8891,_GlowOffOn);
                
                float4 _Albedo_var = tex2D(_Albedo,TRANSFORM_TEX(i.uv0, _Albedo));
                float3 diffColor = (_Albedo_var.rgb*_Colour.rgb);
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, _Metallic, specColor, specularMonochrome );
                float roughness = 1.0 - _Gloss;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
