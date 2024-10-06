// Decompiled with JetBrains decompiler
// Type: Story.IStoryContentSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000595")]
  public interface IStoryContentSystem
  {
    [Token(Token = "0x600203C")]
    Coroutine StartCoroutine(IEnumerator coroutine);

    [Token(Token = "0x600203D")]
    PlayingStoryInfo GetPlayingStory();

    [Token(Token = "0x600203E")]
    void EndContent();

    [Token(Token = "0x600203F")]
    void ChangeHeader();

    [Token(Token = "0x6002040")]
    void ReturnHome();
  }
}
