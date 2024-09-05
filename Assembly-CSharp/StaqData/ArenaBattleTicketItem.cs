// Decompiled with JetBrains decompiler
// Type: StaqData.ArenaBattleTicketItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002010")]
  public sealed class ArenaBattleTicketItem : Item
  {
    [Token(Token = "0x4008896")]
    [FieldOffset(Offset = "0x28")]
    private ArenaBattleTicketData baseData;

    [Token(Token = "0x1700279E")]
    public ArenaBattleTicketData MasterData
    {
      [Token(Token = "0x600BEFB"), Address(RVA = "0x2004B50", Offset = "0x2004B50", VA = "0x2004B50")] get
      {
        return (ArenaBattleTicketData) null;
      }
    }

    [Token(Token = "0x1700279F")]
    public override string Name
    {
      [Token(Token = "0x600BEFC"), Address(RVA = "0x2004C24", Offset = "0x2004C24", VA = "0x2004C24", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170027A0")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BEFD"), Address(RVA = "0x2004C40", Offset = "0x2004C40", VA = "0x2004C40", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x170027A1")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BEFE"), Address(RVA = "0x2004C5C", Offset = "0x2004C5C", VA = "0x2004C5C", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x170027A2")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BEFF"), Address(RVA = "0x2004C78", Offset = "0x2004C78", VA = "0x2004C78", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BF00")]
    [Address(RVA = "0x2004C94", Offset = "0x2004C94", VA = "0x2004C94")]
    private ArenaBattleTicketItem()
    {
    }

    [Token(Token = "0x600BF01")]
    [Address(RVA = "0x2004C9C", Offset = "0x2004C9C", VA = "0x2004C9C")]
    public void Apply(PlayerArenaBattleTicketType entity)
    {
    }

    [Token(Token = "0x600BF02")]
    [Address(RVA = "0x2004D50", Offset = "0x2004D50", VA = "0x2004D50")]
    public static ArenaBattleTicketItem CreateByServerData(PlayerArenaBattleTicketType entity)
    {
      return (ArenaBattleTicketItem) null;
    }
  }
}
