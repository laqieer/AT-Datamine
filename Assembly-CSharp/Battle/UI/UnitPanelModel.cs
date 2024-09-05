// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitPanelModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Equipment;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Style;
using Scenes.OutGame.Info.Unit;
using TeamOrganization;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200239E")]
  public class UnitPanelModel : UnitModelBase
  {
    [Token(Token = "0x4009796")]
    [FieldOffset(Offset = "0x50")]
    private StyleModel style;
    [Token(Token = "0x4009797")]
    [FieldOffset(Offset = "0x58")]
    private ParameterModel parameter;
    [Token(Token = "0x4009798")]
    [FieldOffset(Offset = "0x60")]
    private AdditionalParameterModel addtionalParameter;
    [Token(Token = "0x4009799")]
    [FieldOffset(Offset = "0x68")]
    private OrganizationEquipmentSlot.EquipmentSlotType currentWeaponSlot;
    [Token(Token = "0x400979A")]
    [FieldOffset(Offset = "0x70")]
    private WeaponModel mainWeapon;
    [Token(Token = "0x400979B")]
    [FieldOffset(Offset = "0x78")]
    private WeaponModel subWeapon1;
    [Token(Token = "0x400979C")]
    [FieldOffset(Offset = "0x80")]
    private WeaponModel subWeapon2;
    [Token(Token = "0x400979D")]
    [FieldOffset(Offset = "0x88")]
    private AccessoryModel accessory;
    [Token(Token = "0x400979E")]
    [FieldOffset(Offset = "0x90")]
    private TrustModel trust;
    [Token(Token = "0x400979F")]
    [FieldOffset(Offset = "0x98")]
    private MindEquipmentModel mindEquipment;
    [Token(Token = "0x40097A0")]
    [FieldOffset(Offset = "0xA0")]
    private SkillModelList skillList;

    [Token(Token = "0x17002EE6")]
    public override StyleModelBase Style
    {
      [Token(Token = "0x600D9B6"), Address(RVA = "0x22D16B8", Offset = "0x22D16B8", VA = "0x22D16B8", Slot = "4")] get
      {
        return (StyleModelBase) null;
      }
    }

    [Token(Token = "0x17002EE7")]
    public override ParameterModelBase UnitParameter
    {
      [Token(Token = "0x600D9B7"), Address(RVA = "0x22D16C0", Offset = "0x22D16C0", VA = "0x22D16C0", Slot = "12")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EE8")]
    public override AdditionalParameterModelBase AdditionalParameter
    {
      [Token(Token = "0x600D9B8"), Address(RVA = "0x22D16C8", Offset = "0x22D16C8", VA = "0x22D16C8", Slot = "13")] get
      {
        return (AdditionalParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EE9")]
    public override EquipmentWeaponModelBase MainWeapon
    {
      [Token(Token = "0x600D9B9"), Address(RVA = "0x22D16D0", Offset = "0x22D16D0", VA = "0x22D16D0", Slot = "5")] get
      {
        return (EquipmentWeaponModelBase) null;
      }
    }

    [Token(Token = "0x17002EEA")]
    public override EquipmentWeaponModelBase SubWeapon1
    {
      [Token(Token = "0x600D9BA"), Address(RVA = "0x22D16D8", Offset = "0x22D16D8", VA = "0x22D16D8", Slot = "6")] get
      {
        return (EquipmentWeaponModelBase) null;
      }
    }

    [Token(Token = "0x17002EEB")]
    public override EquipmentWeaponModelBase SubWeapon2
    {
      [Token(Token = "0x600D9BB"), Address(RVA = "0x22D16E0", Offset = "0x22D16E0", VA = "0x22D16E0", Slot = "7")] get
      {
        return (EquipmentWeaponModelBase) null;
      }
    }

    [Token(Token = "0x17002EEC")]
    public override EquipmentAccessoryModelBase Accessory
    {
      [Token(Token = "0x600D9BC"), Address(RVA = "0x22D16E8", Offset = "0x22D16E8", VA = "0x22D16E8", Slot = "8")] get
      {
        return (EquipmentAccessoryModelBase) null;
      }
    }

    [Token(Token = "0x17002EED")]
    public override EquipmentTrustModelBase Trust
    {
      [Token(Token = "0x600D9BD"), Address(RVA = "0x22D16F0", Offset = "0x22D16F0", VA = "0x22D16F0", Slot = "9")] get
      {
        return (EquipmentTrustModelBase) null;
      }
    }

    [Token(Token = "0x17002EEE")]
    public override EquipmentMindEquipmentModelBase MindEquipment
    {
      [Token(Token = "0x600D9BE"), Address(RVA = "0x22D16F8", Offset = "0x22D16F8", VA = "0x22D16F8", Slot = "10")] get
      {
        return (EquipmentMindEquipmentModelBase) null;
      }
    }

    [Token(Token = "0x17002EEF")]
    public override SkillModelListBase SkillList
    {
      [Token(Token = "0x600D9BF"), Address(RVA = "0x22D1700", Offset = "0x22D1700", VA = "0x22D1700", Slot = "11")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17002EF0")]
    public WeaponModel CurrentWeapon
    {
      [Token(Token = "0x600D9C0"), Address(RVA = "0x22D1708", Offset = "0x22D1708", VA = "0x22D1708")] get
      {
        return (WeaponModel) null;
      }
    }

    [Token(Token = "0x17002EF1")]
    public override bool ExistEquipmentSkill
    {
      [Token(Token = "0x600D9C1"), Address(RVA = "0x22D188C", Offset = "0x22D188C", VA = "0x22D188C", Slot = "14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EF2")]
    public int Index
    {
      [Token(Token = "0x600D9C2"), Address(RVA = "0x22D1960", Offset = "0x22D1960", VA = "0x22D1960")] get
      {
        return new int();
      }
      [Token(Token = "0x600D9C3"), Address(RVA = "0x22D1968", Offset = "0x22D1968", VA = "0x22D1968")] private set
      {
      }
    }

    [Token(Token = "0x17002EF3")]
    public bool IsSelectablePrevUnit
    {
      [Token(Token = "0x600D9C4"), Address(RVA = "0x22D1970", Offset = "0x22D1970", VA = "0x22D1970")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D9C5"), Address(RVA = "0x22D1978", Offset = "0x22D1978", VA = "0x22D1978")] private set
      {
      }
    }

    [Token(Token = "0x17002EF4")]
    public bool IsSelectableNextUnit
    {
      [Token(Token = "0x600D9C6"), Address(RVA = "0x22D1984", Offset = "0x22D1984", VA = "0x22D1984")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D9C7"), Address(RVA = "0x22D198C", Offset = "0x22D198C", VA = "0x22D198C")] private set
      {
      }
    }

    [Token(Token = "0x17002EF5")]
    public ForceTypeEnum Force
    {
      [Token(Token = "0x600D9C8"), Address(RVA = "0x22D1998", Offset = "0x22D1998", VA = "0x22D1998")] get
      {
        return new ForceTypeEnum();
      }
      [Token(Token = "0x600D9C9"), Address(RVA = "0x22D19A0", Offset = "0x22D19A0", VA = "0x22D19A0")] private set
      {
      }
    }

    [Token(Token = "0x17002EF6")]
    public StatusConditionModelList StatusConditionModelList
    {
      [Token(Token = "0x600D9CA"), Address(RVA = "0x22D19A8", Offset = "0x22D19A8", VA = "0x22D19A8")] get
      {
        return (StatusConditionModelList) null;
      }
      [Token(Token = "0x600D9CB"), Address(RVA = "0x22D19B0", Offset = "0x22D19B0", VA = "0x22D19B0")] private set
      {
      }
    }

    [Token(Token = "0x600D9CC")]
    [Address(RVA = "0x22D19B8", Offset = "0x22D19B8", VA = "0x22D19B8")]
    public void Set(
      UnitParameterData[] units,
      UnitParameterData unit,
      BattlePlayerData owner,
      int barrierIndex)
    {
    }

    [Token(Token = "0x600D9CD")]
    [Address(RVA = "0x22D3084", Offset = "0x22D3084", VA = "0x22D3084")]
    public UnitPanelModel()
    {
    }
  }
}
