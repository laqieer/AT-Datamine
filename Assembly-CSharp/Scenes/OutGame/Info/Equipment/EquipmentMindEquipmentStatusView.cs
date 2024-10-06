// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentMindEquipmentStatusView
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
  [Token(Token = "0x20035A5")]
  public class EquipmentMindEquipmentStatusView
  {
    [Token(Token = "0x17004643")]
    public EquipmentCombatPowerUI CombatPowerUI
    {
      [Token(Token = "0x60151BA"), Address(RVA = "0x4AAC050", Offset = "0x4AAC050", VA = "0x4AAC050")] private get
      {
        return (EquipmentCombatPowerUI) null;
      }
      [Token(Token = "0x60151BB"), Address(RVA = "0x4AAC058", Offset = "0x4AAC058", VA = "0x4AAC058")] set
      {
      }
    }

    [Token(Token = "0x17004644")]
    public CurrentMaxGaugeUI LevelUI
    {
      [Token(Token = "0x60151BC"), Address(RVA = "0x4AAC060", Offset = "0x4AAC060", VA = "0x4AAC060")] private get
      {
        return (CurrentMaxGaugeUI) null;
      }
      [Token(Token = "0x60151BD"), Address(RVA = "0x4AAC068", Offset = "0x4AAC068", VA = "0x4AAC068")] set
      {
      }
    }

    [Token(Token = "0x17004645")]
    public GemListUI GemListUI
    {
      [Token(Token = "0x60151BE"), Address(RVA = "0x4AAC070", Offset = "0x4AAC070", VA = "0x4AAC070")] private get
      {
        return (GemListUI) null;
      }
      [Token(Token = "0x60151BF"), Address(RVA = "0x4AAC078", Offset = "0x4AAC078", VA = "0x4AAC078")] set
      {
      }
    }

    [Token(Token = "0x17004646")]
    public ParameterView ParameterView
    {
      [Token(Token = "0x60151C0"), Address(RVA = "0x4AAC080", Offset = "0x4AAC080", VA = "0x4AAC080")] get
      {
        return (ParameterView) null;
      }
      [Token(Token = "0x60151C1"), Address(RVA = "0x4AAC088", Offset = "0x4AAC088", VA = "0x4AAC088")] set
      {
      }
    }

    [Token(Token = "0x17004647")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x60151C2"), Address(RVA = "0x4AAC090", Offset = "0x4AAC090", VA = "0x4AAC090")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x60151C3"), Address(RVA = "0x4AAC098", Offset = "0x4AAC098", VA = "0x4AAC098")] set
      {
      }
    }

    [Token(Token = "0x60151C4")]
    [Address(RVA = "0x4AA9AAC", Offset = "0x4AA9AAC", VA = "0x4AA9AAC")]
    public void SetLevel(int current, int max)
    {
    }

    [Token(Token = "0x60151C5")]
    [Address(RVA = "0x4AA9A94", Offset = "0x4AA9A94", VA = "0x4AA9A94")]
    public void SetCombatPower(int value)
    {
    }

    [Token(Token = "0x60151C6")]
    [Address(RVA = "0x4AA9AD0", Offset = "0x4AA9AD0", VA = "0x4AA9AD0")]
    public void SetLimitBreak(int value, int max)
    {
    }

    [Token(Token = "0x60151C7")]
    [Address(RVA = "0x4AAC0A0", Offset = "0x4AAC0A0", VA = "0x4AAC0A0")]
    public EquipmentMindEquipmentStatusView()
    {
    }
  }
}
