// Decompiled with JetBrains decompiler
// Type: StaqData.ExpeditionRapidTicketItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002034")]
  public sealed class ExpeditionRapidTicketItem : Item
  {
    [Token(Token = "0x4008914")]
    [FieldOffset(Offset = "0x28")]
    private ExpeditionRapidTicketData baseData;

    [Token(Token = "0x17002850")]
    public ExpeditionRapidTicketData MasterData
    {
      [Token(Token = "0x600C0E1"), Address(RVA = "0x2011620", Offset = "0x2011620", VA = "0x2011620")] get
      {
        return (ExpeditionRapidTicketData) null;
      }
    }

    [Token(Token = "0x17002851")]
    public override string Name
    {
      [Token(Token = "0x600C0E2"), Address(RVA = "0x20116CC", Offset = "0x20116CC", VA = "0x20116CC", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002852")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C0E3"), Address(RVA = "0x20116E8", Offset = "0x20116E8", VA = "0x20116E8", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17002853")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C0E4"), Address(RVA = "0x2011704", Offset = "0x2011704", VA = "0x2011704", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17002854")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C0E5"), Address(RVA = "0x2011720", Offset = "0x2011720", VA = "0x2011720", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002855")]
    public int ExecutionHour
    {
      [Token(Token = "0x600C0E6"), Address(RVA = "0x201173C", Offset = "0x201173C", VA = "0x201173C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C0E7")]
    [Address(RVA = "0x2011758", Offset = "0x2011758", VA = "0x2011758")]
    private ExpeditionRapidTicketItem()
    {
    }

    [Token(Token = "0x600C0E8")]
    [Address(RVA = "0x2011760", Offset = "0x2011760", VA = "0x2011760")]
    public void Apply(PlayerExpeditionRapidTicketType entity)
    {
    }

    [Token(Token = "0x600C0E9")]
    [Address(RVA = "0x201177C", Offset = "0x201177C", VA = "0x201177C")]
    public static ExpeditionRapidTicketItem CreateByServerData(
      PlayerExpeditionRapidTicketType entity)
    {
      return (ExpeditionRapidTicketItem) null;
    }
  }
}
