// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.StoryArchiveMonthBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.StoryArchive.ViewModel;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x2000630")]
  public class StoryArchiveMonthBanner : MonoBehaviour
  {
    [Token(Token = "0x4001E39")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StoryReplayMonthTypeEnum monthId;
    [Token(Token = "0x4001E3A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject selectingImage;
    [Token(Token = "0x4001E3B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x4001E3C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject lockObject;
    [Token(Token = "0x4001E3D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x4001E3E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button lockButton;

    [Token(Token = "0x1700051F")]
    public StoryReplayMonthTypeEnum Month
    {
      [Token(Token = "0x60023B8"), Address(RVA = "0x2DA825C", Offset = "0x2DA825C", VA = "0x2DA825C")] get
      {
        return new StoryReplayMonthTypeEnum();
      }
    }

    [Token(Token = "0x17000520")]
    public bool IsLocked
    {
      [Token(Token = "0x60023B9"), Address(RVA = "0x2DA8264", Offset = "0x2DA8264", VA = "0x2DA8264")] get
      {
        return new bool();
      }
      [Token(Token = "0x60023BA"), Address(RVA = "0x2DA826C", Offset = "0x2DA826C", VA = "0x2DA826C")] private set
      {
      }
    }

    [Token(Token = "0x17000521")]
    public bool IsNothing
    {
      [Token(Token = "0x60023BB"), Address(RVA = "0x2DA8278", Offset = "0x2DA8278", VA = "0x2DA8278")] get
      {
        return new bool();
      }
      [Token(Token = "0x60023BC"), Address(RVA = "0x2DA8280", Offset = "0x2DA8280", VA = "0x2DA8280")] private set
      {
      }
    }

    [Token(Token = "0x60023BD")]
    [Address(RVA = "0x2DA7FB4", Offset = "0x2DA7FB4", VA = "0x2DA7FB4")]
    public void Apply(
      StoryArchiveListMonthBannerViewModel viewModel,
      Action<StoryReplayMonthTypeEnum> onClickAction,
      Action onClickLockButton)
    {
    }

    [Token(Token = "0x60023BE")]
    [Address(RVA = "0x2DA6838", Offset = "0x2DA6838", VA = "0x2DA6838")]
    public void SetSelectingState(bool active)
    {
    }

    [Token(Token = "0x60023BF")]
    [Address(RVA = "0x2DA8294", Offset = "0x2DA8294", VA = "0x2DA8294")]
    public StoryArchiveMonthBanner()
    {
    }
  }
}
