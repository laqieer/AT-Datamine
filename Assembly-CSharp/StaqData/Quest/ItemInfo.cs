// Decompiled with JetBrains decompiler
// Type: StaqData.Quest.ItemInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData.Quest
{
  [Token(Token = "0x200214E")]
  public class ItemInfo
  {
    [Token(Token = "0x17002C9E")]
    public PaymentTypeEnum PaymentType
    {
      [Token(Token = "0x600CC04"), Address(RVA = "0x1BABBE8", Offset = "0x1BABBE8", VA = "0x1BABBE8")] get
      {
        return new PaymentTypeEnum();
      }
    }

    [Token(Token = "0x17002C9F")]
    public int PaymentID
    {
      [Token(Token = "0x600CC05"), Address(RVA = "0x1BABBF0", Offset = "0x1BABBF0", VA = "0x1BABBF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CA0")]
    public int NeedAmount
    {
      [Token(Token = "0x600CC06"), Address(RVA = "0x1BABBF8", Offset = "0x1BABBF8", VA = "0x1BABBF8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CA1")]
    public int PrevAmount
    {
      [Token(Token = "0x600CC07"), Address(RVA = "0x1BABC00", Offset = "0x1BABC00", VA = "0x1BABC00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CA2")]
    public int Amount
    {
      [Token(Token = "0x600CC08"), Address(RVA = "0x1BABC90", Offset = "0x1BABC90", VA = "0x1BABC90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CA3")]
    public bool Completed
    {
      [Token(Token = "0x600CC09"), Address(RVA = "0x1BABD20", Offset = "0x1BABD20", VA = "0x1BABD20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CC0A")]
    [Address(RVA = "0x1BABD40", Offset = "0x1BABD40", VA = "0x1BABD40")]
    public ItemInfo(int type, int id, int quantity)
    {
    }
  }
}
