// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.NewBadgeProxy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using staq.SaveData;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032C6")]
  public class NewBadgeProxy
  {
    [Token(Token = "0x400DAB3")]
    [FieldOffset(Offset = "0x10")]
    private NewBadgeSaveData _saveData;
    [Token(Token = "0x400DAB4")]
    [FieldOffset(Offset = "0x18")]
    private int _newCheckCount;

    [Token(Token = "0x6013E63")]
    [Address(RVA = "0x1AEAEE0", Offset = "0x1AEAEE0", VA = "0x1AEAEE0")]
    public NewBadgeProxy()
    {
    }

    [Token(Token = "0x6013E64")]
    [Address(RVA = "0x1AEAFB0", Offset = "0x1AEAFB0", VA = "0x1AEAFB0")]
    public bool IsNew(Style style) => new bool();

    [Token(Token = "0x6013E65")]
    [Address(RVA = "0x1AEAFCC", Offset = "0x1AEAFCC", VA = "0x1AEAFCC")]
    public bool Check(Style style) => new bool();

    [Token(Token = "0x6013E66")]
    [Address(RVA = "0x1AEB030", Offset = "0x1AEB030", VA = "0x1AEB030")]
    public bool IsNew(Equipment equip) => new bool();

    [Token(Token = "0x6013E67")]
    [Address(RVA = "0x1AEB1B8", Offset = "0x1AEB1B8", VA = "0x1AEB1B8")]
    public bool IsNew(Weapon weapon) => new bool();

    [Token(Token = "0x6013E68")]
    [Address(RVA = "0x1AEB228", Offset = "0x1AEB228", VA = "0x1AEB228")]
    public bool Check(Weapon weapon) => new bool();

    [Token(Token = "0x6013E69")]
    [Address(RVA = "0x1AEB1D4", Offset = "0x1AEB1D4", VA = "0x1AEB1D4")]
    public bool IsNew(Accessory accessory) => new bool();

    [Token(Token = "0x6013E6A")]
    [Address(RVA = "0x1AEB28C", Offset = "0x1AEB28C", VA = "0x1AEB28C")]
    public bool Check(Accessory accessory) => new bool();

    [Token(Token = "0x6013E6B")]
    [Address(RVA = "0x1AEB1F0", Offset = "0x1AEB1F0", VA = "0x1AEB1F0")]
    public bool IsNew(MindEquipment mindEquipment) => new bool();

    [Token(Token = "0x6013E6C")]
    [Address(RVA = "0x1AEB2F0", Offset = "0x1AEB2F0", VA = "0x1AEB2F0")]
    public bool Check(MindEquipment mindEquipment) => new bool();

    [Token(Token = "0x6013E6D")]
    [Address(RVA = "0x1AEB20C", Offset = "0x1AEB20C", VA = "0x1AEB20C")]
    public bool IsNew(UnitTrust unitTrust) => new bool();

    [Token(Token = "0x6013E6E")]
    [Address(RVA = "0x1AEB354", Offset = "0x1AEB354", VA = "0x1AEB354")]
    public bool Check(UnitTrust unitTrust) => new bool();

    [Token(Token = "0x6013E6F")]
    [Address(RVA = "0x1AEB3B8", Offset = "0x1AEB3B8", VA = "0x1AEB3B8")]
    public bool IsNew(CustomSkill customSkill) => new bool();

    [Token(Token = "0x6013E70")]
    [Address(RVA = "0x1AEB3D4", Offset = "0x1AEB3D4", VA = "0x1AEB3D4")]
    public bool Check(CustomSkill customSkill) => new bool();

    [Token(Token = "0x6013E71")]
    [Address(RVA = "0x1AEB438", Offset = "0x1AEB438", VA = "0x1AEB438")]
    public bool IsNew(Item item) => new bool();

    [Token(Token = "0x6013E72")]
    [Address(RVA = "0x1AEB454", Offset = "0x1AEB454", VA = "0x1AEB454")]
    public bool Check(Item item) => new bool();

    [Token(Token = "0x6013E73")]
    [Address(RVA = "0x1AEB4B8", Offset = "0x1AEB4B8", VA = "0x1AEB4B8")]
    public bool IsNew(GachaListItemInfo gacha) => new bool();

    [Token(Token = "0x6013E74")]
    [Address(RVA = "0x1AEB4D4", Offset = "0x1AEB4D4", VA = "0x1AEB4D4")]
    public bool Check(GachaListItemInfo gacha) => new bool();

    [Token(Token = "0x6013E75")]
    [Address(RVA = "0x1AEB538", Offset = "0x1AEB538", VA = "0x1AEB538")]
    public bool IsNew(StoryObliviaeQuestData obliviaeQuest) => new bool();

    [Token(Token = "0x6013E76")]
    [Address(RVA = "0x1AEB554", Offset = "0x1AEB554", VA = "0x1AEB554")]
    public bool Check(StoryObliviaeQuestData obliviaeQuest) => new bool();

    [Token(Token = "0x6013E77")]
    [Address(RVA = "0x1AEB5B8", Offset = "0x1AEB5B8", VA = "0x1AEB5B8")]
    public bool Save() => new bool();
  }
}
