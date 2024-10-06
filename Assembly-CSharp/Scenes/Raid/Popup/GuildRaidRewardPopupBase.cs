// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidRewardPopupBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Raid.Popup.GuildRaidAnimation;
using UnityEngine;

#nullable disable
namespace Scenes.Raid.Popup
{
  [Token(Token = "0x20029F1")]
  internal class GuildRaidRewardPopupBase : PopupBase
  {
    [Token(Token = "0x400B2C3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400B2C4")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400B2C5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400B2C6")]
    [FieldOffset(Offset = "0xA0")]
    private IGuildRaidAnimation popupAnimation;

    [Token(Token = "0x601074A")]
    [Address(RVA = "0x4890EDC", Offset = "0x4890EDC", VA = "0x4890EDC")]
    internal void Init(GuildRaidAnimationName animationName)
    {
    }

    [Token(Token = "0x601074B")]
    [Address(RVA = "0x48910EC", Offset = "0x48910EC", VA = "0x48910EC")]
    internal new void Open()
    {
    }

    [Token(Token = "0x601074C")]
    [Address(RVA = "0x48911F0", Offset = "0x48911F0", VA = "0x48911F0")]
    private new void Close()
    {
    }

    [Token(Token = "0x601074D")]
    [Address(RVA = "0x4891054", Offset = "0x4891054", VA = "0x4891054")]
    private void SetInteractive(bool interactable)
    {
    }

    [Token(Token = "0x601074E")]
    [Address(RVA = "0x48912EC", Offset = "0x48912EC", VA = "0x48912EC")]
    public GuildRaidRewardPopupBase()
    {
    }
  }
}
