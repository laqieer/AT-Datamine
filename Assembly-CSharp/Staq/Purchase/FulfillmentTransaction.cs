// Decompiled with JetBrains decompiler
// Type: Staq.Purchase.FulfillmentTransaction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using PurchaseModule.Fulfillment;
using System.Collections.Generic;

#nullable disable
namespace Staq.Purchase
{
  [Token(Token = "0x200098D")]
  public class FulfillmentTransaction : IFulfillmentTransaction
  {
    [Token(Token = "0x17000789")]
    public string FulfillmentId
    {
      [Token(Token = "0x600365F"), Address(RVA = "0x3534EC4", Offset = "0x3534EC4", VA = "0x3534EC4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6003660"), Address(RVA = "0x3534ECC", Offset = "0x3534ECC", VA = "0x3534ECC")] set
      {
      }
    }

    [Token(Token = "0x1700078A")]
    public int CommonCoin
    {
      [Token(Token = "0x6003661"), Address(RVA = "0x3534ED4", Offset = "0x3534ED4", VA = "0x3534ED4")] get
      {
        return new int();
      }
      [Token(Token = "0x6003662"), Address(RVA = "0x3534EDC", Offset = "0x3534EDC", VA = "0x3534EDC")] set
      {
      }
    }

    [Token(Token = "0x1700078B")]
    public int FreeCoin
    {
      [Token(Token = "0x6003663"), Address(RVA = "0x3534EE4", Offset = "0x3534EE4", VA = "0x3534EE4")] get
      {
        return new int();
      }
      [Token(Token = "0x6003664"), Address(RVA = "0x3534EEC", Offset = "0x3534EEC", VA = "0x3534EEC")] set
      {
      }
    }

    [Token(Token = "0x1700078C")]
    public int PaidCoin
    {
      [Token(Token = "0x6003665"), Address(RVA = "0x3534EF4", Offset = "0x3534EF4", VA = "0x3534EF4")] get
      {
        return new int();
      }
      [Token(Token = "0x6003666"), Address(RVA = "0x3534EFC", Offset = "0x3534EFC", VA = "0x3534EFC")] set
      {
      }
    }

    [Token(Token = "0x1700078D")]
    public List<IFulfillmentItem> FulfillmentItems
    {
      [Token(Token = "0x6003667"), Address(RVA = "0x3534F04", Offset = "0x3534F04", VA = "0x3534F04", Slot = "4")] get
      {
        return (List<IFulfillmentItem>) null;
      }
    }

    [Token(Token = "0x6003668")]
    [Address(RVA = "0x3534F0C", Offset = "0x3534F0C", VA = "0x3534F0C")]
    public FulfillmentTransaction()
    {
    }
  }
}
