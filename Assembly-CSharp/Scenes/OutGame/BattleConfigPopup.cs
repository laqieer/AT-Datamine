// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BattleConfigPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031CC")]
  public class BattleConfigPopup : PopupBase
  {
    [Token(Token = "0x400D438")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400D439")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private BattleConfigItem autoBattleToggle;
    [Token(Token = "0x400D43A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BattleConfigItem[] autoBattleChildToggles;
    [Token(Token = "0x400D43B")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private BattleConfigItem priorTreasure;
    [Token(Token = "0x400D43C")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private BattleConfigItem withoutSkill;
    [Token(Token = "0x400D43D")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private BattleConfigItem withoutStratagem;
    [Token(Token = "0x400D43E")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private BattleConfigItem playScenarioFast;
    [Token(Token = "0x400D43F")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private BattleConfigItem disableOnUnitDeath;
    [Token(Token = "0x400D440")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private BattleConfigItem disableOnFpDecrease;
    [Token(Token = "0x400D441")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private BattleConfigItem autoPlacement;
    [Token(Token = "0x400D442")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private BattleConfigItem simpleDuelAnimation;
    [Token(Token = "0x400D443")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private BattleConfigItem battleSpeedButton;
    [Token(Token = "0x400D444")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private BattleConfigItem showGrid;
    [Token(Token = "0x400D445")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private BattleConfigItem levelUpSkip;
    [Token(Token = "0x400D446")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private BattleConfigItem turnEndCheck;
    [Token(Token = "0x400D447")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private BattleConfigItem advSkip;
    [Token(Token = "0x400D448")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private ScrollRect scroll;
    [Token(Token = "0x400D449")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400D44A")]
    [FieldOffset(Offset = "0x118")]
    private BattleConfigBehaviour behaviour;
    [Token(Token = "0x400D44B")]
    [FieldOffset(Offset = "0x120")]
    private Vector2 initializedScrollContentPosition;

    [Token(Token = "0x60136F8")]
    [Address(RVA = "0x4E0A6A4", Offset = "0x4E0A6A4", VA = "0x4E0A6A4")]
    public void Initialize(BattleConfigBehaviour behaviour, Action closeAction)
    {
    }

    [Token(Token = "0x60136F9")]
    [Address(RVA = "0x4E0ADC0", Offset = "0x4E0ADC0", VA = "0x4E0ADC0")]
    private void FinishedInAnime()
    {
    }

    [Token(Token = "0x60136FA")]
    [Address(RVA = "0x4E0AE68", Offset = "0x4E0AE68", VA = "0x4E0AE68")]
    private void ResetScrollNormalizePosition()
    {
    }

    [Token(Token = "0x60136FB")]
    [Address(RVA = "0x4E0AE98", Offset = "0x4E0AE98", VA = "0x4E0AE98")]
    public void Hide()
    {
    }

    [Token(Token = "0x60136FC")]
    [Address(RVA = "0x4E0AEB8", Offset = "0x4E0AEB8", VA = "0x4E0AEB8")]
    public void OnValueChangedAutoBattle(bool isOn)
    {
    }

    [Token(Token = "0x60136FD")]
    [Address(RVA = "0x4E0AF44", Offset = "0x4E0AF44", VA = "0x4E0AF44")]
    public void OnValueChangedPriorChest(bool isOn)
    {
    }

    [Token(Token = "0x60136FE")]
    [Address(RVA = "0x4E0AF58", Offset = "0x4E0AF58", VA = "0x4E0AF58")]
    public void OnValueChangedWithoutArts(bool isOn)
    {
    }

    [Token(Token = "0x60136FF")]
    [Address(RVA = "0x4E0AF6C", Offset = "0x4E0AF6C", VA = "0x4E0AF6C")]
    public void OnValueChangedWithoutStratagem(bool isOn)
    {
    }

    [Token(Token = "0x6013700")]
    [Address(RVA = "0x4E0AF80", Offset = "0x4E0AF80", VA = "0x4E0AF80")]
    public void OnValueChangedPlayScenarioFast(bool isOn)
    {
    }

    [Token(Token = "0x6013701")]
    [Address(RVA = "0x4E0AF94", Offset = "0x4E0AF94", VA = "0x4E0AF94")]
    public void OnValueChangedDisableOnUnitDeath(bool isOn)
    {
    }

    [Token(Token = "0x6013702")]
    [Address(RVA = "0x4E0AFA8", Offset = "0x4E0AFA8", VA = "0x4E0AFA8")]
    public void OnValueChangedDisableOnFpDecrease(bool isOn)
    {
    }

    [Token(Token = "0x6013703")]
    [Address(RVA = "0x4E0AFBC", Offset = "0x4E0AFBC", VA = "0x4E0AFBC")]
    public void OnValueChangedAutoPlacement(bool isOn)
    {
    }

    [Token(Token = "0x6013704")]
    [Address(RVA = "0x4E0AFD0", Offset = "0x4E0AFD0", VA = "0x4E0AFD0")]
    public void OnValueChangedSimpleDuelAnimation(bool isOn)
    {
    }

    [Token(Token = "0x6013705")]
    [Address(RVA = "0x4E0AFE4", Offset = "0x4E0AFE4", VA = "0x4E0AFE4")]
    public void OnValueChangedShowGrid(bool isOn)
    {
    }

    [Token(Token = "0x6013706")]
    [Address(RVA = "0x4E0AFF8", Offset = "0x4E0AFF8", VA = "0x4E0AFF8")]
    public void OnClickBattleSpeedButton(bool isOn)
    {
    }

    [Token(Token = "0x6013707")]
    [Address(RVA = "0x4E0B00C", Offset = "0x4E0B00C", VA = "0x4E0B00C")]
    public void OnValueChangedLevelUpSkip(bool isOn)
    {
    }

    [Token(Token = "0x6013708")]
    [Address(RVA = "0x4E0B020", Offset = "0x4E0B020", VA = "0x4E0B020")]
    public void OnValueChangedTurnEndCheck(bool isOn)
    {
    }

    [Token(Token = "0x6013709")]
    [Address(RVA = "0x4E0B034", Offset = "0x4E0B034", VA = "0x4E0B034")]
    public void OnValueChangedAdvSkip(bool isOn)
    {
    }

    [Token(Token = "0x601370A")]
    [Address(RVA = "0x4E0B048", Offset = "0x4E0B048", VA = "0x4E0B048")]
    public BattleConfigPopup()
    {
    }
  }
}
