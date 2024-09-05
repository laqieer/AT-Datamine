// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.StoryArchiveTopScenarioBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x2000632")]
  public class StoryArchiveTopScenarioBanner : MonoBehaviour
  {
    [Token(Token = "0x4001E43")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image bannerMainImage;
    [Token(Token = "0x4001E44")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StoryArchiveTopScenarioBanner.ScenarioType scenarioType;
    [Token(Token = "0x4001E45")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton commonButton;
    [Token(Token = "0x4001E46")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject lockPanel;
    [Token(Token = "0x4001E47")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Animator lockPanelAnimator;
    [Token(Token = "0x4001E48")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject newBadgeObject;
    [Token(Token = "0x4001E49")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayableDirector onPressButtonAnimationPlayableDirector;
    [Token(Token = "0x4001E4A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton lockButton;
    [Token(Token = "0x4001E4B")]
    private const string BANNER_AB_NAME = "content_scenarioarchive_{0}_archivebanner";
    [Token(Token = "0x4001E4C")]
    private const string BANNER_NAME_FORMAT = "{0}_ArchiveBanner";

    [Token(Token = "0x60023C2")]
    [Address(RVA = "0x2DA82CC", Offset = "0x2DA82CC", VA = "0x2DA82CC")]
    public void SetBadgeActive(bool active)
    {
    }

    [Token(Token = "0x60023C3")]
    [Address(RVA = "0x2DA82EC", Offset = "0x2DA82EC", VA = "0x2DA82EC")]
    public void SetBannerImage(int bannerImageId)
    {
    }

    [Token(Token = "0x60023C4")]
    [Address(RVA = "0x2DA830C", Offset = "0x2DA830C", VA = "0x2DA830C")]
    private IEnumerator SetBannerImageAsync(int bannerImageId) => (IEnumerator) null;

    [Token(Token = "0x60023C5")]
    [Address(RVA = "0x2DA83AC", Offset = "0x2DA83AC", VA = "0x2DA83AC")]
    public void SetActiveLockPanel(bool active)
    {
    }

    [Token(Token = "0x60023C6")]
    [Address(RVA = "0x2DA83CC", Offset = "0x2DA83CC", VA = "0x2DA83CC")]
    public void AddToLockButtonBind(Action action)
    {
    }

    [Token(Token = "0x60023C7")]
    [Address(RVA = "0x2DA849C", Offset = "0x2DA849C", VA = "0x2DA849C")]
    public void AddToButtonBind(
      Action<StoryArchiveTopScenarioBanner.ScenarioType> action)
    {
    }

    [Token(Token = "0x60023C8")]
    [Address(RVA = "0x2DA858C", Offset = "0x2DA858C", VA = "0x2DA858C")]
    private IEnumerator OnPressButton(
      Action<StoryArchiveTopScenarioBanner.ScenarioType> action)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60023C9")]
    [Address(RVA = "0x2DA8628", Offset = "0x2DA8628", VA = "0x2DA8628")]
    private IEnumerator PlayPressButtonAnimation() => (IEnumerator) null;

    [Token(Token = "0x60023CA")]
    [Address(RVA = "0x2DA86B8", Offset = "0x2DA86B8", VA = "0x2DA86B8")]
    public IEnumerator OpenAnimation() => (IEnumerator) null;

    [Token(Token = "0x60023CB")]
    [Address(RVA = "0x2DA8748", Offset = "0x2DA8748", VA = "0x2DA8748")]
    public StoryArchiveTopScenarioBanner()
    {
    }

    [Token(Token = "0x2000633")]
    public enum ScenarioType
    {
      [Token(Token = "0x4001E4E")] Intro,
      [Token(Token = "0x4001E4F")] Common,
      [Token(Token = "0x4001E50")] Dinatan,
      [Token(Token = "0x4001E51")] Lanslot,
      [Token(Token = "0x4001E52")] Guinevere,
    }
  }
}
