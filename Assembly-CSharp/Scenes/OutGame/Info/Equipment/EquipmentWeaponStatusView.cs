// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentWeaponStatusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment.UI;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x20035A9")]
  public class EquipmentWeaponStatusView
  {
    [Token(Token = "0x17004652")]
    public IconUI WeaponTypeIcon
    {
      [Token(Token = "0x60151E5"), Address(RVA = "0x4AAC56C", Offset = "0x4AAC56C", VA = "0x4AAC56C")] private get
      {
        return (IconUI) null;
      }
      [Token(Token = "0x60151E6"), Address(RVA = "0x4AAC574", Offset = "0x4AAC574", VA = "0x4AAC574")] set
      {
      }
    }

    [Token(Token = "0x17004653")]
    public IconUI WeaponSystemIcon
    {
      [Token(Token = "0x60151E7"), Address(RVA = "0x4AAC57C", Offset = "0x4AAC57C", VA = "0x4AAC57C")] private get
      {
        return (IconUI) null;
      }
      [Token(Token = "0x60151E8"), Address(RVA = "0x4AAC584", Offset = "0x4AAC584", VA = "0x4AAC584")] set
      {
      }
    }

    [Token(Token = "0x17004654")]
    public EquipmentCombatPowerUI CombatPowerUI
    {
      [Token(Token = "0x60151E9"), Address(RVA = "0x4AAC58C", Offset = "0x4AAC58C", VA = "0x4AAC58C")] private get
      {
        return (EquipmentCombatPowerUI) null;
      }
      [Token(Token = "0x60151EA"), Address(RVA = "0x4AAC594", Offset = "0x4AAC594", VA = "0x4AAC594")] set
      {
      }
    }

    [Token(Token = "0x17004655")]
    public CurrentMaxGaugeUI LevelUI
    {
      [Token(Token = "0x60151EB"), Address(RVA = "0x4AAC59C", Offset = "0x4AAC59C", VA = "0x4AAC59C")] private get
      {
        return (CurrentMaxGaugeUI) null;
      }
      [Token(Token = "0x60151EC"), Address(RVA = "0x4AAC5A4", Offset = "0x4AAC5A4", VA = "0x4AAC5A4")] set
      {
      }
    }

    [Token(Token = "0x17004656")]
    public GemListUI GemListUI
    {
      [Token(Token = "0x60151ED"), Address(RVA = "0x4AAC5AC", Offset = "0x4AAC5AC", VA = "0x4AAC5AC")] private get
      {
        return (GemListUI) null;
      }
      [Token(Token = "0x60151EE"), Address(RVA = "0x4AAC5B4", Offset = "0x4AAC5B4", VA = "0x4AAC5B4")] set
      {
      }
    }

    [Token(Token = "0x17004657")]
    public EquipmentOptionEffectListView OptionEffectListView
    {
      [Token(Token = "0x60151EF"), Address(RVA = "0x4AAC5BC", Offset = "0x4AAC5BC", VA = "0x4AAC5BC")] get
      {
        return (EquipmentOptionEffectListView) null;
      }
      [Token(Token = "0x60151F0"), Address(RVA = "0x4AAC5C4", Offset = "0x4AAC5C4", VA = "0x4AAC5C4")] set
      {
      }
    }

    [Token(Token = "0x17004658")]
    public ParameterView ParameterView
    {
      [Token(Token = "0x60151F1"), Address(RVA = "0x4AAC5CC", Offset = "0x4AAC5CC", VA = "0x4AAC5CC")] get
      {
        return (ParameterView) null;
      }
      [Token(Token = "0x60151F2"), Address(RVA = "0x4AAC5D4", Offset = "0x4AAC5D4", VA = "0x4AAC5D4")] set
      {
      }
    }

    [Token(Token = "0x17004659")]
    public IAssetProvider AssetProbider
    {
      [Token(Token = "0x60151F3"), Address(RVA = "0x4AAC5DC", Offset = "0x4AAC5DC", VA = "0x4AAC5DC")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x60151F4"), Address(RVA = "0x4AAC5E4", Offset = "0x4AAC5E4", VA = "0x4AAC5E4")] set
      {
      }
    }

    [Token(Token = "0x60151F5")]
    [Address(RVA = "0x4AAA144", Offset = "0x4AAA144", VA = "0x4AAA144")]
    public void SetWeaponTypeIcon(int weaponId)
    {
    }

    [Token(Token = "0x60151F6")]
    [Address(RVA = "0x4AAA318", Offset = "0x4AAA318", VA = "0x4AAA318")]
    public void SetLevel(int current, int max)
    {
    }

    [Token(Token = "0x60151F7")]
    [Address(RVA = "0x4AAA300", Offset = "0x4AAA300", VA = "0x4AAA300")]
    public void SetCombatPower(int value)
    {
    }

    [Token(Token = "0x60151F8")]
    [Address(RVA = "0x4AAA33C", Offset = "0x4AAA33C", VA = "0x4AAA33C")]
    public void SetLimitBreak(int value, int max)
    {
    }

    [Token(Token = "0x60151F9")]
    [Address(RVA = "0x4AAC5EC", Offset = "0x4AAC5EC", VA = "0x4AAC5EC")]
    public EquipmentWeaponStatusView()
    {
    }
  }
}
