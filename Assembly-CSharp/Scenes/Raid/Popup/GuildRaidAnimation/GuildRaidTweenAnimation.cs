// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidAnimation.GuildRaidTweenAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Raid.Popup.GuildRaidAnimation
{
  [Token(Token = "0x2002A09")]
  internal class GuildRaidTweenAnimation : IGuildRaidAnimation
  {
    [Token(Token = "0x400B2F7")]
    [FieldOffset(Offset = "0x10")]
    private readonly PopupBase popupBase;
    [Token(Token = "0x400B2F8")]
    [FieldOffset(Offset = "0x18")]
    private readonly UITweenGroup tweenGroup;
    [Token(Token = "0x400B2F9")]
    [FieldOffset(Offset = "0x20")]
    private readonly GuildRaidAnimationName animationName;

    [Token(Token = "0x6010795")]
    [Address(RVA = "0x4891014", Offset = "0x4891014", VA = "0x4891014")]
    public GuildRaidTweenAnimation(
      PopupBase popupBase,
      UITweenGroup tweenGroup,
      GuildRaidAnimationName animationName)
    {
    }

    [Token(Token = "0x6010796")]
    [Address(RVA = "0x4893FEC", Offset = "0x4893FEC", VA = "0x4893FEC", Slot = "4")]
    public void PlayIn(Action onFinish = null)
    {
    }

    [Token(Token = "0x6010797")]
    [Address(RVA = "0x4894148", Offset = "0x4894148", VA = "0x4894148", Slot = "5")]
    public void PlayOut(Action onFinish = null)
    {
    }
  }
}
