// Decompiled with JetBrains decompiler
// Type: Gacha.GachaResultView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001526")]
  internal class GachaResultView : MonoBehaviour
  {
    [Token(Token = "0x400612F")]
    public const string AssetBundleName = "ui_page_gacha_prefab";
    [Token(Token = "0x4006130")]
    private const string AssetName = "Container_GachaResult";
    [Token(Token = "0x4006131")]
    [FieldOffset(Offset = "0x18")]
    [Header("入力制御用")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4006132")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Space(10f)]
    private UITimelineController timelineController;
    [Token(Token = "0x4006133")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GachaResultRewardListItemView templateRewardListItem;
    [Token(Token = "0x4006134")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button buttonOK;
    [Token(Token = "0x4006135")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GachaPayButtonView buttonOneMore;
    [Token(Token = "0x4006136")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject objectBonusRoot;
    [Token(Token = "0x4006137")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject stepArrow;
    [Token(Token = "0x4006138")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject bonusLayout;
    [Token(Token = "0x4006139")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject objectTitleStep;
    [Token(Token = "0x400613A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text textCurrentStep;
    [Token(Token = "0x400613B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text textMaxStep;
    [Token(Token = "0x400613C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject objectTitleBonus;
    [Token(Token = "0x400613D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject templateBonusListItem;
    [Token(Token = "0x400613E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject bunusListRoot;
    [Token(Token = "0x400613F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject scheduleGroup;
    [Token(Token = "0x4006140")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text textSchedule;
    [Token(Token = "0x4006141")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GachaHeaderButtonView coinHeaderView;
    [Token(Token = "0x4006142")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GachaHeaderButtonView ticketHeaderView;
    [Token(Token = "0x4006143")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GachaHeaderButtonView medalHeaderView;
    [Token(Token = "0x4006144")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    [Header("現在回数（選択召喚用）")]
    [Space(10f)]
    private SelectGachaCountView selectGachaCount;
    [Token(Token = "0x4006145")]
    [FieldOffset(Offset = "0xB8")]
    private List<GachaResultRewardListItemView> rewardListItems;
    [Token(Token = "0x4006146")]
    [FieldOffset(Offset = "0xC0")]
    private List<GachaBonusThumbnailView> bonusRewardListItems;
    [Token(Token = "0x4006147")]
    [FieldOffset(Offset = "0xC8")]
    public Action OKButtonClicked;
    [Token(Token = "0x4006148")]
    [FieldOffset(Offset = "0xD0")]
    public Action OneMoreButtonClicked;

    [Token(Token = "0x1700126B")]
    public Action<Button> CoinHeaderClicked
    {
      [Token(Token = "0x60077A5"), Address(RVA = "0x44F4290", Offset = "0x44F4290", VA = "0x44F4290")] set
      {
      }
      [Token(Token = "0x60077A6"), Address(RVA = "0x44F42AC", Offset = "0x44F42AC", VA = "0x44F42AC")] get
      {
        return (Action<Button>) null;
      }
    }

    [Token(Token = "0x1700126C")]
    public Action<Button> TicketHeaderClicked
    {
      [Token(Token = "0x60077A7"), Address(RVA = "0x44F42C8", Offset = "0x44F42C8", VA = "0x44F42C8")] set
      {
      }
      [Token(Token = "0x60077A8"), Address(RVA = "0x44F42E4", Offset = "0x44F42E4", VA = "0x44F42E4")] get
      {
        return (Action<Button>) null;
      }
    }

    [Token(Token = "0x1700126D")]
    public Action<Button> MedalHeaderClicked
    {
      [Token(Token = "0x60077A9"), Address(RVA = "0x44F4300", Offset = "0x44F4300", VA = "0x44F4300")] set
      {
      }
      [Token(Token = "0x60077AA"), Address(RVA = "0x44F431C", Offset = "0x44F431C", VA = "0x44F431C")] get
      {
        return (Action<Button>) null;
      }
    }

    [Token(Token = "0x60077AB")]
    [Address(RVA = "0x44F4338", Offset = "0x44F4338", VA = "0x44F4338")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60077AC")]
    [Address(RVA = "0x44F43B8", Offset = "0x44F43B8", VA = "0x44F43B8")]
    public static IEnumerator Create(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<GachaResultView> onCreate)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60077AD")]
    [Address(RVA = "0x44F445C", Offset = "0x44F445C", VA = "0x44F445C")]
    private void Awake()
    {
    }

    [Token(Token = "0x60077AE")]
    [Address(RVA = "0x44F45D4", Offset = "0x44F45D4", VA = "0x44F45D4")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x60077AF")]
    [Address(RVA = "0x44F2994", Offset = "0x44F2994", VA = "0x44F2994")]
    public void SetupRewardListItems(IRewardListItemPresenter[] presenters)
    {
    }

    [Token(Token = "0x60077B0")]
    [Address(RVA = "0x44F2CB8", Offset = "0x44F2CB8", VA = "0x44F2CB8")]
    public void SetActiveSelectGachaCount(bool isActive)
    {
    }

    [Token(Token = "0x60077B1")]
    [Address(RVA = "0x44F2CD8", Offset = "0x44F2CD8", VA = "0x44F2CD8")]
    public void SetSelectGachaCount(int count)
    {
    }

    [Token(Token = "0x60077B2")]
    [Address(RVA = "0x44F2B04", Offset = "0x44F2B04", VA = "0x44F2B04")]
    public void SetupBonusArea(GachaStepUpInfo stepUpInfo, IBunusThumbnailPresenter[] presenters)
    {
    }

    [Token(Token = "0x60077B3")]
    [Address(RVA = "0x44F495C", Offset = "0x44F495C", VA = "0x44F495C")]
    public void SetupBonusThumbnails(IBunusThumbnailPresenter[] presenters)
    {
    }

    [Token(Token = "0x60077B4")]
    [Address(RVA = "0x44F48E4", Offset = "0x44F48E4", VA = "0x44F48E4")]
    public void SetupStepup(int currentStep, int maxStep)
    {
    }

    [Token(Token = "0x60077B5")]
    [Address(RVA = "0x44F2C10", Offset = "0x44F2C10", VA = "0x44F2C10")]
    public void SetupOneMoreButton(IGachaPayButtonPresenter gachaPayButtonPresenter)
    {
    }

    [Token(Token = "0x60077B6")]
    [Address(RVA = "0x44F2AA4", Offset = "0x44F2AA4", VA = "0x44F2AA4")]
    public void SetupOneMoreButtonActive(bool isActive)
    {
    }

    [Token(Token = "0x60077B7")]
    [Address(RVA = "0x44F2BE8", Offset = "0x44F2BE8", VA = "0x44F2BE8")]
    public void SetOneMoreButtonInteractable(bool flag)
    {
    }

    [Token(Token = "0x60077B8")]
    [Address(RVA = "0x44F4D04", Offset = "0x44F4D04", VA = "0x44F4D04")]
    public void SetAdRemainCount(int remainCount, bool isResult)
    {
    }

    [Token(Token = "0x60077B9")]
    [Address(RVA = "0x44F2AD4", Offset = "0x44F2AD4", VA = "0x44F2AD4")]
    public void SetBonusListEnable(bool enable)
    {
    }

    [Token(Token = "0x60077BA")]
    [Address(RVA = "0x44F28B4", Offset = "0x44F28B4", VA = "0x44F28B4")]
    public void SetSchedule(DateTime beginAt, DateTime endAt)
    {
    }

    [Token(Token = "0x60077BB")]
    [Address(RVA = "0x44F4C24", Offset = "0x44F4C24", VA = "0x44F4C24")]
    private GachaBonusThumbnailView CreateBonusListItem() => (GachaBonusThumbnailView) null;

    [Token(Token = "0x60077BC")]
    [Address(RVA = "0x44F481C", Offset = "0x44F481C", VA = "0x44F481C")]
    private GachaResultRewardListItemView CreateRewardListItem()
    {
      return (GachaResultRewardListItemView) null;
    }

    [Token(Token = "0x60077BD")]
    [Address(RVA = "0x44F4A6C", Offset = "0x44F4A6C", VA = "0x44F4A6C")]
    private void ClearBonusRewardItems()
    {
    }

    [Token(Token = "0x60077BE")]
    [Address(RVA = "0x44F4664", Offset = "0x44F4664", VA = "0x44F4664")]
    private void ClearRewardItems()
    {
    }

    [Token(Token = "0x60077BF")]
    [Address(RVA = "0x44F2F00", Offset = "0x44F2F00", VA = "0x44F2F00")]
    public void PlayInAnimation(Action onAnimationComplete)
    {
    }

    [Token(Token = "0x60077C0")]
    [Address(RVA = "0x44F30C8", Offset = "0x44F30C8", VA = "0x44F30C8")]
    public void PlayOutAnimation(Action onAnimationComplete)
    {
    }

    [Token(Token = "0x60077C1")]
    [Address(RVA = "0x44F2E68", Offset = "0x44F2E68", VA = "0x44F2E68")]
    public void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x60077C2")]
    [Address(RVA = "0x44F4D28", Offset = "0x44F4D28", VA = "0x44F4D28")]
    public void SetCoinHeaderNumText(string text)
    {
    }

    [Token(Token = "0x60077C3")]
    [Address(RVA = "0x44F4D44", Offset = "0x44F4D44", VA = "0x44F4D44")]
    public void SetMedalHeaderNumText(string text)
    {
    }

    [Token(Token = "0x60077C4")]
    [Address(RVA = "0x44F4D60", Offset = "0x44F4D60", VA = "0x44F4D60")]
    public void SetTicketHeaderNumText(string text)
    {
    }

    [Token(Token = "0x60077C5")]
    [Address(RVA = "0x44F4D7C", Offset = "0x44F4D7C", VA = "0x44F4D7C")]
    public void SetTicketIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x60077C6")]
    [Address(RVA = "0x44F4D98", Offset = "0x44F4D98", VA = "0x44F4D98")]
    public void SetMedalIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x60077C7")]
    [Address(RVA = "0x44F4DB4", Offset = "0x44F4DB4", VA = "0x44F4DB4")]
    public void SetMedalHeaderActive(bool isActive)
    {
    }

    [Token(Token = "0x60077C8")]
    [Address(RVA = "0x44F4DE4", Offset = "0x44F4DE4", VA = "0x44F4DE4")]
    public void SetTicketHeaderActive(bool isActive)
    {
    }

    [Token(Token = "0x60077C9")]
    [Address(RVA = "0x44F4E14", Offset = "0x44F4E14", VA = "0x44F4E14")]
    public GachaResultView()
    {
    }
  }
}
