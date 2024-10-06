// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.StoryArchiveArchiveBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.StoryArchive.ViewModel;
using System;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x2000621")]
  public class StoryArchiveArchiveBanner : MonoBehaviour
  {
    [Token(Token = "0x4001DF1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI title;
    [Token(Token = "0x4001DF2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x4001DF3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject buttonRoot;
    [Token(Token = "0x4001DF4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject lockObject;
    [Token(Token = "0x4001DF5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton lockToasterButton;
    [Token(Token = "0x4001DF6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x4001DF7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI dayNumberText;
    [Token(Token = "0x4001DF8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI dayOfWeekText;
    [Token(Token = "0x4001DF9")]
    [FieldOffset(Offset = "0x58")]
    private bool setupDone;
    [Token(Token = "0x4001DFA")]
    [FieldOffset(Offset = "0x60")]
    private StoryArchiveListArchiveBannerViewModel viewModel;

    [Token(Token = "0x17000512")]
    public int ArchiveId
    {
      [Token(Token = "0x600236B"), Address(RVA = "0x2DA5B2C", Offset = "0x2DA5B2C", VA = "0x2DA5B2C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600236C")]
    [Address(RVA = "0x2DA5B48", Offset = "0x2DA5B48", VA = "0x2DA5B48")]
    public void Setup(
      StoryArchiveListArchiveBannerViewModel viewModel,
      Action<int> onClick,
      Action onClickLock)
    {
    }

    [Token(Token = "0x600236D")]
    [Address(RVA = "0x2DA5DD4", Offset = "0x2DA5DD4", VA = "0x2DA5DD4")]
    private IEnumerator LoadImages(StoryArchiveListArchiveBannerViewModel archive)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600236E")]
    [Address(RVA = "0x2DA5E64", Offset = "0x2DA5E64", VA = "0x2DA5E64")]
    public bool IsSetupDone() => new bool();

    [Token(Token = "0x600236F")]
    [Address(RVA = "0x2DA5E6C", Offset = "0x2DA5E6C", VA = "0x2DA5E6C")]
    public StoryArchiveArchiveBanner()
    {
    }
  }
}
