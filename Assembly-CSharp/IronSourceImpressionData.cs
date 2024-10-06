// Decompiled with JetBrains decompiler
// Type: IronSourceImpressionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000048")]
public class IronSourceImpressionData
{
  [Token(Token = "0x400014C")]
  [FieldOffset(Offset = "0x10")]
  public readonly string auctionId;
  [Token(Token = "0x400014D")]
  [FieldOffset(Offset = "0x18")]
  public readonly string adUnit;
  [Token(Token = "0x400014E")]
  [FieldOffset(Offset = "0x20")]
  public readonly string country;
  [Token(Token = "0x400014F")]
  [FieldOffset(Offset = "0x28")]
  public readonly string ab;
  [Token(Token = "0x4000150")]
  [FieldOffset(Offset = "0x30")]
  public readonly string segmentName;
  [Token(Token = "0x4000151")]
  [FieldOffset(Offset = "0x38")]
  public readonly string placement;
  [Token(Token = "0x4000152")]
  [FieldOffset(Offset = "0x40")]
  public readonly string adNetwork;
  [Token(Token = "0x4000153")]
  [FieldOffset(Offset = "0x48")]
  public readonly string instanceName;
  [Token(Token = "0x4000154")]
  [FieldOffset(Offset = "0x50")]
  public readonly string instanceId;
  [Token(Token = "0x4000155")]
  [FieldOffset(Offset = "0x58")]
  public readonly double? revenue;
  [Token(Token = "0x4000156")]
  [FieldOffset(Offset = "0x68")]
  public readonly string precision;
  [Token(Token = "0x4000157")]
  [FieldOffset(Offset = "0x70")]
  public readonly double? lifetimeRevenue;
  [Token(Token = "0x4000158")]
  [FieldOffset(Offset = "0x80")]
  public readonly string encryptedCPM;
  [Token(Token = "0x4000159")]
  [FieldOffset(Offset = "0x88")]
  public readonly int? conversionValue;
  [Token(Token = "0x400015A")]
  [FieldOffset(Offset = "0x90")]
  public readonly string allData;

  [Token(Token = "0x6000281")]
  [Address(RVA = "0x205413C", Offset = "0x205413C", VA = "0x205413C")]
  public IronSourceImpressionData(string json)
  {
  }

  [Token(Token = "0x6000282")]
  [Address(RVA = "0x2059598", Offset = "0x2059598", VA = "0x2059598", Slot = "3")]
  public override string ToString() => (string) null;
}
