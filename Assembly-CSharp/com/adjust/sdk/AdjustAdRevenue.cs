// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustAdRevenue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FE8")]
  public class AdjustAdRevenue
  {
    [Token(Token = "0x40117F4")]
    [FieldOffset(Offset = "0x10")]
    internal string source;
    [Token(Token = "0x40117F5")]
    [FieldOffset(Offset = "0x18")]
    internal double? revenue;
    [Token(Token = "0x40117F6")]
    [FieldOffset(Offset = "0x28")]
    internal string currency;
    [Token(Token = "0x40117F7")]
    [FieldOffset(Offset = "0x30")]
    internal int? adImpressionsCount;
    [Token(Token = "0x40117F8")]
    [FieldOffset(Offset = "0x38")]
    internal string adRevenueNetwork;
    [Token(Token = "0x40117F9")]
    [FieldOffset(Offset = "0x40")]
    internal string adRevenueUnit;
    [Token(Token = "0x40117FA")]
    [FieldOffset(Offset = "0x48")]
    internal string adRevenuePlacement;
    [Token(Token = "0x40117FB")]
    [FieldOffset(Offset = "0x50")]
    internal List<string> partnerList;
    [Token(Token = "0x40117FC")]
    [FieldOffset(Offset = "0x58")]
    internal List<string> callbackList;

    [Token(Token = "0x6019B9C")]
    [Address(RVA = "0x379AB98", Offset = "0x379AB98", VA = "0x379AB98")]
    public AdjustAdRevenue(string source)
    {
    }

    [Token(Token = "0x6019B9D")]
    [Address(RVA = "0x379ABC0", Offset = "0x379ABC0", VA = "0x379ABC0")]
    public void setRevenue(double amount, string currency)
    {
    }

    [Token(Token = "0x6019B9E")]
    [Address(RVA = "0x379AC40", Offset = "0x379AC40", VA = "0x379AC40")]
    public void setAdImpressionsCount(int adImpressionsCount)
    {
    }

    [Token(Token = "0x6019B9F")]
    [Address(RVA = "0x379ACA8", Offset = "0x379ACA8", VA = "0x379ACA8")]
    public void setAdRevenueNetwork(string adRevenueNetwork)
    {
    }

    [Token(Token = "0x6019BA0")]
    [Address(RVA = "0x379ACB0", Offset = "0x379ACB0", VA = "0x379ACB0")]
    public void setAdRevenueUnit(string adRevenueUnit)
    {
    }

    [Token(Token = "0x6019BA1")]
    [Address(RVA = "0x379ACB8", Offset = "0x379ACB8", VA = "0x379ACB8")]
    public void setAdRevenuePlacement(string adRevenuePlacement)
    {
    }

    [Token(Token = "0x6019BA2")]
    [Address(RVA = "0x379ACC0", Offset = "0x379ACC0", VA = "0x379ACC0")]
    public void addCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x6019BA3")]
    [Address(RVA = "0x379AE1C", Offset = "0x379AE1C", VA = "0x379AE1C")]
    public void addPartnerParameter(string key, string value)
    {
    }
  }
}
