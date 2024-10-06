// Decompiled with JetBrains decompiler
// Type: ISAdQualityCustomMediationRevenue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200008A")]
public class ISAdQualityCustomMediationRevenue
{
  [Token(Token = "0x400024F")]
  [FieldOffset(Offset = "0x10")]
  private ISAdQualityMediationNetwork mediationNetwork;
  [Token(Token = "0x4000250")]
  [FieldOffset(Offset = "0x14")]
  private ISAdQualityAdType adType;
  [Token(Token = "0x4000251")]
  [FieldOffset(Offset = "0x18")]
  private double revenue;
  [Token(Token = "0x4000252")]
  [FieldOffset(Offset = "0x20")]
  private string placement;

  [Token(Token = "0x60004E9")]
  [Address(RVA = "0x44B0028", Offset = "0x44B0028", VA = "0x44B0028")]
  public ISAdQualityCustomMediationRevenue()
  {
  }

  [Token(Token = "0x1700002C")]
  public ISAdQualityMediationNetwork MediationNetwork
  {
    [Token(Token = "0x60004EA"), Address(RVA = "0x44B004C", Offset = "0x44B004C", VA = "0x44B004C")] get
    {
      return new ISAdQualityMediationNetwork();
    }
    [Token(Token = "0x60004EB"), Address(RVA = "0x44B0054", Offset = "0x44B0054", VA = "0x44B0054")] set
    {
    }
  }

  [Token(Token = "0x1700002D")]
  public ISAdQualityAdType AdType
  {
    [Token(Token = "0x60004EC"), Address(RVA = "0x44B005C", Offset = "0x44B005C", VA = "0x44B005C")] get
    {
      return new ISAdQualityAdType();
    }
    [Token(Token = "0x60004ED"), Address(RVA = "0x44B0064", Offset = "0x44B0064", VA = "0x44B0064")] set
    {
    }
  }

  [Token(Token = "0x1700002E")]
  public double Revenue
  {
    [Token(Token = "0x60004EE"), Address(RVA = "0x44B006C", Offset = "0x44B006C", VA = "0x44B006C")] get
    {
      return new double();
    }
    [Token(Token = "0x60004EF"), Address(RVA = "0x44B0074", Offset = "0x44B0074", VA = "0x44B0074")] set
    {
    }
  }

  [Token(Token = "0x1700002F")]
  public string Placement
  {
    [Token(Token = "0x60004F0"), Address(RVA = "0x44B007C", Offset = "0x44B007C", VA = "0x44B007C")] get
    {
      return (string) null;
    }
    [Token(Token = "0x60004F1"), Address(RVA = "0x44B0084", Offset = "0x44B0084", VA = "0x44B0084")] set
    {
    }
  }
}
