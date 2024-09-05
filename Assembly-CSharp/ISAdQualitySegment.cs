// Decompiled with JetBrains decompiler
// Type: ISAdQualitySegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000091")]
public class ISAdQualitySegment
{
  [Token(Token = "0x4000275")]
  [FieldOffset(Offset = "0x10")]
  public string name;
  [Token(Token = "0x4000276")]
  [FieldOffset(Offset = "0x18")]
  public int age;
  [Token(Token = "0x4000277")]
  [FieldOffset(Offset = "0x20")]
  public string gender;
  [Token(Token = "0x4000278")]
  [FieldOffset(Offset = "0x28")]
  public int level;
  [Token(Token = "0x4000279")]
  [FieldOffset(Offset = "0x2C")]
  public int isPaying;
  [Token(Token = "0x400027A")]
  [FieldOffset(Offset = "0x30")]
  public double inAppPurchasesTotal;
  [Token(Token = "0x400027B")]
  [FieldOffset(Offset = "0x38")]
  public long userCreationDate;
  [Token(Token = "0x400027C")]
  [FieldOffset(Offset = "0x40")]
  public Dictionary<string, string> customs;

  [Token(Token = "0x60004FD")]
  [Address(RVA = "0x44B03AC", Offset = "0x44B03AC", VA = "0x44B03AC")]
  public ISAdQualitySegment()
  {
  }

  [Token(Token = "0x60004FE")]
  [Address(RVA = "0x44B0448", Offset = "0x44B0448", VA = "0x44B0448")]
  public void setCustom(string key, string value)
  {
  }

  [Token(Token = "0x60004FF")]
  [Address(RVA = "0x44AF248", Offset = "0x44AF248", VA = "0x44AF248")]
  public Dictionary<string, string> getSegmentAsDict() => (Dictionary<string, string>) null;
}
