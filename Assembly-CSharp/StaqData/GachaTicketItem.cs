// Decompiled with JetBrains decompiler
// Type: StaqData.GachaTicketItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002036")]
  public sealed class GachaTicketItem : Item
  {
    [Token(Token = "0x4008916")]
    [FieldOffset(Offset = "0x28")]
    private GachaTicketData baseData;

    [Token(Token = "0x1700285B")]
    public GachaTicketData MasterData
    {
      [Token(Token = "0x600C0F5"), Address(RVA = "0x2011E60", Offset = "0x2011E60", VA = "0x2011E60")] get
      {
        return (GachaTicketData) null;
      }
    }

    [Token(Token = "0x1700285C")]
    public override string Name
    {
      [Token(Token = "0x600C0F6"), Address(RVA = "0x2011F34", Offset = "0x2011F34", VA = "0x2011F34", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700285D")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C0F7"), Address(RVA = "0x2011F50", Offset = "0x2011F50", VA = "0x2011F50", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x1700285E")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C0F8"), Address(RVA = "0x2011F6C", Offset = "0x2011F6C", VA = "0x2011F6C", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x1700285F")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C0F9"), Address(RVA = "0x2011F88", Offset = "0x2011F88", VA = "0x2011F88", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002860")]
    public override bool HasExpirationDate
    {
      [Token(Token = "0x600C0FA"), Address(RVA = "0x2011FA4", Offset = "0x2011FA4", VA = "0x2011FA4", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002861")]
    public override DateTime ExpirationBeginDate
    {
      [Token(Token = "0x600C0FB"), Address(RVA = "0x2011FAC", Offset = "0x2011FAC", VA = "0x2011FAC", Slot = "9")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17002862")]
    public override DateTime ExpirationEndDate
    {
      [Token(Token = "0x600C0FC"), Address(RVA = "0x2011FB4", Offset = "0x2011FB4", VA = "0x2011FB4", Slot = "10")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600C0FD")]
    [Address(RVA = "0x2011FBC", Offset = "0x2011FBC", VA = "0x2011FBC")]
    private GachaTicketItem()
    {
    }

    [Token(Token = "0x600C0FE")]
    [Address(RVA = "0x2011FC4", Offset = "0x2011FC4", VA = "0x2011FC4")]
    public void Apply(PlayerGachaTicketType entity)
    {
    }

    [Token(Token = "0x600C0FF")]
    [Address(RVA = "0x2012078", Offset = "0x2012078", VA = "0x2012078")]
    public static GachaTicketItem CreateByServerData(PlayerGachaTicketType entity)
    {
      return (GachaTicketItem) null;
    }

    [Token(Token = "0x600C100")]
    [Address(RVA = "0x2012158", Offset = "0x2012158", VA = "0x2012158")]
    public static GachaTicketItem CreateByDummyData(int itemId, int stackCount = 0)
    {
      return (GachaTicketItem) null;
    }
  }
}
