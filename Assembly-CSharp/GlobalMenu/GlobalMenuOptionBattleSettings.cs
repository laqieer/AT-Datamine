// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuOptionBattleSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using UnityEngine;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B9A")]
  public class GlobalMenuOptionBattleSettings : MonoBehaviour
  {
    [Token(Token = "0x40034D5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BattleConfigItem autoBattleToggle;
    [Token(Token = "0x40034D6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BattleConfigItem[] autoBattleChildToggles;
    [Token(Token = "0x40034D7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BattleConfigItem priorTreasure;
    [Token(Token = "0x40034D8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BattleConfigItem withoutSkill;
    [Token(Token = "0x40034D9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BattleConfigItem withoutStratagem;
    [Token(Token = "0x40034DA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private BattleConfigItem playScenarioFast;
    [Token(Token = "0x40034DB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private BattleConfigItem disableOnUnitDeath;
    [Token(Token = "0x40034DC")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BattleConfigItem disableOnFpDecrease;
    [Token(Token = "0x40034DD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private BattleConfigItem initialPlacementSkip;
    [Token(Token = "0x40034DE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private BattleConfigItem battleSpeedButton;
    [Token(Token = "0x40034DF")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private BattleConfigItem simpleDuelAnimation;
    [Token(Token = "0x40034E0")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private BattleConfigItem showGrid;
    [Token(Token = "0x40034E1")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private BattleConfigItem levelUpSkip;
    [Token(Token = "0x40034E2")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private BattleConfigItem turnEndCheck;
    [Token(Token = "0x40034E3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private BattleConfigItem advSkip;
    [Token(Token = "0x40034E4")]
    [FieldOffset(Offset = "0x90")]
    private BattleConfigBehaviour behaviour;

    [Token(Token = "0x6004230")]
    [Address(RVA = "0x2A342E0", Offset = "0x2A342E0", VA = "0x2A342E0")]
    public void Initialize(BattleConfigBehaviour behaviour)
    {
    }

    [Token(Token = "0x6004231")]
    [Address(RVA = "0x2A34CE4", Offset = "0x2A34CE4", VA = "0x2A34CE4")]
    public void OnValueChangedAutoBattle(bool isOn)
    {
    }

    [Token(Token = "0x6004232")]
    [Address(RVA = "0x2A34D78", Offset = "0x2A34D78", VA = "0x2A34D78")]
    public void OnValueChangedPriorChest(bool isOn)
    {
    }

    [Token(Token = "0x6004233")]
    [Address(RVA = "0x2A34D90", Offset = "0x2A34D90", VA = "0x2A34D90")]
    public void OnValueChangedWithoutArts(bool isOn)
    {
    }

    [Token(Token = "0x6004234")]
    [Address(RVA = "0x2A34DA8", Offset = "0x2A34DA8", VA = "0x2A34DA8")]
    public void OnValueChangedWithoutStratagem(bool isOn)
    {
    }

    [Token(Token = "0x6004235")]
    [Address(RVA = "0x2A34DC0", Offset = "0x2A34DC0", VA = "0x2A34DC0")]
    public void OnValueChangedPlayScenarioFast(bool isOn)
    {
    }

    [Token(Token = "0x6004236")]
    [Address(RVA = "0x2A34DD8", Offset = "0x2A34DD8", VA = "0x2A34DD8")]
    public void OnValueChangedDisableOnUnitDeath(bool isOn)
    {
    }

    [Token(Token = "0x6004237")]
    [Address(RVA = "0x2A34DF0", Offset = "0x2A34DF0", VA = "0x2A34DF0")]
    public void OnValueChangedDisableOnFpDecrease(bool isOn)
    {
    }

    [Token(Token = "0x6004238")]
    [Address(RVA = "0x2A34E08", Offset = "0x2A34E08", VA = "0x2A34E08")]
    public void OnValueChangedAutoPlacement(bool isOn)
    {
    }

    [Token(Token = "0x6004239")]
    [Address(RVA = "0x2A34E20", Offset = "0x2A34E20", VA = "0x2A34E20")]
    public void OnValueChangedSimpleDuelAnimation(bool isOn)
    {
    }

    [Token(Token = "0x600423A")]
    [Address(RVA = "0x2A34E38", Offset = "0x2A34E38", VA = "0x2A34E38")]
    public void OnValueChangedShowGrid(bool isOn)
    {
    }

    [Token(Token = "0x600423B")]
    [Address(RVA = "0x2A34E50", Offset = "0x2A34E50", VA = "0x2A34E50")]
    public void OnClickBattleSpeedButton(bool isOn)
    {
    }

    [Token(Token = "0x600423C")]
    [Address(RVA = "0x2A34E68", Offset = "0x2A34E68", VA = "0x2A34E68")]
    public void OnValueChangedLevelUpSkip(bool isOn)
    {
    }

    [Token(Token = "0x600423D")]
    [Address(RVA = "0x2A34E80", Offset = "0x2A34E80", VA = "0x2A34E80")]
    public void OnValueChangedTurnEndCheck(bool isOn)
    {
    }

    [Token(Token = "0x600423E")]
    [Address(RVA = "0x2A34E98", Offset = "0x2A34E98", VA = "0x2A34E98")]
    public void OnValueChangedAdvSkip(bool isOn)
    {
    }

    [Token(Token = "0x600423F")]
    [Address(RVA = "0x2A34EB0", Offset = "0x2A34EB0", VA = "0x2A34EB0")]
    public GlobalMenuOptionBattleSettings()
    {
    }
  }
}
