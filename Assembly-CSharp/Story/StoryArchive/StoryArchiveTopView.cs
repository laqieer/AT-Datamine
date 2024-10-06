// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.StoryArchiveTopView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.StoryArchive.ViewModel;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x2000639")]
  public class StoryArchiveTopView : MonoBehaviour
  {
    [Token(Token = "0x4001E65")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StoryArchiveTopScenarioBanner introBanner;
    [Token(Token = "0x4001E66")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StoryArchiveTopScenarioBanner commonBanner;
    [Token(Token = "0x4001E67")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StoryArchiveTopScenarioBanner dinatanBanner;
    [Token(Token = "0x4001E68")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private StoryArchiveTopScenarioBanner lanslotBanner;
    [Token(Token = "0x4001E69")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StoryArchiveTopScenarioBanner guinevereBanner;
    [Token(Token = "0x4001E6A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton arrowButtonLeft;
    [Token(Token = "0x4001E6B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton arrowButtonRight;
    [Token(Token = "0x4001E6C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject arrowLeftRoot;
    [Token(Token = "0x4001E6D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject arrowRightRoot;
    [Token(Token = "0x4001E6E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x4001E6F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ScrollRect _scrollRect;
    [Token(Token = "0x4001E70")]
    [FieldOffset(Offset = "0x70")]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x4001E71")]
    [FieldOffset(Offset = "0x78")]
    private int viewIndex;
    [Token(Token = "0x4001E72")]
    private const int NUM_BANNER = 5;

    [Token(Token = "0x60023E6")]
    [Address(RVA = "0x2DA8C68", Offset = "0x2DA8C68", VA = "0x2DA8C68")]
    public IEnumerator InitializeAsync(
      StoryArchiveTopViewModel viewModel,
      Action<StoryArchiveTopScenarioBanner.ScenarioType> OnPressScenarioBanner,
      Action onBack)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60023E7")]
    [Address(RVA = "0x2DA8D18", Offset = "0x2DA8D18", VA = "0x2DA8D18")]
    private void OnPressLockedBanner()
    {
    }

    [Token(Token = "0x60023E8")]
    [Address(RVA = "0x2DA8DF4", Offset = "0x2DA8DF4", VA = "0x2DA8DF4")]
    private void PressArrowLeft()
    {
    }

    [Token(Token = "0x60023E9")]
    [Address(RVA = "0x2DA9068", Offset = "0x2DA9068", VA = "0x2DA9068")]
    private void PressArrowRight()
    {
    }

    [Token(Token = "0x60023EA")]
    [Address(RVA = "0x2DA8DFC", Offset = "0x2DA8DFC", VA = "0x2DA8DFC")]
    private void UpdateByCurrentViewIndex()
    {
    }

    [Token(Token = "0x60023EB")]
    [Address(RVA = "0x2DA9074", Offset = "0x2DA9074", VA = "0x2DA9074")]
    private void Update()
    {
    }

    [Token(Token = "0x60023EC")]
    [Address(RVA = "0x2DA90F8", Offset = "0x2DA90F8", VA = "0x2DA90F8")]
    public void InAnimation()
    {
    }

    [Token(Token = "0x60023ED")]
    [Address(RVA = "0x2DA911C", Offset = "0x2DA911C", VA = "0x2DA911C")]
    public void OutAnimation()
    {
    }

    [Token(Token = "0x60023EE")]
    [Address(RVA = "0x2DA9140", Offset = "0x2DA9140", VA = "0x2DA9140")]
    public IEnumerator WaitForAnimationEnd() => (IEnumerator) null;

    [Token(Token = "0x60023EF")]
    [Address(RVA = "0x2DA91D0", Offset = "0x2DA91D0", VA = "0x2DA91D0")]
    public IEnumerator PlayOpenAnimationIntro() => (IEnumerator) null;

    [Token(Token = "0x60023F0")]
    [Address(RVA = "0x2DA9260", Offset = "0x2DA9260", VA = "0x2DA9260")]
    public IEnumerator PlayOpenAnimationCommon() => (IEnumerator) null;

    [Token(Token = "0x60023F1")]
    [Address(RVA = "0x2DA92F0", Offset = "0x2DA92F0", VA = "0x2DA92F0")]
    public IEnumerator PlayOpenAnimationDinatan() => (IEnumerator) null;

    [Token(Token = "0x60023F2")]
    [Address(RVA = "0x2DA9380", Offset = "0x2DA9380", VA = "0x2DA9380")]
    public IEnumerator PlayOpenAnimationLanslot() => (IEnumerator) null;

    [Token(Token = "0x60023F3")]
    [Address(RVA = "0x2DA9410", Offset = "0x2DA9410", VA = "0x2DA9410")]
    public IEnumerator PlayOpenAnimationGuienevere() => (IEnumerator) null;

    [Token(Token = "0x60023F4")]
    [Address(RVA = "0x2DA94A0", Offset = "0x2DA94A0", VA = "0x2DA94A0")]
    public StoryArchiveTopView()
    {
    }
  }
}
