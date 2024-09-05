// Decompiled with JetBrains decompiler
// Type: BGParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000AB")]
[DisallowMultipleComponent]
public class BGParameters : MonoBehaviour
{
  [Token(Token = "0x40002BD")]
  [FieldOffset(Offset = "0x0")]
  private static readonly Color HardlightNeutral;
  [Token(Token = "0x40002BE")]
  [FieldOffset(Offset = "0x18")]
  [Range(0.0f, 1f)]
  public float HardlightBlend;
  [Token(Token = "0x40002BF")]
  [FieldOffset(Offset = "0x1C")]
  public Color HardlightColor;

  [Token(Token = "0x6000573")]
  [Address(RVA = "0x44B28E0", Offset = "0x44B28E0", VA = "0x44B28E0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000574")]
  [Address(RVA = "0x44B297C", Offset = "0x44B297C", VA = "0x44B297C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000575")]
  [Address(RVA = "0x44B29F8", Offset = "0x44B29F8", VA = "0x44B29F8")]
  public BGParameters()
  {
  }

  [Token(Token = "0x6000576")]
  [Address(RVA = "0x44B2A0C", Offset = "0x44B2A0C", VA = "0x44B2A0C")]
  static BGParameters()
  {
  }
}
