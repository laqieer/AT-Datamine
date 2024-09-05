// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentAccessoryStatusView
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
  [Token(Token = "0x20035A3")]
  public class EquipmentAccessoryStatusView
  {
    [Token(Token = "0x1700463C")]
    public IconUI TypeIcon
    {
      [Token(Token = "0x60151A5"), Address(RVA = "0x4AABECC", Offset = "0x4AABECC", VA = "0x4AABECC")] protected get
      {
        return (IconUI) null;
      }
      [Token(Token = "0x60151A6"), Address(RVA = "0x4AABED4", Offset = "0x4AABED4", VA = "0x4AABED4")] set
      {
      }
    }

    [Token(Token = "0x1700463D")]
    public EquipmentCombatPowerUI CombatPowerUI
    {
      [Token(Token = "0x60151A7"), Address(RVA = "0x4AABEDC", Offset = "0x4AABEDC", VA = "0x4AABEDC")] protected get
      {
        return (EquipmentCombatPowerUI) null;
      }
      [Token(Token = "0x60151A8"), Address(RVA = "0x4AABEE4", Offset = "0x4AABEE4", VA = "0x4AABEE4")] set
      {
      }
    }

    [Token(Token = "0x1700463E")]
    public CurrentMaxGaugeUI LevelUI
    {
      [Token(Token = "0x60151A9"), Address(RVA = "0x4AABEEC", Offset = "0x4AABEEC", VA = "0x4AABEEC")] protected get
      {
        return (CurrentMaxGaugeUI) null;
      }
      [Token(Token = "0x60151AA"), Address(RVA = "0x4AABEF4", Offset = "0x4AABEF4", VA = "0x4AABEF4")] set
      {
      }
    }

    [Token(Token = "0x1700463F")]
    public GemListUI GemListUI
    {
      [Token(Token = "0x60151AB"), Address(RVA = "0x4AABEFC", Offset = "0x4AABEFC", VA = "0x4AABEFC")] protected get
      {
        return (GemListUI) null;
      }
      [Token(Token = "0x60151AC"), Address(RVA = "0x4AABF04", Offset = "0x4AABF04", VA = "0x4AABF04")] set
      {
      }
    }

    [Token(Token = "0x17004640")]
    public EquipmentOptionEffectListView OptionEffectListView
    {
      [Token(Token = "0x60151AD"), Address(RVA = "0x4AABF0C", Offset = "0x4AABF0C", VA = "0x4AABF0C")] get
      {
        return (EquipmentOptionEffectListView) null;
      }
      [Token(Token = "0x60151AE"), Address(RVA = "0x4AABF14", Offset = "0x4AABF14", VA = "0x4AABF14")] set
      {
      }
    }

    [Token(Token = "0x17004641")]
    public ParameterView ParameterView
    {
      [Token(Token = "0x60151AF"), Address(RVA = "0x4AABF1C", Offset = "0x4AABF1C", VA = "0x4AABF1C")] get
      {
        return (ParameterView) null;
      }
      [Token(Token = "0x60151B0"), Address(RVA = "0x4AABF24", Offset = "0x4AABF24", VA = "0x4AABF24")] set
      {
      }
    }

    [Token(Token = "0x17004642")]
    public IAssetProvider AssetProbider
    {
      [Token(Token = "0x60151B1"), Address(RVA = "0x4AABF2C", Offset = "0x4AABF2C", VA = "0x4AABF2C")] protected get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x60151B2"), Address(RVA = "0x4AABF34", Offset = "0x4AABF34", VA = "0x4AABF34")] set
      {
      }
    }

    [Token(Token = "0x60151B3")]
    [Address(RVA = "0x4AA8C08", Offset = "0x4AA8C08", VA = "0x4AA8C08")]
    public void SetAccessoryTypeIcon(int accessoryId)
    {
    }

    [Token(Token = "0x60151B4")]
    [Address(RVA = "0x4AA8D88", Offset = "0x4AA8D88", VA = "0x4AA8D88")]
    public void SetLevel(int current, int max)
    {
    }

    [Token(Token = "0x60151B5")]
    [Address(RVA = "0x4AA8D70", Offset = "0x4AA8D70", VA = "0x4AA8D70")]
    public void SetCombatPower(int value)
    {
    }

    [Token(Token = "0x60151B6")]
    [Address(RVA = "0x4AA8DAC", Offset = "0x4AA8DAC", VA = "0x4AA8DAC")]
    public void SetLimitBreak(int value, int max)
    {
    }

    [Token(Token = "0x60151B7")]
    [Address(RVA = "0x4AABF8C", Offset = "0x4AABF8C", VA = "0x4AABF8C")]
    public EquipmentAccessoryStatusView()
    {
    }
  }
}
