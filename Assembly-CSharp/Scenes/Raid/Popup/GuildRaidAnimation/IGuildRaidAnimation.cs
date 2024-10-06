// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidAnimation.IGuildRaidAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Raid.Popup.GuildRaidAnimation
{
  [Token(Token = "0x2002A0C")]
  internal interface IGuildRaidAnimation
  {
    [Token(Token = "0x601079C")]
    void PlayIn(Action onFinish = null);

    [Token(Token = "0x601079D")]
    void PlayOut(Action onFinish = null);
  }
}
