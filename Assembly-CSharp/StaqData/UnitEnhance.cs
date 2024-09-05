// Decompiled with JetBrains decompiler
// Type: StaqData.UnitEnhance
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
  [Token(Token = "0x200203E")]
  public sealed class UnitEnhance : Item
  {
    [Token(Token = "0x4008923")]
    [FieldOffset(Offset = "0x28")]
    private UnitEnhanceData baseData;

    [Token(Token = "0x1700288D")]
    public UnitEnhanceData MasterData
    {
      [Token(Token = "0x600C153"), Address(RVA = "0x1939488", Offset = "0x1939488", VA = "0x1939488")] get
      {
        return (UnitEnhanceData) null;
      }
    }

    [Token(Token = "0x1700288E")]
    public override string Name
    {
      [Token(Token = "0x600C154"), Address(RVA = "0x193955C", Offset = "0x193955C", VA = "0x193955C", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700288F")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C155"), Address(RVA = "0x1939578", Offset = "0x1939578", VA = "0x1939578", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17002890")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C156"), Address(RVA = "0x1939594", Offset = "0x1939594", VA = "0x1939594", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17002891")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C157"), Address(RVA = "0x19395B0", Offset = "0x19395B0", VA = "0x19395B0", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C158")]
    [Address(RVA = "0x19395CC", Offset = "0x19395CC", VA = "0x19395CC")]
    private UnitEnhance()
    {
    }

    [Token(Token = "0x600C159")]
    [Address(RVA = "0x19395D4", Offset = "0x19395D4", VA = "0x19395D4")]
    public void Apply(PlayerUnitEnhanceType entity)
    {
    }

    [Token(Token = "0x600C15A")]
    [Address(RVA = "0x19395F0", Offset = "0x19395F0", VA = "0x19395F0")]
    public static UnitEnhance CreateByServerData(PlayerUnitEnhanceType entity)
    {
      return (UnitEnhance) null;
    }

    [Token(Token = "0x600C15B")]
    [Address(RVA = "0x19396D0", Offset = "0x19396D0", VA = "0x19396D0")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
