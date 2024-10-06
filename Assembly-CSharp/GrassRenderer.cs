// Decompiled with JetBrains decompiler
// Type: GrassRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200030D")]
[RequireComponent(typeof (MeshFilter))]
[DisallowMultipleComponent]
public class GrassRenderer : MonoBehaviour
{
  [Token(Token = "0x4001231")]
  private const int MAX_SEGMANT_NUM = 5;
  [Token(Token = "0x4001232")]
  private const int SOURCE_VERTCOLOR_STRIDE = 24;
  [Token(Token = "0x4001233")]
  private const int SOURCE_TRI_STRIDE = 4;
  [Token(Token = "0x4001234")]
  private const int SOURCE_VERT_STRIDE = 20;
  [Token(Token = "0x4001235")]
  private const int SOURCE_GRASS_STRIDE = 12;
  [Token(Token = "0x4001236")]
  private const int DRAW_STRIDE = 84;
  [Token(Token = "0x4001237")]
  private const int INDIRECT_ARGS_STRIDE = 16;
  [Token(Token = "0x4001238")]
  private const float WIND_PERIOD = 1f;
  [Token(Token = "0x4001239")]
  private const float WIND_SCALE = 10f;
  [Token(Token = "0x400123A")]
  private const float LIMIT_TIME = 3600f;
  [Token(Token = "0x400123B")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  [HideInInspector]
  private ComputeShader grassPositionComputeShader;
  [Token(Token = "0x400123C")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  [HideInInspector]
  private ComputeShader fixupComputeShader;
  [Token(Token = "0x400123D")]
  [FieldOffset(Offset = "0x28")]
  [HideInInspector]
  [SerializeField]
  private ComputeShader grassAComputeShader;
  [Token(Token = "0x400123E")]
  [FieldOffset(Offset = "0x30")]
  [HideInInspector]
  [SerializeField]
  private ComputeShader grassBCComputeShader;
  [Token(Token = "0x400123F")]
  [FieldOffset(Offset = "0x38")]
  [HideInInspector]
  [SerializeField]
  private Shader grassShader;
  [Token(Token = "0x4001240")]
  [FieldOffset(Offset = "0x40")]
  public Texture2D grassTexture;
  [Token(Token = "0x4001241")]
  [FieldOffset(Offset = "0x48")]
  [Range(0.0f, 1f)]
  public float alphaCutoff;
  [Token(Token = "0x4001242")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private GrassRenderer.GrassASettings grassASettings;
  [Token(Token = "0x4001243")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private GrassRenderer.GrassBSettings grassBSettings;
  [Token(Token = "0x4001244")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private GrassRenderer.GrassCSettings grassCSettings;
  [Token(Token = "0x4001245")]
  [FieldOffset(Offset = "0x68")]
  public float cameraLODMin;
  [Token(Token = "0x4001246")]
  [FieldOffset(Offset = "0x6C")]
  public float cameraLODMax;
  [Token(Token = "0x4001247")]
  [FieldOffset(Offset = "0x70")]
  [Range(0.1f, 10f)]
  public float cameraLODFactor;
  [Token(Token = "0x4001248")]
  [FieldOffset(Offset = "0x74")]
  public bool recieveShadow;
  [Token(Token = "0x4001249")]
  [FieldOffset(Offset = "0x75")]
  public bool recieveCloudShadow;
  [Token(Token = "0x400124A")]
  [FieldOffset(Offset = "0x76")]
  public bool useFog;
  [Token(Token = "0x400124B")]
  [FieldOffset(Offset = "0x77")]
  private bool initialized;
  [Token(Token = "0x400124C")]
  [FieldOffset(Offset = "0x78")]
  private bool drawGrassA;
  [Token(Token = "0x400124D")]
  [FieldOffset(Offset = "0x79")]
  private bool drawGrassB;
  [Token(Token = "0x400124E")]
  [FieldOffset(Offset = "0x7A")]
  private bool drawGrassC;
  [Token(Token = "0x400124F")]
  [FieldOffset(Offset = "0x80")]
  private Mesh sourceMesh;
  [Token(Token = "0x4001250")]
  [FieldOffset(Offset = "0x88")]
  private ComputeBuffer sourceVertBuffer;
  [Token(Token = "0x4001251")]
  [FieldOffset(Offset = "0x90")]
  private ComputeBuffer sourceTriBuffer;
  [Token(Token = "0x4001252")]
  [FieldOffset(Offset = "0x98")]
  private ComputeBuffer sourceGrassABuffer;
  [Token(Token = "0x4001253")]
  [FieldOffset(Offset = "0xA0")]
  private ComputeBuffer sourceGrassBCBuffer;
  [Token(Token = "0x4001254")]
  [FieldOffset(Offset = "0xA8")]
  private ComputeBuffer drawBufferA;
  [Token(Token = "0x4001255")]
  [FieldOffset(Offset = "0xB0")]
  private ComputeBuffer drawBufferBC;
  [Token(Token = "0x4001256")]
  [FieldOffset(Offset = "0xB8")]
  private ComputeBuffer argsBufferA;
  [Token(Token = "0x4001257")]
  [FieldOffset(Offset = "0xC0")]
  private ComputeBuffer argsBufferBC;
  [Token(Token = "0x4001258")]
  [FieldOffset(Offset = "0xC8")]
  private ComputeShader instantiatedGrassAComputeShader;
  [Token(Token = "0x4001259")]
  [FieldOffset(Offset = "0xD0")]
  private ComputeShader instantiatedGrassBCComputeShader;
  [Token(Token = "0x400125A")]
  [FieldOffset(Offset = "0xD8")]
  private ComputeShader instantiatedFixupComputeShader;
  [Token(Token = "0x400125B")]
  [FieldOffset(Offset = "0xE0")]
  private int idFixupKernelA;
  [Token(Token = "0x400125C")]
  [FieldOffset(Offset = "0xE4")]
  private int idFixupKernelBC;
  [Token(Token = "0x400125D")]
  [FieldOffset(Offset = "0xE8")]
  private Material instantiatedMaterialA;
  [Token(Token = "0x400125E")]
  [FieldOffset(Offset = "0xF0")]
  private Material instantiatedMaterialBC;
  [Token(Token = "0x400125F")]
  [FieldOffset(Offset = "0xF8")]
  private int idGrassKernelA;
  [Token(Token = "0x4001260")]
  [FieldOffset(Offset = "0xFC")]
  private int idGrassKernelBC;
  [Token(Token = "0x4001261")]
  [FieldOffset(Offset = "0x100")]
  private int dispatchSizeA;
  [Token(Token = "0x4001262")]
  [FieldOffset(Offset = "0x104")]
  private int dispatchSizeBC;
  [Token(Token = "0x4001263")]
  [FieldOffset(Offset = "0x108")]
  private Bounds bounds;
  [Token(Token = "0x4001264")]
  [FieldOffset(Offset = "0x120")]
  private int[] argsBufferReset;
  [Token(Token = "0x4001265")]
  [FieldOffset(Offset = "0x128")]
  private int[] argsBufferGet;
  [Token(Token = "0x4001266")]
  [FieldOffset(Offset = "0x130")]
  private float time;
  [Token(Token = "0x4001267")]
  [FieldOffset(Offset = "0x138")]
  private Plane[] planes;

  [Token(Token = "0x6001293")]
  [Address(RVA = "0x27E5A68", Offset = "0x27E5A68", VA = "0x27E5A68")]
  private Material InstantiateMaterial(Shader shader) => (Material) null;

  [Token(Token = "0x6001294")]
  [Address(RVA = "0x27E5BAC", Offset = "0x27E5BAC", VA = "0x27E5BAC")]
  private GrassRenderer.GrassVertex[] RayCastForGrassByCS(
    ComputeShader cs,
    GrassRenderer.GrassType type)
  {
    return (GrassRenderer.GrassVertex[]) null;
  }

  [Token(Token = "0x6001295")]
  [Address(RVA = "0x27E6374", Offset = "0x27E6374", VA = "0x27E6374")]
  private int Gettime() => new int();

  [Token(Token = "0x6001296")]
  [Address(RVA = "0x27E6454", Offset = "0x27E6454", VA = "0x27E6454")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6001297")]
  [Address(RVA = "0x27E6458", Offset = "0x27E6458", VA = "0x27E6458")]
  private void Initialize()
  {
  }

  [Token(Token = "0x6001298")]
  [Address(RVA = "0x27E80F4", Offset = "0x27E80F4", VA = "0x27E80F4")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6001299")]
  [Address(RVA = "0x27E82A8", Offset = "0x27E82A8", VA = "0x27E82A8")]
  private void ReleaseAndDestory()
  {
  }

  [Token(Token = "0x600129A")]
  [Address(RVA = "0x27E80F8", Offset = "0x27E80F8", VA = "0x27E80F8")]
  public Bounds TransformBounds(Bounds boundsOS) => new Bounds();

  [Token(Token = "0x600129B")]
  [Address(RVA = "0x27E8420", Offset = "0x27E8420", VA = "0x27E8420")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x600129C")]
  [Address(RVA = "0x27E8B80", Offset = "0x27E8B80", VA = "0x27E8B80")]
  public GrassRenderer()
  {
  }

  [Token(Token = "0x200030E")]
  private enum GrassType
  {
    [Token(Token = "0x4001269")] A,
    [Token(Token = "0x400126A")] B,
    [Token(Token = "0x400126B")] C,
  }

  [Token(Token = "0x200030F")]
  private enum RGB
  {
    [Token(Token = "0x400126D")] R = 1,
    [Token(Token = "0x400126E")] G = 2,
    [Token(Token = "0x400126F")] B = 4,
    [Token(Token = "0x4001270")] K = 8,
    [Token(Token = "0x4001271")] N = 16, // 0x00000010
  }

  [Token(Token = "0x2000310")]
  private enum LightmapEncoding
  {
    [Token(Token = "0x4001273")] High,
    [Token(Token = "0x4001274")] Normal,
    [Token(Token = "0x4001275")] Low,
  }

  [Token(Token = "0x2000311")]
  [Serializable]
  public class GrassSettings
  {
    [Token(Token = "0x4001276")]
    [FieldOffset(Offset = "0x10")]
    public int vertexColor;
    [Token(Token = "0x4001277")]
    [FieldOffset(Offset = "0x14")]
    [Range(0.0f, 10f)]
    public float density;
    [Token(Token = "0x4001278")]
    [FieldOffset(Offset = "0x18")]
    [Range(1f, 5f)]
    public int maxSegments;
    [Token(Token = "0x4001279")]
    [FieldOffset(Offset = "0x1C")]
    [Range(0.0f, 1f)]
    public float maxBendAngle;
    [Token(Token = "0x400127A")]
    [FieldOffset(Offset = "0x20")]
    [Range(0.0001f, 1f)]
    public float bladeCurvature;
    [Token(Token = "0x400127B")]
    [FieldOffset(Offset = "0x24")]
    public float bladeHeight;
    [Token(Token = "0x400127C")]
    [FieldOffset(Offset = "0x28")]
    public float bladeHeightVariance;
    [Token(Token = "0x400127D")]
    [FieldOffset(Offset = "0x2C")]
    public float bladeWidth;
    [Token(Token = "0x400127E")]
    [FieldOffset(Offset = "0x30")]
    public float bladeWidthVariance;
    [Token(Token = "0x400127F")]
    [FieldOffset(Offset = "0x34")]
    [Range(0.0f, 1f)]
    public float posVariance;
    [Token(Token = "0x4001280")]
    [FieldOffset(Offset = "0x38")]
    [Range(0.0f, 1f)]
    public float windAmplitude;

    [Token(Token = "0x600129D")]
    [Address(RVA = "0x285C068", Offset = "0x285C068", VA = "0x285C068")]
    public GrassSettings()
    {
    }
  }

  [Token(Token = "0x2000312")]
  [Serializable]
  public class GrassASettings : GrassRenderer.GrassSettings
  {
    [Token(Token = "0x4001281")]
    [FieldOffset(Offset = "0x3C")]
    public Color BaseColor;
    [Token(Token = "0x4001282")]
    [FieldOffset(Offset = "0x4C")]
    public Color TipColor;

    [Token(Token = "0x600129E")]
    [Address(RVA = "0x285C094", Offset = "0x285C094", VA = "0x285C094")]
    public GrassASettings()
    {
    }
  }

  [Token(Token = "0x2000313")]
  [Serializable]
  public class GrassBSettings : GrassRenderer.GrassSettings
  {
    [Token(Token = "0x600129F")]
    [Address(RVA = "0x285C0F0", Offset = "0x285C0F0", VA = "0x285C0F0")]
    public GrassBSettings()
    {
    }
  }

  [Token(Token = "0x2000314")]
  [Serializable]
  public class GrassCSettings : GrassRenderer.GrassSettings
  {
    [Token(Token = "0x60012A0")]
    [Address(RVA = "0x285C134", Offset = "0x285C134", VA = "0x285C134")]
    public GrassCSettings()
    {
    }
  }

  [Token(Token = "0x2000315")]
  private struct SourceVertexColor
  {
    [Token(Token = "0x4001283")]
    [FieldOffset(Offset = "0x0")]
    public Vector3 position;
    [Token(Token = "0x4001284")]
    [FieldOffset(Offset = "0xC")]
    public Vector3 color;
  }

  [Token(Token = "0x2000316")]
  private struct SourceVertex
  {
    [Token(Token = "0x4001285")]
    [FieldOffset(Offset = "0x0")]
    public Vector3 position;
    [Token(Token = "0x4001286")]
    [FieldOffset(Offset = "0xC")]
    public Vector2 uv;
  }

  [Token(Token = "0x2000317")]
  private struct GrassVertex
  {
    [Token(Token = "0x4001287")]
    [FieldOffset(Offset = "0x0")]
    public Vector2 uv;
    [Token(Token = "0x4001288")]
    [FieldOffset(Offset = "0x8")]
    public int index;
  }
}
