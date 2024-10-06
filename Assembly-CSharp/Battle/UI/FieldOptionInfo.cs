// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldOptionInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002319")]
  public class FieldOptionInfo : MonoBehaviour
  {
    [Token(Token = "0x4009493")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x4009494")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4009495")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x4009496")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("左上メニューボタン")]
    private Button battleOptionButton;
    [Token(Token = "0x4009497")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button soundOptionButton;
    [Token(Token = "0x4009498")]
    [FieldOffset(Offset = "0x40")]
    [Header("バトル設定ボタン")]
    [SerializeField]
    private FieldOptionSelectButton autoButton;
    [Token(Token = "0x4009499")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private FieldOptionSelectButton treasureButton;
    [Token(Token = "0x400949A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private FieldOptionSelectButton withoutSkillButton;
    [Token(Token = "0x400949B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private FieldOptionSelectButton withoutStratagemButton;
    [Token(Token = "0x400949C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private FieldOptionSelectButton playScenarioFastButton;
    [Token(Token = "0x400949D")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private FieldOptionSelectButton unitDeadAutoWaitButton;
    [Token(Token = "0x400949E")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private FieldOptionSelectButton lpDecreaseAutoStopButton;
    [Token(Token = "0x400949F")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private FieldOptionSelectButton setupSkipButton;
    [Token(Token = "0x40094A0")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private FieldOptionSelectButton battleSpeedButton;
    [Token(Token = "0x40094A1")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private FieldOptionSelectButton duelEffectSkipButton;
    [Token(Token = "0x40094A2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private FieldOptionSelectButton gridViewButton;
    [Token(Token = "0x40094A3")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private FieldOptionSelectButton levelUpSkipButton;
    [Token(Token = "0x40094A4")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private FieldOptionSelectButton turnEndCheckButton;
    [Token(Token = "0x40094A5")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private FieldOptionSelectButton advSkipButton;
    [Token(Token = "0x40094A6")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    [Header("サウンド設定ボタン")]
    private FieldOptionSelectButton bgmSlider;
    [Token(Token = "0x40094A7")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private FieldOptionSelectButton seSlider;
    [Token(Token = "0x40094A8")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private FieldOptionSelectButton voiceSlider;
    [Token(Token = "0x40094A9")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject[] battleMenuList;
    [Token(Token = "0x40094AA")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject[] arenaMenuList;
    [Token(Token = "0x40094AB")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40094AC")]
    [FieldOffset(Offset = "0xE0")]
    private bool showFlag;
    [Token(Token = "0x40094AD")]
    [FieldOffset(Offset = "0xE1")]
    private bool tweenFlag;
    [Token(Token = "0x40094AE")]
    [FieldOffset(Offset = "0xE2")]
    private bool optionFlag;
    [Token(Token = "0x40094AF")]
    [FieldOffset(Offset = "0xE8")]
    private UnityAction endCallback;
    [Token(Token = "0x40094B0")]
    [FieldOffset(Offset = "0xF0")]
    private MainDirector mainDirector;
    [Token(Token = "0x40094B1")]
    [FieldOffset(Offset = "0xF8")]
    private BattleConfigData battleConfig;
    [Token(Token = "0x40094B2")]
    [FieldOffset(Offset = "0x100")]
    private bool arenaFlag;

    [Token(Token = "0x17002E43")]
    public UnityAction CloseButtonEvent
    {
      [Token(Token = "0x600D673"), Address(RVA = "0x1D1E6D8", Offset = "0x1D1E6D8", VA = "0x1D1E6D8")] set
      {
      }
    }

    [Token(Token = "0x17002E44")]
    public UnityAction BattleButtonEvent
    {
      [Token(Token = "0x600D674"), Address(RVA = "0x1D1E6FC", Offset = "0x1D1E6FC", VA = "0x1D1E6FC")] set
      {
      }
    }

    [Token(Token = "0x17002E45")]
    public UnityAction SoundButtonEvent
    {
      [Token(Token = "0x600D675"), Address(RVA = "0x1D1E720", Offset = "0x1D1E720", VA = "0x1D1E720")] set
      {
      }
    }

    [Token(Token = "0x600D676")]
    [Address(RVA = "0x1D1E744", Offset = "0x1D1E744", VA = "0x1D1E744")]
    public IEnumerator InitializeCoroutine(
      MainDirector mainDirector,
      BattleConfigData battleConfig,
      bool isArena = false,
      UnityAction callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D677")]
    [Address(RVA = "0x1D1E800", Offset = "0x1D1E800", VA = "0x1D1E800")]
    public void Show()
    {
    }

    [Token(Token = "0x600D678")]
    [Address(RVA = "0x1D1E8A4", Offset = "0x1D1E8A4", VA = "0x1D1E8A4")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D679")]
    [Address(RVA = "0x1D1EA38", Offset = "0x1D1EA38", VA = "0x1D1EA38")]
    public void BattleOptionSelect()
    {
    }

    [Token(Token = "0x600D67A")]
    [Address(RVA = "0x1D1EB50", Offset = "0x1D1EB50", VA = "0x1D1EB50")]
    public void SoundOptionSelect()
    {
    }

    [Token(Token = "0x600D67B")]
    [Address(RVA = "0x1D1EC68", Offset = "0x1D1EC68", VA = "0x1D1EC68")]
    public IEnumerator PopupDelete() => (IEnumerator) null;

    [Token(Token = "0x600D67C")]
    [Address(RVA = "0x1D1ECF8", Offset = "0x1D1ECF8", VA = "0x1D1ECF8")]
    public void AutoButtonSave()
    {
    }

    [Token(Token = "0x600D67D")]
    [Address(RVA = "0x1D1EEE0", Offset = "0x1D1EEE0", VA = "0x1D1EEE0")]
    public void TreasureButtonSave()
    {
    }

    [Token(Token = "0x600D67E")]
    [Address(RVA = "0x1D1EF78", Offset = "0x1D1EF78", VA = "0x1D1EF78")]
    public void WithoutSkillButtonSave()
    {
    }

    [Token(Token = "0x600D67F")]
    [Address(RVA = "0x1D1F01C", Offset = "0x1D1F01C", VA = "0x1D1F01C")]
    public void WithoutStratagemButtonSave()
    {
    }

    [Token(Token = "0x600D680")]
    [Address(RVA = "0x1D1F0C0", Offset = "0x1D1F0C0", VA = "0x1D1F0C0")]
    public void PlayScenarioFastButtonSave()
    {
    }

    [Token(Token = "0x600D681")]
    [Address(RVA = "0x1D1F168", Offset = "0x1D1F168", VA = "0x1D1F168")]
    public void UnitDeadAutoWaitButtonSave()
    {
    }

    [Token(Token = "0x600D682")]
    [Address(RVA = "0x1D1F20C", Offset = "0x1D1F20C", VA = "0x1D1F20C")]
    public void LpDecreaseAutoStopButtonSave()
    {
    }

    [Token(Token = "0x600D683")]
    [Address(RVA = "0x1D1F2B0", Offset = "0x1D1F2B0", VA = "0x1D1F2B0")]
    public void SetupSkipButtonSave()
    {
    }

    [Token(Token = "0x600D684")]
    [Address(RVA = "0x1D1F354", Offset = "0x1D1F354", VA = "0x1D1F354")]
    public void DuelEffectSkipButtonSave()
    {
    }

    [Token(Token = "0x600D685")]
    [Address(RVA = "0x1D1F3FC", Offset = "0x1D1F3FC", VA = "0x1D1F3FC")]
    public void ArenaDuelEffectSkipButtonSave()
    {
    }

    [Token(Token = "0x600D686")]
    [Address(RVA = "0x1D1F4A4", Offset = "0x1D1F4A4", VA = "0x1D1F4A4")]
    public void GridViewButtonSave()
    {
    }

    [Token(Token = "0x600D687")]
    [Address(RVA = "0x1D1F59C", Offset = "0x1D1F59C", VA = "0x1D1F59C")]
    public void LevelUpSkipButtonSave()
    {
    }

    [Token(Token = "0x600D688")]
    [Address(RVA = "0x1D1F640", Offset = "0x1D1F640", VA = "0x1D1F640")]
    public void TurnEndCheckButtonSave()
    {
    }

    [Token(Token = "0x600D689")]
    [Address(RVA = "0x1D1F6D8", Offset = "0x1D1F6D8", VA = "0x1D1F6D8")]
    public void AdvSkipButtonSave()
    {
    }

    [Token(Token = "0x600D68A")]
    [Address(RVA = "0x1D1F770", Offset = "0x1D1F770", VA = "0x1D1F770")]
    public void ArenaGridViewButtonSave()
    {
    }

    [Token(Token = "0x600D68B")]
    [Address(RVA = "0x1D1F868", Offset = "0x1D1F868", VA = "0x1D1F868")]
    public void BattleSpeedButtonSave()
    {
    }

    [Token(Token = "0x600D68C")]
    [Address(RVA = "0x1D1F92C", Offset = "0x1D1F92C", VA = "0x1D1F92C")]
    public void ArenaBattleSpeedButtonSave()
    {
    }

    [Token(Token = "0x600D68D")]
    [Address(RVA = "0x1D1F9F0", Offset = "0x1D1F9F0", VA = "0x1D1F9F0")]
    private void OptionButtonSetting()
    {
    }

    [Token(Token = "0x600D68E")]
    [Address(RVA = "0x1D1ED90", Offset = "0x1D1ED90", VA = "0x1D1ED90")]
    private void AutoButtonActiveSet()
    {
    }

    [Token(Token = "0x600D68F")]
    [Address(RVA = "0x1D20B48", Offset = "0x1D20B48", VA = "0x1D20B48")]
    private void MenuButtonListSet(bool arena)
    {
    }

    [Token(Token = "0x600D690")]
    [Address(RVA = "0x1D20C44", Offset = "0x1D20C44", VA = "0x1D20C44")]
    public FieldOptionInfo()
    {
    }
  }
}
