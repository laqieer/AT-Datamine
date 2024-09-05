// Decompiled with JetBrains decompiler
// Type: Scenes.Home.Balloons.HomeEventQuestBalloonView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.Balloons
{
  [Token(Token = "0x2002B6B")]
  public class HomeEventQuestBalloonView : MonoBehaviour
  {
    [Token(Token = "0x400B8EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("バナーボタン")]
    private CommonButton bannerButton;
    [Token(Token = "0x400B8EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("バナー表示切替ボタン")]
    private CommonButton bannerShowSwitchButton;
    [Token(Token = "0x400B8EC")]
    [FieldOffset(Offset = "0x28")]
    [Header("継承の間ボタンの上のラインのobject")]
    [SerializeField]
    private GameObject topLine;
    [Token(Token = "0x400B8ED")]
    [FieldOffset(Offset = "0x30")]
    [Header("バナーのRawImage")]
    [SerializeField]
    private RawImage imageBanner;
    [Token(Token = "0x400B8EE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RawImage imageBannerEffect;
    [Token(Token = "0x400B8EF")]
    [FieldOffset(Offset = "0x40")]
    [Header("タイムライン")]
    [SerializeField]
    private UITimelineController timelineController;

    [Token(Token = "0x17003A97")]
    public CommonButton BannerButton
    {
      [Token(Token = "0x6010F84"), Address(RVA = "0x1C7284C", Offset = "0x1C7284C", VA = "0x1C7284C")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x17003A98")]
    public CommonButton BannerShowSwitchButton
    {
      [Token(Token = "0x6010F85"), Address(RVA = "0x1C72854", Offset = "0x1C72854", VA = "0x1C72854")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x6010F86")]
    [Address(RVA = "0x1C72794", Offset = "0x1C72794", VA = "0x1C72794")]
    public IEnumerator Init() => (IEnumerator) null;

    [Token(Token = "0x6010F87")]
    [Address(RVA = "0x1C72078", Offset = "0x1C72078", VA = "0x1C72078")]
    public void SetTexture(Texture2D texture)
    {
    }

    [Token(Token = "0x6010F88")]
    [Address(RVA = "0x1C720B8", Offset = "0x1C720B8", VA = "0x1C720B8")]
    public void Show()
    {
    }

    [Token(Token = "0x6010F89")]
    [Address(RVA = "0x1C72754", Offset = "0x1C72754", VA = "0x1C72754")]
    public void Hide()
    {
    }

    [Token(Token = "0x6010F8A")]
    [Address(RVA = "0x1C72318", Offset = "0x1C72318", VA = "0x1C72318")]
    public void SwitchShowBanner(bool isShow, Action onAnimFinish = null)
    {
    }

    [Token(Token = "0x6010F8B")]
    [Address(RVA = "0x1C72424", Offset = "0x1C72424", VA = "0x1C72424")]
    public void ShowWarningToaster(string key)
    {
    }

    [Token(Token = "0x6010F8C")]
    [Address(RVA = "0x1C7288C", Offset = "0x1C7288C", VA = "0x1C7288C")]
    public HomeEventQuestBalloonView()
    {
    }
  }
}
