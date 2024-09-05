// Decompiled with JetBrains decompiler
// Type: UpdateBlendShape
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000E0")]
public class UpdateBlendShape : MonoBehaviour
{
  [Token(Token = "0x40003E7")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private float FaceSideMin;
  [Token(Token = "0x40003E8")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private float FaceSideMax;
  [Token(Token = "0x40003E9")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private float FaceLowMin;
  [Token(Token = "0x40003EA")]
  [FieldOffset(Offset = "0x24")]
  [SerializeField]
  private float FaceLowMax;
  [Token(Token = "0x40003EB")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private float EyeSideMin;
  [Token(Token = "0x40003EC")]
  [FieldOffset(Offset = "0x2C")]
  [SerializeField]
  private float EyeSideMax;
  [Token(Token = "0x40003ED")]
  [FieldOffset(Offset = "0x30")]
  private Camera camera;
  [Token(Token = "0x40003EE")]
  [FieldOffset(Offset = "0x38")]
  private Transform head;
  [Token(Token = "0x40003EF")]
  [FieldOffset(Offset = "0x40")]
  private SkinnedMeshRenderer face;
  [Token(Token = "0x40003F0")]
  [FieldOffset(Offset = "0x48")]
  private SkinnedMeshRenderer eye;
  [Token(Token = "0x40003F1")]
  [FieldOffset(Offset = "0x50")]
  private int indexFaceSide;
  [Token(Token = "0x40003F2")]
  [FieldOffset(Offset = "0x54")]
  private int indexFaceLow;
  [Token(Token = "0x40003F3")]
  [FieldOffset(Offset = "0x58")]
  private int indexEyeSide;

  [Token(Token = "0x6000685")]
  [Address(RVA = "0x4184090", Offset = "0x4184090", VA = "0x4184090")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000686")]
  [Address(RVA = "0x4184450", Offset = "0x4184450", VA = "0x4184450")]
  private void Update()
  {
  }

  [Token(Token = "0x6000687")]
  [Address(RVA = "0x4184A74", Offset = "0x4184A74", VA = "0x4184A74")]
  public UpdateBlendShape()
  {
  }
}
