// Decompiled with JetBrains decompiler
// Type: StaqData.SkillEnhanceItem
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
  [Token(Token = "0x200203C")]
  public class SkillEnhanceItem : Item
  {
    [Token(Token = "0x4008920")]
    [FieldOffset(Offset = "0x28")]
    private EquipmentSkillEnhanceData baseData;

    [Token(Token = "0x17002883")]
    public EquipmentSkillEnhanceData MasterData
    {
      [Token(Token = "0x600C13E"), Address(RVA = "0x1938DC4", Offset = "0x1938DC4", VA = "0x1938DC4")] get
      {
        return (EquipmentSkillEnhanceData) null;
      }
    }

    [Token(Token = "0x17002884")]
    public override string Name
    {
      [Token(Token = "0x600C13F"), Address(RVA = "0x1938E98", Offset = "0x1938E98", VA = "0x1938E98", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002885")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C140"), Address(RVA = "0x1938EB4", Offset = "0x1938EB4", VA = "0x1938EB4", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17002886")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C141"), Address(RVA = "0x1938ED0", Offset = "0x1938ED0", VA = "0x1938ED0", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17002887")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C142"), Address(RVA = "0x1938EEC", Offset = "0x1938EEC", VA = "0x1938EEC", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C143")]
    [Address(RVA = "0x1938F08", Offset = "0x1938F08", VA = "0x1938F08")]
    private SkillEnhanceItem()
    {
    }

    [Token(Token = "0x600C144")]
    [Address(RVA = "0x1938F10", Offset = "0x1938F10", VA = "0x1938F10")]
    public void Apply(PlayerEquipmentSkillEnhanceItemType entity)
    {
    }

    [Token(Token = "0x600C145")]
    [Address(RVA = "0x1938F2C", Offset = "0x1938F2C", VA = "0x1938F2C")]
    public static SkillEnhanceItem CreateByServerData(PlayerEquipmentSkillEnhanceItemType entity)
    {
      return (SkillEnhanceItem) null;
    }

    [Token(Token = "0x600C146")]
    [Address(RVA = "0x193900C", Offset = "0x193900C", VA = "0x193900C")]
    public ItemListData GetItemLIst(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
