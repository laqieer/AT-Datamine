// Decompiled with JetBrains decompiler
// Type: SetupMaterialForTriangleDissolve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000DF")]
public class SetupMaterialForTriangleDissolve : MonoBehaviour
{
  [Token(Token = "0x40003DF")]
  [FieldOffset(Offset = "0x18")]
  private List<Material> materials;
  [Token(Token = "0x40003E0")]
  [FieldOffset(Offset = "0x20")]
  private int dissolve1ID;
  [Token(Token = "0x40003E1")]
  [FieldOffset(Offset = "0x24")]
  private int dissolve3ID;
  [Token(Token = "0x40003E2")]
  [FieldOffset(Offset = "0x28")]
  private int colorID;
  [Token(Token = "0x40003E3")]
  [FieldOffset(Offset = "0x2C")]
  [Range(0.0f, 1f)]
  public float dissolve1;
  [Token(Token = "0x40003E4")]
  [FieldOffset(Offset = "0x30")]
  [Range(0.0f, 1f)]
  public float dissolve3;
  [Token(Token = "0x40003E5")]
  [FieldOffset(Offset = "0x34")]
  [ColorUsage(false, true)]
  public Color triangleColor;
  [Token(Token = "0x40003E6")]
  [FieldOffset(Offset = "0x44")]
  public bool removeMaterialOnDisable;

  [Token(Token = "0x6000679")]
  [Address(RVA = "0x41830C8", Offset = "0x41830C8", VA = "0x41830C8")]
  public void Initialize()
  {
  }

  [Token(Token = "0x600067A")]
  [Address(RVA = "0x4183300", Offset = "0x4183300", VA = "0x4183300")]
  public void ForceDissolve()
  {
  }

  [Token(Token = "0x600067B")]
  [Address(RVA = "0x4183470", Offset = "0x4183470", VA = "0x4183470")]
  public void ForceResolve()
  {
  }

  [Token(Token = "0x600067C")]
  [Address(RVA = "0x41835DC", Offset = "0x41835DC", VA = "0x41835DC")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600067D")]
  [Address(RVA = "0x41835E0", Offset = "0x41835E0", VA = "0x41835E0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x600067E")]
  [Address(RVA = "0x4183748", Offset = "0x4183748", VA = "0x4183748")]
  private void Start()
  {
  }

  [Token(Token = "0x600067F")]
  [Address(RVA = "0x418374C", Offset = "0x418374C", VA = "0x418374C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000680")]
  [Address(RVA = "0x41838D0", Offset = "0x41838D0", VA = "0x41838D0")]
  private void SetupMaterialWithRenderType(Material material)
  {
  }

  [Token(Token = "0x6000681")]
  [Address(RVA = "0x4183BAC", Offset = "0x4183BAC", VA = "0x4183BAC")]
  private void SetupMaterialWithPass(Material material)
  {
  }

  [Token(Token = "0x6000682")]
  [Address(RVA = "0x4183C84", Offset = "0x4183C84", VA = "0x4183C84")]
  public void TurnOn()
  {
  }

  [Token(Token = "0x6000683")]
  [Address(RVA = "0x4183E4C", Offset = "0x4183E4C", VA = "0x4183E4C")]
  public void TurnOff()
  {
  }

  [Token(Token = "0x6000684")]
  [Address(RVA = "0x4184000", Offset = "0x4184000", VA = "0x4184000")]
  public SetupMaterialForTriangleDissolve()
  {
  }
}
