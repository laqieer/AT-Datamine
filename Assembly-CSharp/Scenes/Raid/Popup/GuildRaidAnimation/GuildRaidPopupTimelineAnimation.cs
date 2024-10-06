// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidAnimation.GuildRaidPopupTimelineAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Scenes.Raid.Popup.GuildRaidAnimation
{
  [Token(Token = "0x2002A07")]
  internal class GuildRaidPopupTimelineAnimation : IGuildRaidAnimation
  {
    [Token(Token = "0x400B2F2")]
    [FieldOffset(Offset = "0x10")]
    private PopupBase popupBase;
    [Token(Token = "0x400B2F3")]
    [FieldOffset(Offset = "0x18")]
    private GuildRaidAnimationName animationName;

    [Token(Token = "0x601078A")]
    [Address(RVA = "0x4890970", Offset = "0x4890970", VA = "0x4890970")]
    public GuildRaidPopupTimelineAnimation(
      PopupBase popupBase,
      GuildRaidAnimationName animationName)
    {
    }

    [Token(Token = "0x601078B")]
    [Address(RVA = "0x4893CF4", Offset = "0x4893CF4", VA = "0x4893CF4", Slot = "4")]
    public void PlayIn(Action onFinish = null)
    {
    }

    [Token(Token = "0x601078C")]
    [Address(RVA = "0x4893D84", Offset = "0x4893D84", VA = "0x4893D84", Slot = "5")]
    public void PlayOut(Action onFinish = null)
    {
    }

    [Token(Token = "0x601078D")]
    [Address(RVA = "0x4893D1C", Offset = "0x4893D1C", VA = "0x4893D1C")]
    private IEnumerator Init() => (IEnumerator) null;
  }
}
