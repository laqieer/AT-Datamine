// Decompiled with JetBrains decompiler
// Type: Staq.Purchase.FulfillmentItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using PurchaseModule.Fulfillment;

#nullable disable
namespace Staq.Purchase
{
  [Token(Token = "0x200098C")]
  public class FulfillmentItem : IFulfillmentItem
  {
    [Token(Token = "0x17000784")]
    public string ProductId
    {
      [Token(Token = "0x6003654"), Address(RVA = "0x3534E68", Offset = "0x3534E68", VA = "0x3534E68", Slot = "4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6003655"), Address(RVA = "0x3534E70", Offset = "0x3534E70", VA = "0x3534E70")] set
      {
      }
    }

    [Token(Token = "0x17000785")]
    public string OrderId
    {
      [Token(Token = "0x6003656"), Address(RVA = "0x3534E78", Offset = "0x3534E78", VA = "0x3534E78", Slot = "5")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6003657"), Address(RVA = "0x3534E80", Offset = "0x3534E80", VA = "0x3534E80")] set
      {
      }
    }

    [Token(Token = "0x17000786")]
    public int FreeCoin
    {
      [Token(Token = "0x6003658"), Address(RVA = "0x3534E88", Offset = "0x3534E88", VA = "0x3534E88")] get
      {
        return new int();
      }
      [Token(Token = "0x6003659"), Address(RVA = "0x3534E90", Offset = "0x3534E90", VA = "0x3534E90")] set
      {
      }
    }

    [Token(Token = "0x17000787")]
    public int PaidCoin
    {
      [Token(Token = "0x600365A"), Address(RVA = "0x3534E98", Offset = "0x3534E98", VA = "0x3534E98")] get
      {
        return new int();
      }
      [Token(Token = "0x600365B"), Address(RVA = "0x3534EA0", Offset = "0x3534EA0", VA = "0x3534EA0")] set
      {
      }
    }

    [Token(Token = "0x17000788")]
    public bool IsDuplicated
    {
      [Token(Token = "0x600365C"), Address(RVA = "0x3534EA8", Offset = "0x3534EA8", VA = "0x3534EA8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600365D"), Address(RVA = "0x3534EB0", Offset = "0x3534EB0", VA = "0x3534EB0")] set
      {
      }
    }

    [Token(Token = "0x600365E")]
    [Address(RVA = "0x3534EBC", Offset = "0x3534EBC", VA = "0x3534EBC")]
    public FulfillmentItem()
    {
    }
  }
}
