// Decompiled with JetBrains decompiler
// Type: Gacha.IGachaBGView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x20014F3")]
  internal interface IGachaBGView
  {
    [Token(Token = "0x1700124B")]
    Action VideoFinished { [Token(Token = "0x6007662")] get; [Token(Token = "0x6007663")] set; }

    [Token(Token = "0x6007664")]
    void SetStillImage(Texture2D texture);

    [Token(Token = "0x6007665")]
    void PlayVideo(string url);

    [Token(Token = "0x6007666")]
    void StopVideo();

    [Token(Token = "0x1700124C")]
    GachaBGPresenter Presenter { [Token(Token = "0x6007667")] set; }
  }
}
