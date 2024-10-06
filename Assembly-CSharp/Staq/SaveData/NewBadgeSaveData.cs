// Decompiled with JetBrains decompiler
// Type: staq.SaveData.NewBadgeSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D2F")]
  public class NewBadgeSaveData
  {
    [Token(Token = "0x4010D1C")]
    [FieldOffset(Offset = "0x10")]
    private DateTime _createdAt;
    [Token(Token = "0x4010D1D")]
    [FieldOffset(Offset = "0x18")]
    private HashSet<string> _styleIds;
    [Token(Token = "0x4010D1E")]
    [FieldOffset(Offset = "0x20")]
    private HashSet<string> _weaponIds;
    [Token(Token = "0x4010D1F")]
    [FieldOffset(Offset = "0x28")]
    private HashSet<string> _accessoryIds;
    [Token(Token = "0x4010D20")]
    [FieldOffset(Offset = "0x30")]
    private HashSet<string> _mindEquipmentIds;
    [Token(Token = "0x4010D21")]
    [FieldOffset(Offset = "0x38")]
    private HashSet<string> _unitTrustIds;
    [Token(Token = "0x4010D22")]
    [FieldOffset(Offset = "0x40")]
    private HashSet<string> _customSkillIds;
    [Token(Token = "0x4010D23")]
    [FieldOffset(Offset = "0x48")]
    private HashSet<string> _itemIds;
    [Token(Token = "0x4010D24")]
    [FieldOffset(Offset = "0x50")]
    private HashSet<int> _gachaNumbers;
    [Token(Token = "0x4010D25")]
    [FieldOffset(Offset = "0x58")]
    private HashSet<int> _obliviaeQuestIds;

    [Token(Token = "0x6018990")]
    [Address(RVA = "0x29487E8", Offset = "0x29487E8", VA = "0x29487E8")]
    public bool IsNew(Style style) => new bool();

    [Token(Token = "0x6018991")]
    [Address(RVA = "0x29488CC", Offset = "0x29488CC", VA = "0x29488CC")]
    public bool Check(Style style) => new bool();

    [Token(Token = "0x6018992")]
    [Address(RVA = "0x2948954", Offset = "0x2948954", VA = "0x2948954")]
    public bool IsNew(Weapon weapon) => new bool();

    [Token(Token = "0x6018993")]
    [Address(RVA = "0x2948A38", Offset = "0x2948A38", VA = "0x2948A38")]
    public bool Check(Weapon weapon) => new bool();

    [Token(Token = "0x6018994")]
    [Address(RVA = "0x2948AC0", Offset = "0x2948AC0", VA = "0x2948AC0")]
    public bool IsNew(Accessory accessory) => new bool();

    [Token(Token = "0x6018995")]
    [Address(RVA = "0x2948BA4", Offset = "0x2948BA4", VA = "0x2948BA4")]
    public bool Check(Accessory accessory) => new bool();

    [Token(Token = "0x6018996")]
    [Address(RVA = "0x2948C2C", Offset = "0x2948C2C", VA = "0x2948C2C")]
    public bool IsNew(MindEquipment mindEquipment) => new bool();

    [Token(Token = "0x6018997")]
    [Address(RVA = "0x2948D10", Offset = "0x2948D10", VA = "0x2948D10")]
    public bool Check(MindEquipment mindEquipment) => new bool();

    [Token(Token = "0x6018998")]
    [Address(RVA = "0x2948D98", Offset = "0x2948D98", VA = "0x2948D98")]
    public bool IsNew(UnitTrust unitTrust) => new bool();

    [Token(Token = "0x6018999")]
    [Address(RVA = "0x2948E7C", Offset = "0x2948E7C", VA = "0x2948E7C")]
    public bool Check(UnitTrust unitTrust) => new bool();

    [Token(Token = "0x601899A")]
    [Address(RVA = "0x2948F04", Offset = "0x2948F04", VA = "0x2948F04")]
    public bool IsNew(CustomSkill customSkill) => new bool();

    [Token(Token = "0x601899B")]
    [Address(RVA = "0x2948FE8", Offset = "0x2948FE8", VA = "0x2948FE8")]
    public bool Check(CustomSkill customSkill) => new bool();

    [Token(Token = "0x601899C")]
    [Address(RVA = "0x2949070", Offset = "0x2949070", VA = "0x2949070")]
    public bool IsNew(Item item) => new bool();

    [Token(Token = "0x601899D")]
    [Address(RVA = "0x2949104", Offset = "0x2949104", VA = "0x2949104")]
    public bool Check(Item item) => new bool();

    [Token(Token = "0x601899E")]
    [Address(RVA = "0x294918C", Offset = "0x294918C", VA = "0x294918C")]
    public bool IsNew(GachaListItemInfo gacha) => new bool();

    [Token(Token = "0x601899F")]
    [Address(RVA = "0x29491F4", Offset = "0x29491F4", VA = "0x29491F4")]
    public bool Check(GachaListItemInfo gacha) => new bool();

    [Token(Token = "0x60189A0")]
    [Address(RVA = "0x2949250", Offset = "0x2949250", VA = "0x2949250")]
    public bool IsNew(StoryObliviaeQuestData obliviaeQuest) => new bool();

    [Token(Token = "0x60189A1")]
    [Address(RVA = "0x29492B8", Offset = "0x29492B8", VA = "0x29492B8")]
    public bool Check(StoryObliviaeQuestData obliviaeQuest) => new bool();

    [Token(Token = "0x17005050")]
    public static string Path
    {
      [Token(Token = "0x60189A2"), Address(RVA = "0x2949314", Offset = "0x2949314", VA = "0x2949314")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60189A3")]
    [Address(RVA = "0x2949364", Offset = "0x2949364", VA = "0x2949364")]
    public string getPath() => (string) null;

    [Token(Token = "0x60189A4")]
    [Address(RVA = "0x29493AC", Offset = "0x29493AC", VA = "0x29493AC")]
    public void delete()
    {
    }

    [Token(Token = "0x60189A5")]
    [Address(RVA = "0x29493C4", Offset = "0x29493C4", VA = "0x29493C4")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x60189A6")]
    [Address(RVA = "0x29493F0", Offset = "0x29493F0", VA = "0x29493F0")]
    public void load()
    {
    }

    [Token(Token = "0x60189A7")]
    [Address(RVA = "0x2949980", Offset = "0x2949980", VA = "0x2949980")]
    public void save()
    {
    }

    [Token(Token = "0x60189A8")]
    [Address(RVA = "0x2949F50", Offset = "0x2949F50", VA = "0x2949F50")]
    public NewBadgeSaveData()
    {
    }
  }
}
