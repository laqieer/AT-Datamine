// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.UI.StylePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.UI;
using GameCore;
using GameCore.Input;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill.UI;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Style.UI
{
  [Token(Token = "0x200356B")]
  public class StylePopup : PopupBase
  {
    [Token(Token = "0x400E848")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image thumbnail;
    [Token(Token = "0x400E849")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private SkillListUI skillListUI;
    [Token(Token = "0x400E84A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private StyleStatusUI styleStatusUI;
    [Token(Token = "0x400E84B")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400E84C")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private List<GameObject> gachaObjs;
    [Token(Token = "0x400E84D")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400E84E")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CommonButton prevButton;
    [Token(Token = "0x400E84F")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonButton enhanceButton;
    [Token(Token = "0x400E850")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private ItemIcon trustThumbIcon;
    [Token(Token = "0x400E851")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private CommonButton limitbreakBonusButton;
    [Token(Token = "0x400E852")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400E853")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400E854")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400E855")]
    [FieldOffset(Offset = "0xF0")]
    private ConfirmBonusPopup confirmBonusPopup;
    [Token(Token = "0x400E858")]
    [FieldOffset(Offset = "0x108")]
    private StaqData.Style[] styles;
    [Token(Token = "0x400E859")]
    [FieldOffset(Offset = "0x110")]
    private List<CommunicationSkill>[] commuSkills;
    [Token(Token = "0x400E85A")]
    [FieldOffset(Offset = "0x118")]
    private Scenes.OutGame.Info.Style.StyleModel model;
    [Token(Token = "0x400E85B")]
    [FieldOffset(Offset = "0x120")]
    private int selectedIndex;

    [Token(Token = "0x1700458F")]
    public CoroutineHandler CoroutineHandler
    {
      [Token(Token = "0x6014F79"), Address(RVA = "0x4A9FCF8", Offset = "0x4A9FCF8", VA = "0x4A9FCF8")] get
      {
        return (CoroutineHandler) null;
      }
      [Token(Token = "0x6014F7A"), Address(RVA = "0x4A9FD00", Offset = "0x4A9FD00", VA = "0x4A9FD00")] private set
      {
      }
    }

    [Token(Token = "0x1400020E")]
    public event Action OnClose
    {
      [Token(Token = "0x6014F7B"), Address(RVA = "0x4A9FD08", Offset = "0x4A9FD08", VA = "0x4A9FD08")] add
      {
      }
      [Token(Token = "0x6014F7C"), Address(RVA = "0x4A9FDA8", Offset = "0x4A9FDA8", VA = "0x4A9FDA8")] remove
      {
      }
    }

    [Token(Token = "0x6014F7D")]
    [Address(RVA = "0x4A9E894", Offset = "0x4A9E894", VA = "0x4A9E894")]
    public void Initialize(bool isDisplayEnhance = false)
    {
    }

    [Token(Token = "0x6014F7E")]
    [Address(RVA = "0x4A9FE60", Offset = "0x4A9FE60", VA = "0x4A9FE60")]
    public void SetOnGachaChange(
      StaqData.Style[] styles,
      List<CommunicationSkill>[] commuSkills,
      Scenes.OutGame.Info.Style.StyleModel model)
    {
    }

    [Token(Token = "0x6014F7F")]
    [Address(RVA = "0x4AA0104", Offset = "0x4AA0104", VA = "0x4AA0104")]
    private void Update()
    {
    }

    [Token(Token = "0x6014F80")]
    [Address(RVA = "0x4AA0134", Offset = "0x4AA0134", VA = "0x4AA0134")]
    public StylePopupView CreateView(UIManager uiManager = null) => (StylePopupView) null;

    [Token(Token = "0x6014F81")]
    [Address(RVA = "0x4AA01D4", Offset = "0x4AA01D4", VA = "0x4AA01D4")]
    public StyleStatusView CreateStatusView() => (StyleStatusView) null;

    [Token(Token = "0x6014F82")]
    [Address(RVA = "0x4AA0254", Offset = "0x4AA0254", VA = "0x4AA0254")]
    public void SetEnhanceAction(Action action)
    {
    }

    [Token(Token = "0x6014F83")]
    [Address(RVA = "0x4AA0344", Offset = "0x4AA0344", VA = "0x4AA0344", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6014F84")]
    [Address(RVA = "0x4AA0378", Offset = "0x4AA0378", VA = "0x4AA0378")]
    public void OnClickTrust()
    {
    }

    [Token(Token = "0x6014F85")]
    [Address(RVA = "0x4AA0434", Offset = "0x4AA0434", VA = "0x4AA0434")]
    private void OnClickGachaLimitbreakBonus()
    {
    }

    [Token(Token = "0x6014F86")]
    [Address(RVA = "0x4AA0454", Offset = "0x4AA0454", VA = "0x4AA0454")]
    private IEnumerator OpenGachaLimitbreakBonusPopup() => (IEnumerator) null;

    [Token(Token = "0x6014F87")]
    [Address(RVA = "0x4AA04E4", Offset = "0x4AA04E4", VA = "0x4AA04E4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014F88")]
    [Address(RVA = "0x4AA0500", Offset = "0x4AA0500", VA = "0x4AA0500")]
    private void OnClickNext()
    {
    }

    [Token(Token = "0x6014F89")]
    [Address(RVA = "0x4AA0594", Offset = "0x4AA0594", VA = "0x4AA0594")]
    private void OnClickPrev()
    {
    }

    [Token(Token = "0x6014F8A")]
    [Address(RVA = "0x4AA0508", Offset = "0x4AA0508", VA = "0x4AA0508")]
    private void OnChange(bool isNext)
    {
    }

    [Token(Token = "0x6014F8B")]
    [Address(RVA = "0x4AA059C", Offset = "0x4AA059C", VA = "0x4AA059C")]
    public StylePopup()
    {
    }
  }
}
