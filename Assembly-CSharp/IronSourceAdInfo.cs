// Decompiled with JetBrains decompiler
// Type: IronSourceAdInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000012")]
public class IronSourceAdInfo
{
  [Token(Token = "0x400002E")]
  [FieldOffset(Offset = "0x10")]
  public readonly string auctionId;
  [Token(Token = "0x400002F")]
  [FieldOffset(Offset = "0x18")]
  public readonly string adUnit;
  [Token(Token = "0x4000030")]
  [FieldOffset(Offset = "0x20")]
  public readonly string country;
  [Token(Token = "0x4000031")]
  [FieldOffset(Offset = "0x28")]
  public readonly string ab;
  [Token(Token = "0x4000032")]
  [FieldOffset(Offset = "0x30")]
  public readonly string segmentName;
  [Token(Token = "0x4000033")]
  [FieldOffset(Offset = "0x38")]
  public readonly string adNetwork;
  [Token(Token = "0x4000034")]
  [FieldOffset(Offset = "0x40")]
  public readonly string instanceName;
  [Token(Token = "0x4000035")]
  [FieldOffset(Offset = "0x48")]
  public readonly string instanceId;
  [Token(Token = "0x4000036")]
  [FieldOffset(Offset = "0x50")]
  public readonly double? revenue;
  [Token(Token = "0x4000037")]
  [FieldOffset(Offset = "0x60")]
  public readonly string precision;
  [Token(Token = "0x4000038")]
  [FieldOffset(Offset = "0x68")]
  public readonly double? lifetimeRevenue;
  [Token(Token = "0x4000039")]
  [FieldOffset(Offset = "0x78")]
  public readonly string encryptedCPM;

  [Token(Token = "0x60000BF")]
  [Address(RVA = "0x2044354", Offset = "0x2044354", VA = "0x2044354")]
  public IronSourceAdInfo(string json)
  {
  }

  [Token(Token = "0x60000C0")]
  [Address(RVA = "0x2044984", Offset = "0x2044984", VA = "0x2044984", Slot = "3")]
  public override string ToString() => (string) null;
}
