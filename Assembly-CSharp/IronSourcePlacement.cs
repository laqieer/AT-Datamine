// Decompiled with JetBrains decompiler
// Type: IronSourcePlacement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200005E")]
public class IronSourcePlacement
{
  [Token(Token = "0x40001BC")]
  [FieldOffset(Offset = "0x10")]
  private string rewardName;
  [Token(Token = "0x40001BD")]
  [FieldOffset(Offset = "0x18")]
  private int rewardAmount;
  [Token(Token = "0x40001BE")]
  [FieldOffset(Offset = "0x20")]
  private string placementName;

  [Token(Token = "0x6000338")]
  [Address(RVA = "0x44A4E2C", Offset = "0x44A4E2C", VA = "0x44A4E2C")]
  public IronSourcePlacement(string placementName, string rewardName, int rewardAmount)
  {
  }

  [Token(Token = "0x6000339")]
  [Address(RVA = "0x44A4E6C", Offset = "0x44A4E6C", VA = "0x44A4E6C")]
  public string getRewardName() => (string) null;

  [Token(Token = "0x600033A")]
  [Address(RVA = "0x44A4E74", Offset = "0x44A4E74", VA = "0x44A4E74")]
  public int getRewardAmount() => new int();

  [Token(Token = "0x600033B")]
  [Address(RVA = "0x44A4E7C", Offset = "0x44A4E7C", VA = "0x44A4E7C")]
  public string getPlacementName() => (string) null;

  [Token(Token = "0x600033C")]
  [Address(RVA = "0x44A4E84", Offset = "0x44A4E84", VA = "0x44A4E84", Slot = "3")]
  public override string ToString() => (string) null;
}
