// Decompiled with JetBrains decompiler
// Type: Battle.UI.WeaponModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Equipment;
using Scenes.OutGame.Info.Skill;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023A0")]
  public class WeaponModel : EquipmentWeaponModelBase, IEquipmentModel
  {
    [Token(Token = "0x40097A8")]
    [FieldOffset(Offset = "0xC8")]
    private Battle.UI.SkillModelList skillModelList;
    [Token(Token = "0x40097A9")]
    [FieldOffset(Offset = "0xD0")]
    private ParameterModel parameter;
    [Token(Token = "0x40097AA")]
    [FieldOffset(Offset = "0xD8")]
    private AdditionalParameterModel additionalParameter;
    [Token(Token = "0x40097AB")]
    [FieldOffset(Offset = "0xE0")]
    private EquipmentCommonModel common;

    [Token(Token = "0x17002EF7")]
    public override SkillModelListBase SkillModelList
    {
      [Token(Token = "0x600D9D1"), Address(RVA = "0x22D330C", Offset = "0x22D330C", VA = "0x22D330C", Slot = "4")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17002EF8")]
    public override ParameterModelBase Parameter
    {
      [Token(Token = "0x600D9D2"), Address(RVA = "0x22D3314", Offset = "0x22D3314", VA = "0x22D3314", Slot = "5")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EF9")]
    public AdditionalParameterModelBase AdditionalParameter
    {
      [Token(Token = "0x600D9D3"), Address(RVA = "0x22D331C", Offset = "0x22D331C", VA = "0x22D331C", Slot = "26")] get
      {
        return (AdditionalParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EFA")]
    public override EquipmentCommonModelBase Common
    {
      [Token(Token = "0x600D9D4"), Address(RVA = "0x22D3324", Offset = "0x22D3324", VA = "0x22D3324", Slot = "6")] get
      {
        return (EquipmentCommonModelBase) null;
      }
    }

    [Token(Token = "0x17002EFB")]
    public GameCore.MasterData.WeaponData MasterData
    {
      [Token(Token = "0x600D9D5"), Address(RVA = "0x22D332C", Offset = "0x22D332C", VA = "0x22D332C")] get
      {
        return (GameCore.MasterData.WeaponData) null;
      }
      [Token(Token = "0x600D9D6"), Address(RVA = "0x22D3334", Offset = "0x22D3334", VA = "0x22D3334")] private set
      {
      }
    }

    [Token(Token = "0x17002EFC")]
    public bool ExistReinforce
    {
      [Token(Token = "0x600D9D7"), Address(RVA = "0x22D333C", Offset = "0x22D333C", VA = "0x22D333C", Slot = "44")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EFD")]
    public bool ExistResist
    {
      [Token(Token = "0x600D9D8"), Address(RVA = "0x22D34C0", Offset = "0x22D34C0", VA = "0x22D34C0", Slot = "45")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EFE")]
    public bool ExistSlay
    {
      [Token(Token = "0x600D9D9"), Address(RVA = "0x22D3644", Offset = "0x22D3644", VA = "0x22D3644", Slot = "46")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EFF")]
    public bool ExistResistSlay
    {
      [Token(Token = "0x600D9DA"), Address(RVA = "0x22D37C8", Offset = "0x22D37C8", VA = "0x22D37C8", Slot = "47")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002F00")]
    public override bool IsUnknown
    {
      [Token(Token = "0x600D9DB"), Address(RVA = "0x22D394C", Offset = "0x22D394C", VA = "0x22D394C", Slot = "23")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D9DC")]
    [Address(RVA = "0x22D3024", Offset = "0x22D3024", VA = "0x22D3024")]
    public void Reset()
    {
    }

    [Token(Token = "0x600D9DD")]
    [Address(RVA = "0x22D2260", Offset = "0x22D2260", VA = "0x22D2260")]
    public void Set(WeaponParameterData weapon, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D9DE")]
    [Address(RVA = "0x22D396C", Offset = "0x22D396C", VA = "0x22D396C")]
    public void Set(WeaponModel model)
    {
    }

    [Token(Token = "0x600D9DF")]
    [Address(RVA = "0x22D2ABC", Offset = "0x22D2ABC", VA = "0x22D2ABC")]
    public void SetBrokenWeapon(WeaponParameterData weapon)
    {
    }

    [Token(Token = "0x600D9E0")]
    [Address(RVA = "0x22D1794", Offset = "0x22D1794", VA = "0x22D1794")]
    public WeaponModel()
    {
    }
  }
}
