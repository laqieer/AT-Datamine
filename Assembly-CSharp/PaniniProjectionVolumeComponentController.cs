// Decompiled with JetBrains decompiler
// Type: PaniniProjectionVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002F5")]
[ExecuteInEditMode]
public class PaniniProjectionVolumeComponentController : 
  BaseVolumeComponentController<PaniniProjection>
{
  [Token(Token = "0x4001168")]
  [FieldOffset(Offset = "0x29")]
  public bool distanceOverrideState;
  [Token(Token = "0x4001169")]
  [FieldOffset(Offset = "0x2C")]
  [Range(0.0f, 1f)]
  public float distance;
  [Token(Token = "0x400116A")]
  [FieldOffset(Offset = "0x30")]
  public bool cropToFitOverrideState;
  [Token(Token = "0x400116B")]
  [FieldOffset(Offset = "0x34")]
  [Range(0.0f, 1f)]
  public float cropToFit;

  [Token(Token = "0x6001241")]
  [Address(RVA = "0x27DEB6C", Offset = "0x27DEB6C", VA = "0x27DEB6C", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001242")]
  [Address(RVA = "0x27DEC40", Offset = "0x27DEC40", VA = "0x27DEC40")]
  public PaniniProjectionVolumeComponentController()
  {
  }
}
