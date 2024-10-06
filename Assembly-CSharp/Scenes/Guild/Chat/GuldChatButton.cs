// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Chat.GuldChatButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using Tween.Tweeners;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Chat
{
  [Token(Token = "0x2002C2D")]
  [Serializable]
  public class GuldChatButton
  {
    [Token(Token = "0x400BC32")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public CommonButton button;
    [Token(Token = "0x400BC33")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public TweenColor[] tweenColors;
    [Token(Token = "0x400BC34")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool isActive;

    [Token(Token = "0x6011500")]
    [Address(RVA = "0x4A1C984", Offset = "0x4A1C984", VA = "0x4A1C984")]
    public GuldChatButton()
    {
    }
  }
}
