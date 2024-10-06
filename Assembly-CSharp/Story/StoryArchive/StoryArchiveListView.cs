// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.StoryArchiveListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.StoryArchive.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x2000624")]
  public class StoryArchiveListView : MonoBehaviour
  {
    [Token(Token = "0x4001E00")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image bannerMainImage;
    [Token(Token = "0x4001E01")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<StoryArchiveMonthBanner> monthBanners;
    [Token(Token = "0x4001E02")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton arrowLeft;
    [Token(Token = "0x4001E03")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton arrowRight;
    [Token(Token = "0x4001E04")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject arrowLeftRoot;
    [Token(Token = "0x4001E05")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject arrowRightRoot;
    [Token(Token = "0x4001E06")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject archiveBannerPrefab;
    [Token(Token = "0x4001E07")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Transform archiveBannerRoot;
    [Token(Token = "0x4001E08")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x4001E09")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ScrollRect _monthScrollRect;
    [Token(Token = "0x4001E0A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ScrollRect _daysScrollRect;
    [Token(Token = "0x4001E0B")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4001E0C")]
    [FieldOffset(Offset = "0x78")]
    private List<StoryArchiveArchiveBanner> archiveBannerInstances;
    [Token(Token = "0x4001E0D")]
    [FieldOffset(Offset = "0x80")]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x4001E0E")]
    [FieldOffset(Offset = "0x88")]
    private StoryReplayMonthTypeEnum selectingMonth;
    [Token(Token = "0x4001E0F")]
    [FieldOffset(Offset = "0x8C")]
    private bool nextMonthIsLocked;
    [Token(Token = "0x4001E10")]
    [FieldOffset(Offset = "0x8D")]
    private bool previousMonthIsLocked;
    [Token(Token = "0x4001E11")]
    [FieldOffset(Offset = "0x90")]
    private Action<StoryReplayMonthTypeEnum> OnSelectMonth;
    [Token(Token = "0x4001E12")]
    private const string BANNER_AB_NAME = "content_scenarioarchive_{0}_archivebanner";
    [Token(Token = "0x4001E13")]
    private const string BANNER_NAME_FORMAT = "{0}_ArchiveBanner";

    [Token(Token = "0x6002378")]
    [Address(RVA = "0x2DA5F50", Offset = "0x2DA5F50", VA = "0x2DA5F50")]
    public IEnumerator InitializeAsync(Action OnBack, bool startBySeptember) => (IEnumerator) null;

    [Token(Token = "0x6002379")]
    [Address(RVA = "0x2DA5FF8", Offset = "0x2DA5FF8", VA = "0x2DA5FF8")]
    private bool IsLockedMonth(StoryReplayMonthTypeEnum newValue) => new bool();

    [Token(Token = "0x600237A")]
    [Address(RVA = "0x2DA60E4", Offset = "0x2DA60E4", VA = "0x2DA60E4")]
    private void MoveMonthLeft()
    {
    }

    [Token(Token = "0x600237B")]
    [Address(RVA = "0x2DA616C", Offset = "0x2DA616C", VA = "0x2DA616C")]
    private void MoveMonthRight()
    {
    }

    [Token(Token = "0x600237C")]
    [Address(RVA = "0x2DA6130", Offset = "0x2DA6130", VA = "0x2DA6130")]
    private void Set(StoryReplayMonthTypeEnum value)
    {
    }

    [Token(Token = "0x600237D")]
    [Address(RVA = "0x2DA6344", Offset = "0x2DA6344", VA = "0x2DA6344")]
    public IEnumerator Apply(StoryArchiveListViewModel vm) => (IEnumerator) null;

    [Token(Token = "0x600237E")]
    [Address(RVA = "0x2DA63E0", Offset = "0x2DA63E0", VA = "0x2DA63E0")]
    public void InAnimation()
    {
    }

    [Token(Token = "0x600237F")]
    [Address(RVA = "0x2DA6440", Offset = "0x2DA6440", VA = "0x2DA6440")]
    public void OutAnimation()
    {
    }

    [Token(Token = "0x6002380")]
    [Address(RVA = "0x2DA6464", Offset = "0x2DA6464", VA = "0x2DA6464")]
    public IEnumerator WaitForAnimationEnd() => (IEnumerator) null;

    [Token(Token = "0x6002381")]
    [Address(RVA = "0x2DA64F4", Offset = "0x2DA64F4", VA = "0x2DA64F4")]
    private void ClearArchiveBanners()
    {
    }

    [Token(Token = "0x6002382")]
    [Address(RVA = "0x2DA66AC", Offset = "0x2DA66AC", VA = "0x2DA66AC")]
    public IEnumerator UpdateMonthBannerList(
      List<StoryArchiveListMonthBannerViewModel> monthBannerViewModels,
      Action<StoryReplayMonthTypeEnum> onSelectMonth,
      Action<StoryReplayMonthTypeEnum> firstSelected)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002383")]
    [Address(RVA = "0x2DA675C", Offset = "0x2DA675C", VA = "0x2DA675C")]
    private void OnClickLockedMonth()
    {
    }

    [Token(Token = "0x6002384")]
    [Address(RVA = "0x2DA61C0", Offset = "0x2DA61C0", VA = "0x2DA61C0")]
    public void SelectMonthBanners(StoryReplayMonthTypeEnum monthId)
    {
    }

    [Token(Token = "0x6002385")]
    [Address(RVA = "0x2DA6858", Offset = "0x2DA6858", VA = "0x2DA6858")]
    private void SetMonthBannerToScrollRectCenter(StoryReplayMonthTypeEnum monthId)
    {
    }

    [Token(Token = "0x6002386")]
    [Address(RVA = "0x2DA6A80", Offset = "0x2DA6A80", VA = "0x2DA6A80")]
    private void Update()
    {
    }

    [Token(Token = "0x6002387")]
    [Address(RVA = "0x2DA6B04", Offset = "0x2DA6B04", VA = "0x2DA6B04")]
    public void SetDayBannerToScrollRectCenter(int archiveId)
    {
    }

    [Token(Token = "0x6002388")]
    [Address(RVA = "0x2DA6D30", Offset = "0x2DA6D30", VA = "0x2DA6D30")]
    private void OnClickLock()
    {
    }

    [Token(Token = "0x6002389")]
    [Address(RVA = "0x2DA6E0C", Offset = "0x2DA6E0C", VA = "0x2DA6E0C")]
    public IEnumerator UpdateArchiveBannerList(
      List<StoryArchiveListArchiveBannerViewModel> archiveList,
      Action<int> onClickArchive)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600238A")]
    [Address(RVA = "0x2DA6EB0", Offset = "0x2DA6EB0", VA = "0x2DA6EB0")]
    public StoryArchiveListView()
    {
    }
  }
}
