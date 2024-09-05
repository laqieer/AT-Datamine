// Decompiled with JetBrains decompiler
// Type: Scenes.Home.HotDeal.HotDealPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.HotDeal
{
  [Token(Token = "0x2002B28")]
  internal class HotDealPopup : MonoBehaviour
  {
    [Token(Token = "0x400B799")]
    [FieldOffset(Offset = "0x18")]
    [Header("アニメーション")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400B79A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector director;
    [Token(Token = "0x400B79B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CanvasGroup charaLoopGroup;
    [Token(Token = "0x400B79C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private float appearFrame;
    [Token(Token = "0x400B79D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Header("サイドメニュー")]
    private RectTransform sideMenuParent;
    [Token(Token = "0x400B79E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private HotDealSideMenu hotDealSideMenu;
    [Token(Token = "0x400B79F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private float sideMenuContentHeight;
    [Token(Token = "0x400B7A0")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private int sideMenuViewAmount;
    [Token(Token = "0x400B7A1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private float prevShowThresholdY;
    [Token(Token = "0x400B7A2")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [Header("商品表示")]
    private HotDealContent[] hotDealContent;
    [Token(Token = "0x400B7A3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text priceText;
    [Token(Token = "0x400B7A4")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text timeText;
    [Token(Token = "0x400B7A5")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject otherGroup;
    [Token(Token = "0x400B7A6")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    [Header("ボタン")]
    private CommonButton prevButton;
    [Token(Token = "0x400B7A7")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400B7A8")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton otherButton;
    [Token(Token = "0x400B7A9")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton buyButton;
    [Token(Token = "0x400B7AA")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400B7AB")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton specifiedCommercialTransactionLawButton;
    [Token(Token = "0x400B7AC")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton fundSettlementActButton;
    [Token(Token = "0x400B7AD")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400B7AE")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400B7AF")]
    [FieldOffset(Offset = "0xC0")]
    public Action<PaidCoinShopPopupItemInfo> buyAction;
    [Token(Token = "0x400B7B0")]
    [FieldOffset(Offset = "0xC8")]
    private HotDealController controller;
    [Token(Token = "0x400B7B1")]
    [FieldOffset(Offset = "0xD0")]
    private List<HotDealSideMenu> hotDealSideMenus;
    [Token(Token = "0x400B7B2")]
    [FieldOffset(Offset = "0xD8")]
    private PaidCoinShopPopupItemInfo selectInfo;
    [Token(Token = "0x400B7B3")]
    [FieldOffset(Offset = "0xE0")]
    private DateTime endDate;
    [Token(Token = "0x400B7B4")]
    [FieldOffset(Offset = "0xE8")]
    private TimeSpan limit;
    [Token(Token = "0x400B7B5")]
    [FieldOffset(Offset = "0xF0")]
    private int rewardAmount;
    [Token(Token = "0x400B7B6")]
    [FieldOffset(Offset = "0xF4")]
    private int selectIndex;
    [Token(Token = "0x400B7B7")]
    [FieldOffset(Offset = "0xF8")]
    private bool isUnavableError;

    [Token(Token = "0x6010DC2")]
    [Address(RVA = "0x1C37BDC", Offset = "0x1C37BDC", VA = "0x1C37BDC")]
    public void SetHotDealInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6010DC3")]
    [Address(RVA = "0x1C36FF8", Offset = "0x1C36FF8", VA = "0x1C36FF8")]
    public void ResetAll()
    {
    }

    [Token(Token = "0x6010DC4")]
    [Address(RVA = "0x1C39BE4", Offset = "0x1C39BE4", VA = "0x1C39BE4")]
    private void FailedRetrieveInfo()
    {
    }

    [Token(Token = "0x6010DC5")]
    [Address(RVA = "0x1C371B0", Offset = "0x1C371B0", VA = "0x1C371B0")]
    public IEnumerator InitializeAsync(HotDealController controller, bool isUnavableError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010DC6")]
    [Address(RVA = "0x1C39D2C", Offset = "0x1C39D2C", VA = "0x1C39D2C")]
    private void Update()
    {
    }

    [Token(Token = "0x6010DC7")]
    [Address(RVA = "0x1C39FB8", Offset = "0x1C39FB8", VA = "0x1C39FB8")]
    private IEnumerator CreateSideMenu() => (IEnumerator) null;

    [Token(Token = "0x6010DC8")]
    [Address(RVA = "0x1C3A048", Offset = "0x1C3A048", VA = "0x1C3A048")]
    private void SetArticleInfo()
    {
    }

    [Token(Token = "0x6010DC9")]
    [Address(RVA = "0x1C397C4", Offset = "0x1C397C4", VA = "0x1C397C4")]
    public void Open()
    {
    }

    [Token(Token = "0x6010DCA")]
    [Address(RVA = "0x1C36134", Offset = "0x1C36134", VA = "0x1C36134")]
    public void Close()
    {
    }

    [Token(Token = "0x6010DCB")]
    [Address(RVA = "0x1C3A768", Offset = "0x1C3A768", VA = "0x1C3A768")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010DCC")]
    [Address(RVA = "0x1C3A7E8", Offset = "0x1C3A7E8", VA = "0x1C3A7E8")]
    protected IEnumerator SetDelayAction(float frame, Action action) => (IEnumerator) null;

    [Token(Token = "0x6010DCD")]
    [Address(RVA = "0x1C3A8C0", Offset = "0x1C3A8C0", VA = "0x1C3A8C0")]
    public void OnClickToSpecifiedCommercialTransaction()
    {
    }

    [Token(Token = "0x6010DCE")]
    [Address(RVA = "0x1C3A8C8", Offset = "0x1C3A8C8", VA = "0x1C3A8C8")]
    public void OnClickToFundSettlementAct()
    {
    }

    [Token(Token = "0x6010DCF")]
    [Address(RVA = "0x1C3A8D0", Offset = "0x1C3A8D0", VA = "0x1C3A8D0")]
    public void OnBackButton()
    {
    }

    [Token(Token = "0x6010DD0")]
    [Address(RVA = "0x1C3A97C", Offset = "0x1C3A97C", VA = "0x1C3A97C")]
    private void OnClickSideMenu(int index)
    {
    }

    [Token(Token = "0x6010DD1")]
    [Address(RVA = "0x1C3AA64", Offset = "0x1C3AA64", VA = "0x1C3AA64")]
    private bool AnyHotDealTimeUp() => new bool();

    [Token(Token = "0x6010DD2")]
    [Address(RVA = "0x1C3ABD4", Offset = "0x1C3ABD4", VA = "0x1C3ABD4")]
    private void SwitchSideMenu(int index, bool stopCurrent)
    {
    }

    [Token(Token = "0x6010DD3")]
    [Address(RVA = "0x1C39F38", Offset = "0x1C39F38", VA = "0x1C39F38")]
    private bool IsPrevShow() => new bool();

    [Token(Token = "0x6010DD4")]
    [Address(RVA = "0x1C39F68", Offset = "0x1C39F68", VA = "0x1C39F68")]
    private bool IsNextShow() => new bool();

    [Token(Token = "0x6010DD5")]
    [Address(RVA = "0x1C3AD88", Offset = "0x1C3AD88", VA = "0x1C3AD88")]
    private void OnClickPrev()
    {
    }

    [Token(Token = "0x6010DD6")]
    [Address(RVA = "0x1C3ADE8", Offset = "0x1C3ADE8", VA = "0x1C3ADE8")]
    private void OnClickNext()
    {
    }

    [Token(Token = "0x6010DD7")]
    [Address(RVA = "0x1C3AE48", Offset = "0x1C3AE48", VA = "0x1C3AE48")]
    private IEnumerator OnClickOther(HotDealInfoType hotDeal) => (IEnumerator) null;

    [Token(Token = "0x6010DD8")]
    [Address(RVA = "0x1C3AED8", Offset = "0x1C3AED8", VA = "0x1C3AED8")]
    public HotDealPopup()
    {
    }
  }
}
