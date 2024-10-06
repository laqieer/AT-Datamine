// Decompiled with JetBrains decompiler
// Type: DuelCharacterDamageResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x200015F")]
[Serializable]
public class DuelCharacterDamageResult
{
  [Token(Token = "0x40008D5")]
  [FieldOffset(Offset = "0x10")]
  public int newHP;
  [Token(Token = "0x40008D6")]
  [FieldOffset(Offset = "0x14")]
  public int oldHP;
  [Token(Token = "0x40008D7")]
  [FieldOffset(Offset = "0x18")]
  public bool isCritical;
  [Token(Token = "0x40008D8")]
  [FieldOffset(Offset = "0x19")]
  public bool isHit;

  [Token(Token = "0x60009D3")]
  [Address(RVA = "0x47683A4", Offset = "0x47683A4", VA = "0x47683A4")]
  public DuelCharacterDamageResult()
  {
  }
}
