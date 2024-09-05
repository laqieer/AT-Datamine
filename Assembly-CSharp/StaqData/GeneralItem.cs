// Decompiled with JetBrains decompiler
// Type: StaqData.GeneralItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002037")]
  public sealed class GeneralItem : Item
  {
    [Token(Token = "0x4008917")]
    [FieldOffset(Offset = "0x28")]
    private GeneralItemData baseData;

    [Token(Token = "0x17002863")]
    public GeneralItemData MasterData
    {
      [Token(Token = "0x600C101"), Address(RVA = "0x2012238", Offset = "0x2012238", VA = "0x2012238")] get
      {
        return (GeneralItemData) null;
      }
    }

    [Token(Token = "0x17002864")]
    public override string Name
    {
      [Token(Token = "0x600C102"), Address(RVA = "0x20122E4", Offset = "0x20122E4", VA = "0x20122E4", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002865")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C103"), Address(RVA = "0x2012300", Offset = "0x2012300", VA = "0x2012300", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17002866")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C104"), Address(RVA = "0x201231C", Offset = "0x201231C", VA = "0x201231C", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17002867")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C105"), Address(RVA = "0x2012338", Offset = "0x2012338", VA = "0x2012338", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C106")]
    [Address(RVA = "0x2012354", Offset = "0x2012354", VA = "0x2012354")]
    private GeneralItem()
    {
    }

    [Token(Token = "0x600C107")]
    [Address(RVA = "0x201235C", Offset = "0x201235C", VA = "0x201235C")]
    public void Apply(PlayerGeneralItemType entity)
    {
    }

    [Token(Token = "0x600C108")]
    [Address(RVA = "0x2012378", Offset = "0x2012378", VA = "0x2012378")]
    public static GeneralItem CreateByServerData(PlayerGeneralItemType entity)
    {
      return (GeneralItem) null;
    }
  }
}
