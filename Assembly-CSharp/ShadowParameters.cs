// Decompiled with JetBrains decompiler
// Type: ShadowParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x20000B4")]
[DisallowMultipleComponent]
[RequireComponent(typeof (Light))]
public class ShadowParameters : MonoBehaviour
{
  [Token(Token = "0x40002C8")]
  [FieldOffset(Offset = "0x0")]
  private static readonly float LimitTime;
  [Token(Token = "0x40002C9")]
  [FieldOffset(Offset = "0x4")]
  private static readonly float Epsilon;
  [Token(Token = "0x40002CA")]
  [FieldOffset(Offset = "0x8")]
  private static readonly float SpeedAdjustment;
  [Token(Token = "0x40002CB")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  public bool isActive;
  [Token(Token = "0x40002CC")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  [ColorUsage(true, true)]
  private Color noShadowColor;
  [Token(Token = "0x40002CD")]
  [FieldOffset(Offset = "0x2C")]
  [SerializeField]
  private Color shadowColor;
  [Token(Token = "0x40002CE")]
  [FieldOffset(Offset = "0x3C")]
  [SerializeField]
  private ShadowParameters.ShadowBlendMode shadowBlend;
  [Token(Token = "0x40002CF")]
  [FieldOffset(Offset = "0x40")]
  [Range(1f, 10f)]
  [SerializeField]
  private float power;
  [Token(Token = "0x40002D0")]
  [FieldOffset(Offset = "0x44")]
  [SerializeField]
  private bool enableCloudShadow;
  [Token(Token = "0x40002D1")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private Texture2D texture;
  [Token(Token = "0x40002D2")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private float scaleX;
  [Token(Token = "0x40002D3")]
  [FieldOffset(Offset = "0x54")]
  [SerializeField]
  private float scaleY;
  [Token(Token = "0x40002D4")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private Color cloudShadowColor;
  [Token(Token = "0x40002D5")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private ShadowParameters.ShadowBlendMode cloudShadowBlend;
  [Token(Token = "0x40002D6")]
  [FieldOffset(Offset = "0x6C")]
  [SerializeField]
  [Range(0.0f, 1f)]
  private float powerToward;
  [Token(Token = "0x40002D7")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  [Range(0.0f, 1f)]
  private float powerAway;
  [Token(Token = "0x40002D8")]
  [FieldOffset(Offset = "0x74")]
  [SerializeField]
  private float speedX;
  [Token(Token = "0x40002D9")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private float speedY;
  [Token(Token = "0x40002DA")]
  [FieldOffset(Offset = "0x7C")]
  private float time;
  [Token(Token = "0x40002DB")]
  [FieldOffset(Offset = "0x80")]
  private bool init;
  [Token(Token = "0x40002DC")]
  [FieldOffset(Offset = "0x84")]
  private int idNoShadowColor;
  [Token(Token = "0x40002DD")]
  [FieldOffset(Offset = "0x88")]
  private int idCharaShadowColor;
  [Token(Token = "0x40002DE")]
  [FieldOffset(Offset = "0x8C")]
  private int idCharaShadowPowerBlend;
  [Token(Token = "0x40002DF")]
  [FieldOffset(Offset = "0x90")]
  private int idCloudShadowMatrix;
  [Token(Token = "0x40002E0")]
  [FieldOffset(Offset = "0x94")]
  private int idCloudShadowTex;
  [Token(Token = "0x40002E1")]
  [FieldOffset(Offset = "0x98")]
  private int idCloudShadowScaleOffset;
  [Token(Token = "0x40002E2")]
  [FieldOffset(Offset = "0x9C")]
  private int idCloudShadowColor;
  [Token(Token = "0x40002E3")]
  [FieldOffset(Offset = "0xA0")]
  private int idCloudShadowPowerBlend;
  [Token(Token = "0x40002E4")]
  [FieldOffset(Offset = "0xA4")]
  private int BGLayerMask;

  [Token(Token = "0x600058C")]
  [Address(RVA = "0x44B3418", Offset = "0x44B3418", VA = "0x44B3418")]
  private void Update()
  {
  }

  [Token(Token = "0x600058D")]
  [Address(RVA = "0x44B34C8", Offset = "0x44B34C8", VA = "0x44B34C8")]
  private void Start()
  {
  }

  [Token(Token = "0x600058E")]
  [Address(RVA = "0x44B370C", Offset = "0x44B370C", VA = "0x44B370C")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600058F")]
  [Address(RVA = "0x44B37B0", Offset = "0x44B37B0", VA = "0x44B37B0")]
  private bool MainLightCastShadows(ScriptableRenderContext context, Camera camera) => new bool();

  [Token(Token = "0x6000590")]
  [Address(RVA = "0x44B3B50", Offset = "0x44B3B50", VA = "0x44B3B50")]
  private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
  {
  }

  [Token(Token = "0x6000591")]
  [Address(RVA = "0x44B3DCC", Offset = "0x44B3DCC", VA = "0x44B3DCC")]
  public ShadowParameters()
  {
  }

  [Token(Token = "0x6000592")]
  [Address(RVA = "0x44B3E1C", Offset = "0x44B3E1C", VA = "0x44B3E1C")]
  static ShadowParameters()
  {
  }

  [Token(Token = "0x20000B5")]
  private enum ShadowBlendMode
  {
    [Token(Token = "0x40002E6")] Multiply,
    [Token(Token = "0x40002E7")] Darken,
  }
}
