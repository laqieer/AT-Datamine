// Decompiled with JetBrains decompiler
// Type: StaqData.Story.StoryShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData.Story
{
  [Token(Token = "0x2002161")]
  public class StoryShopList
  {
    [Token(Token = "0x4008D69")]
    [FieldOffset(Offset = "0x18")]
    private System.Collections.Generic.List<StoryShop> shops;

    [Token(Token = "0x17002CDA")]
    private int ShopLabel
    {
      [Token(Token = "0x600CC99"), Address(RVA = "0x1BB06DC", Offset = "0x1BB06DC", VA = "0x1BB06DC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CC9A"), Address(RVA = "0x1BB06E4", Offset = "0x1BB06E4", VA = "0x1BB06E4")] set
      {
      }
    }

    [Token(Token = "0x17002CDB")]
    public System.Collections.Generic.List<StoryShop> List
    {
      [Token(Token = "0x600CC9B"), Address(RVA = "0x1BB06EC", Offset = "0x1BB06EC", VA = "0x1BB06EC")] get
      {
        return (System.Collections.Generic.List<StoryShop>) null;
      }
    }

    [Token(Token = "0x600CC9C")]
    [Address(RVA = "0x1BB06F4", Offset = "0x1BB06F4", VA = "0x1BB06F4")]
    public void Setup(int shopLabel)
    {
    }

    [Token(Token = "0x600CC9D")]
    [Address(RVA = "0x1BB0B28", Offset = "0x1BB0B28", VA = "0x1BB0B28")]
    public StoryShopList()
    {
    }
  }
}
