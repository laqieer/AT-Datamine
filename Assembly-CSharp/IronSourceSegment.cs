// Decompiled with JetBrains decompiler
// Type: IronSourceSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000071")]
public class IronSourceSegment
{
  [Token(Token = "0x4000218")]
  [FieldOffset(Offset = "0x10")]
  public int age;
  [Token(Token = "0x4000219")]
  [FieldOffset(Offset = "0x18")]
  public string gender;
  [Token(Token = "0x400021A")]
  [FieldOffset(Offset = "0x20")]
  public int level;
  [Token(Token = "0x400021B")]
  [FieldOffset(Offset = "0x24")]
  public int isPaying;
  [Token(Token = "0x400021C")]
  [FieldOffset(Offset = "0x28")]
  public long userCreationDate;
  [Token(Token = "0x400021D")]
  [FieldOffset(Offset = "0x30")]
  public double iapt;
  [Token(Token = "0x400021E")]
  [FieldOffset(Offset = "0x38")]
  public string segmentName;
  [Token(Token = "0x400021F")]
  [FieldOffset(Offset = "0x40")]
  public Dictionary<string, string> customs;

  [Token(Token = "0x60003E5")]
  [Address(RVA = "0x44ACA60", Offset = "0x44ACA60", VA = "0x44ACA60")]
  public IronSourceSegment()
  {
  }

  [Token(Token = "0x60003E6")]
  [Address(RVA = "0x44ACAF4", Offset = "0x44ACAF4", VA = "0x44ACAF4")]
  public void setCustom(string key, string value)
  {
  }

  [Token(Token = "0x60003E7")]
  [Address(RVA = "0x44ACB5C", Offset = "0x44ACB5C", VA = "0x44ACB5C")]
  public Dictionary<string, string> getSegmentAsDict() => (Dictionary<string, string>) null;
}
