// Decompiled with JetBrains decompiler
// Type: StaqData.UnitPieceItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200203F")]
  public class UnitPieceItem : Item
  {
    [Token(Token = "0x4008924")]
    [FieldOffset(Offset = "0x28")]
    private UnitPieceData baseData;

    [Token(Token = "0x17002892")]
    public UnitPieceData MasterData
    {
      [Token(Token = "0x600C15C"), Address(RVA = "0x1939914", Offset = "0x1939914", VA = "0x1939914")] get
      {
        return (UnitPieceData) null;
      }
    }

    [Token(Token = "0x17002893")]
    public override string Name
    {
      [Token(Token = "0x600C15D"), Address(RVA = "0x19399E8", Offset = "0x19399E8", VA = "0x19399E8", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002894")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C15E"), Address(RVA = "0x1939A04", Offset = "0x1939A04", VA = "0x1939A04", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17002895")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C15F"), Address(RVA = "0x1939A20", Offset = "0x1939A20", VA = "0x1939A20", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17002896")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C160"), Address(RVA = "0x1939A3C", Offset = "0x1939A3C", VA = "0x1939A3C", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C161")]
    [Address(RVA = "0x1939A58", Offset = "0x1939A58", VA = "0x1939A58")]
    private UnitPieceItem()
    {
    }

    [Token(Token = "0x600C162")]
    [Address(RVA = "0x1939A60", Offset = "0x1939A60", VA = "0x1939A60")]
    public void Apply(PlayerUnitPieceType entity)
    {
    }

    [Token(Token = "0x600C163")]
    [Address(RVA = "0x1939A7C", Offset = "0x1939A7C", VA = "0x1939A7C")]
    public static UnitPieceItem CreateByServerData(PlayerUnitPieceType entity)
    {
      return (UnitPieceItem) null;
    }

    [Token(Token = "0x600C164")]
    [Address(RVA = "0x1939B5C", Offset = "0x1939B5C", VA = "0x1939B5C")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
