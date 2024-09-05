// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BattleConfigPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031CB")]
  public sealed class BattleConfigPanel : MonoBehaviour
  {
    [Token(Token = "0x400D425")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D426")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle autoBattleToggle;
    [Token(Token = "0x400D427")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Toggle[] autoBattleChildToggles;
    [Token(Token = "0x400D428")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle priorTreasure;
    [Token(Token = "0x400D429")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Toggle withoutSkill;
    [Token(Token = "0x400D42A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Toggle withoutStratagem;
    [Token(Token = "0x400D42B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Toggle priorHealItem;
    [Token(Token = "0x400D42C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Toggle playScenarioFast;
    [Token(Token = "0x400D42D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Toggle autoPlacement;
    [Token(Token = "0x400D42E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Toggle simpleDuelAnimation;
    [Token(Token = "0x400D42F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Toggle autoRepair;
    [Token(Token = "0x400D430")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Button battleSpeedButton;
    [Token(Token = "0x400D431")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ScrollRect scroll;
    [Token(Token = "0x400D432")]
    private const string ShowAnimationName = "Popup_In";
    [Token(Token = "0x400D433")]
    private const string HideAnimationName = "Popup_Out";
    [Token(Token = "0x400D434")]
    private const string AutoBattleOnAnimationName = "AutoBattle_On";
    [Token(Token = "0x400D435")]
    private const string AutoBattleOffAnimationName = "AutoBattle_Off";
    [Token(Token = "0x400D436")]
    [FieldOffset(Offset = "0x80")]
    private BattleConfigBehaviour behaviour;
    [Token(Token = "0x400D437")]
    [FieldOffset(Offset = "0x88")]
    private Vector2 initializedScrollContentPosition;

    [Token(Token = "0x60136E8")]
    [Address(RVA = "0x4E0A11C", Offset = "0x4E0A11C", VA = "0x4E0A11C")]
    public void Initialize(BattleConfigBehaviour behaviour)
    {
    }

    [Token(Token = "0x60136E9")]
    [Address(RVA = "0x4E0A220", Offset = "0x4E0A220", VA = "0x4E0A220")]
    public void Show()
    {
    }

    [Token(Token = "0x60136EA")]
    [Address(RVA = "0x4E0A420", Offset = "0x4E0A420", VA = "0x4E0A420")]
    public void Hide()
    {
    }

    [Token(Token = "0x60136EB")]
    [Address(RVA = "0x4E0A3F4", Offset = "0x4E0A3F4", VA = "0x4E0A3F4")]
    private void ResetScrollNormalizePosition()
    {
    }

    [Token(Token = "0x60136EC")]
    [Address(RVA = "0x4E0A48C", Offset = "0x4E0A48C", VA = "0x4E0A48C")]
    public void OnValueChangedAutoBattle(bool isOn)
    {
    }

    [Token(Token = "0x60136ED")]
    [Address(RVA = "0x4E0A578", Offset = "0x4E0A578", VA = "0x4E0A578")]
    public void OnValueChangedPriorChest(bool isOn)
    {
    }

    [Token(Token = "0x60136EE")]
    [Address(RVA = "0x4E0A58C", Offset = "0x4E0A58C", VA = "0x4E0A58C")]
    public void OnValueChangedWithoutArts(bool isOn)
    {
    }

    [Token(Token = "0x60136EF")]
    [Address(RVA = "0x4E0A5A0", Offset = "0x4E0A5A0", VA = "0x4E0A5A0")]
    public void OnValueChangedWithoutStratagem(bool isOn)
    {
    }

    [Token(Token = "0x60136F0")]
    [Address(RVA = "0x4E0A5B4", Offset = "0x4E0A5B4", VA = "0x4E0A5B4")]
    public void OnValueChangedPriorHealItem(bool isOn)
    {
    }

    [Token(Token = "0x60136F1")]
    [Address(RVA = "0x4E0A5C8", Offset = "0x4E0A5C8", VA = "0x4E0A5C8")]
    public void OnValueChangedPlayScenarioFast(bool isOn)
    {
    }

    [Token(Token = "0x60136F2")]
    [Address(RVA = "0x4E0A5DC", Offset = "0x4E0A5DC", VA = "0x4E0A5DC")]
    public void OnValueChangedAutoPlacement(bool isOn)
    {
    }

    [Token(Token = "0x60136F3")]
    [Address(RVA = "0x4E0A5F0", Offset = "0x4E0A5F0", VA = "0x4E0A5F0")]
    public void OnValueChangedSimpleDuelAnimation(bool isOn)
    {
    }

    [Token(Token = "0x60136F4")]
    [Address(RVA = "0x4E0A604", Offset = "0x4E0A604", VA = "0x4E0A604")]
    public void OnValueChangedAutoRepair(bool isOn)
    {
    }

    [Token(Token = "0x60136F5")]
    [Address(RVA = "0x4E0A618", Offset = "0x4E0A618", VA = "0x4E0A618")]
    public void OnClickBattleSpeedButton(bool isOn)
    {
    }

    [Token(Token = "0x60136F6")]
    [Address(RVA = "0x4E0A62C", Offset = "0x4E0A62C", VA = "0x4E0A62C")]
    public BattleConfigPanel()
    {
    }
  }
}
