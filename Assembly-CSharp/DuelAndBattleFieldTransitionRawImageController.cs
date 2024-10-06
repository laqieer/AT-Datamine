// Decompiled with JetBrains decompiler
// Type: DuelAndBattleFieldTransitionRawImageController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20000F1")]
[ExecuteInEditMode]
[RequireComponent(typeof (RawImage))]
public class DuelAndBattleFieldTransitionRawImageController : MonoBehaviour
{
  [Token(Token = "0x4000456")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Color allyTriangleColor;
  [Token(Token = "0x4000457")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Color enemyTriangleColor;
  [Token(Token = "0x4000458")]
  [FieldOffset(Offset = "0x38")]
  public bool uFlip;
  [Token(Token = "0x4000459")]
  [FieldOffset(Offset = "0x39")]
  public bool vFlip;
  [Token(Token = "0x400045A")]
  [FieldOffset(Offset = "0x3A")]
  public bool radial;
  [Token(Token = "0x400045B")]
  [FieldOffset(Offset = "0x3C")]
  [Range(0.0f, 1f)]
  public float dissolve1;
  [Token(Token = "0x400045C")]
  [FieldOffset(Offset = "0x40")]
  [Range(0.0f, 1f)]
  public float dissolve2;
  [Token(Token = "0x400045D")]
  [FieldOffset(Offset = "0x44")]
  [Range(0.0f, 1f)]
  public float dissolve3;
  [Token(Token = "0x400045E")]
  [FieldOffset(Offset = "0x48")]
  [Range(0.0f, 0.15f)]
  public float glitchX;
  [Token(Token = "0x400045F")]
  [FieldOffset(Offset = "0x4C")]
  [Range(0.0f, 0.15f)]
  public float glitchY;
  [Token(Token = "0x4000460")]
  [FieldOffset(Offset = "0x50")]
  [Range(0.0f, 1f)]
  public float noisePower;
  [Token(Token = "0x4000461")]
  [FieldOffset(Offset = "0x54")]
  [Range(0.0f, 1f)]
  public float dissolve1NoAlpha;
  [Token(Token = "0x4000462")]
  [FieldOffset(Offset = "0x58")]
  [Range(0.0f, 1f)]
  public float dissolve2NoAlpha;
  [Token(Token = "0x4000463")]
  [FieldOffset(Offset = "0x5C")]
  [Range(0.0f, 1f)]
  public float dissolve3NoAlpha;
  [Token(Token = "0x4000464")]
  [FieldOffset(Offset = "0x0")]
  private static readonly int triangleColorPropertyID;
  [Token(Token = "0x4000465")]
  [FieldOffset(Offset = "0x4")]
  private static readonly int uFlipPropertyID;
  [Token(Token = "0x4000466")]
  [FieldOffset(Offset = "0x8")]
  private static readonly int vFlipPropertyID;
  [Token(Token = "0x4000467")]
  [FieldOffset(Offset = "0xC")]
  private static readonly int radialPropertyID;
  [Token(Token = "0x4000468")]
  [FieldOffset(Offset = "0x10")]
  private static readonly int dissolve1PropertyID;
  [Token(Token = "0x4000469")]
  [FieldOffset(Offset = "0x14")]
  private static readonly int dissolve2PropertyID;
  [Token(Token = "0x400046A")]
  [FieldOffset(Offset = "0x18")]
  private static readonly int dissolve3PropertyID;
  [Token(Token = "0x400046B")]
  [FieldOffset(Offset = "0x1C")]
  private static readonly int glitchXPropertyID;
  [Token(Token = "0x400046C")]
  [FieldOffset(Offset = "0x20")]
  private static readonly int glitchYPropertyID;
  [Token(Token = "0x400046D")]
  [FieldOffset(Offset = "0x24")]
  private static readonly int noisePowerPropertyID;
  [Token(Token = "0x400046E")]
  [FieldOffset(Offset = "0x28")]
  private static readonly int dissolve1NoAlphaPropertyID;
  [Token(Token = "0x400046F")]
  [FieldOffset(Offset = "0x2C")]
  private static readonly int dissolve2NoAlphaPropertyID;
  [Token(Token = "0x4000470")]
  [FieldOffset(Offset = "0x30")]
  private static readonly int dissolve3NoAlphaPropertyID;
  [Token(Token = "0x4000471")]
  [FieldOffset(Offset = "0x60")]
  private Material targetMaterial;

  [Token(Token = "0x60006CE")]
  [Address(RVA = "0x4187CD4", Offset = "0x4187CD4", VA = "0x4187CD4")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60006CF")]
  [Address(RVA = "0x4187D3C", Offset = "0x4187D3C", VA = "0x4187D3C")]
  private void Update()
  {
  }

  [Token(Token = "0x60006D0")]
  [Address(RVA = "0x4187FCC", Offset = "0x4187FCC", VA = "0x4187FCC")]
  public void Clear()
  {
  }

  [Token(Token = "0x60006D1")]
  [Address(RVA = "0x4187D40", Offset = "0x4187D40", VA = "0x4187D40")]
  private void UpdateMaterialProperties()
  {
  }

  [Token(Token = "0x60006D2")]
  [Address(RVA = "0x4187FE0", Offset = "0x4187FE0", VA = "0x4187FE0")]
  public void SetTriangleColor(bool isAlly)
  {
  }

  [Token(Token = "0x60006D3")]
  [Address(RVA = "0x4188108", Offset = "0x4188108", VA = "0x4188108")]
  [ContextMenu("Set to Ally Triangle Color")]
  public void SetAllyTriangleColor()
  {
  }

  [Token(Token = "0x60006D4")]
  [Address(RVA = "0x4188110", Offset = "0x4188110", VA = "0x4188110")]
  [ContextMenu("Set to Enemy Triangle Color")]
  public void SetEnemyTriangleColor()
  {
  }

  [Token(Token = "0x60006D5")]
  [Address(RVA = "0x4188118", Offset = "0x4188118", VA = "0x4188118")]
  public DuelAndBattleFieldTransitionRawImageController()
  {
  }

  [Token(Token = "0x60006D6")]
  [Address(RVA = "0x418812C", Offset = "0x418812C", VA = "0x418812C")]
  static DuelAndBattleFieldTransitionRawImageController()
  {
  }
}
