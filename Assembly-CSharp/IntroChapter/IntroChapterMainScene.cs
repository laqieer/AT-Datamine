// Decompiled with JetBrains decompiler
// Type: IntroChapter.IntroChapterMainScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using UnityEngine;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A75")]
  public class IntroChapterMainScene : GameCore.Scene.Scene, ISceneProcessCoroutineMethod
  {
    [Token(Token = "0x400306E")]
    [FieldOffset(Offset = "0x58")]
    private IntroChapterMain main;
    [Token(Token = "0x400306F")]
    [FieldOffset(Offset = "0x60")]
    private SceneProcess nowProcess;

    [Token(Token = "0x6003B57")]
    [Address(RVA = "0x331CFA8", Offset = "0x331CFA8", VA = "0x331CFA8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6003B58")]
    [Address(RVA = "0x331D1A4", Offset = "0x331D1A4", VA = "0x331D1A4")]
    private SceneProcess Create(IntroChapterSeqContentsPramData sequenceParam)
    {
      return (SceneProcess) null;
    }

    [Token(Token = "0x6003B59")]
    [Address(RVA = "0x331D690", Offset = "0x331D690", VA = "0x331D690", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003B5A")]
    [Address(RVA = "0x331D720", Offset = "0x331D720", VA = "0x331D720", Slot = "22")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6003B5B")]
    [Address(RVA = "0x331D750", Offset = "0x331D750", VA = "0x331D750", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6003B5C")]
    [Address(RVA = "0x331D780", Offset = "0x331D780", VA = "0x331D780", Slot = "8")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6003B5D")]
    [Address(RVA = "0x331D7B0", Offset = "0x331D7B0", VA = "0x331D7B0", Slot = "4")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x6003B5E")]
    [Address(RVA = "0x331D7E0", Offset = "0x331D7E0", VA = "0x331D7E0", Slot = "5")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x6003B5F")]
    [Address(RVA = "0x331D810", Offset = "0x331D810", VA = "0x331D810", Slot = "20")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6003B60")]
    [Address(RVA = "0x331D840", Offset = "0x331D840", VA = "0x331D840")]
    public IntroChapterMainScene()
    {
    }

    [Token(Token = "0x6003B61")]
    [Address(RVA = "0x331D848", Offset = "0x331D848", VA = "0x331D848", Slot = "23")]
    private Coroutine IntroChapter\u002EISceneProcessCoroutineMethod\u002EStartCoroutine(
      IEnumerator routine)
    {
      return (Coroutine) null;
    }

    [Token(Token = "0x6003B62")]
    [Address(RVA = "0x331D850", Offset = "0x331D850", VA = "0x331D850", Slot = "24")]
    private void IntroChapter\u002EISceneProcessCoroutineMethod\u002EStopCoroutine(Coroutine routine)
    {
    }
  }
}
