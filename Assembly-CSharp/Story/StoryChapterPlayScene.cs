// Decompiled with JetBrains decompiler
// Type: Story.StoryChapterPlayScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using GameCore.Sound;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Story
{
  [Token(Token = "0x200059A")]
  public class StoryChapterPlayScene : GameCore.Scene.Scene, ICoroutineWorker
  {
    [Token(Token = "0x4001C51")]
    [FieldOffset(Offset = "0x58")]
    private StoryPlayerBehaviour playBehaviour;
    [Token(Token = "0x4001C52")]
    [FieldOffset(Offset = "0x60")]
    private ChangeSceneParameter sceneParameter;
    [Token(Token = "0x4001C53")]
    [FieldOffset(Offset = "0x68")]
    private SoundManager soundManager;

    [Token(Token = "0x6002059")]
    [Address(RVA = "0x2A078C0", Offset = "0x2A078C0", VA = "0x2A078C0", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x600205A")]
    [Address(RVA = "0x2A07944", Offset = "0x2A07944", VA = "0x2A07944", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x600205B")]
    [Address(RVA = "0x2A0732C", Offset = "0x2A0732C", VA = "0x2A0732C")]
    public IEnumerator FinalizeAsync() => (IEnumerator) null;

    [Token(Token = "0x600205C")]
    [Address(RVA = "0x2A079FC", Offset = "0x2A079FC", VA = "0x2A079FC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600205D")]
    [Address(RVA = "0x29FD58C", Offset = "0x29FD58C", VA = "0x29FD58C")]
    public static ICoroutineWorker GetCoroutineWorker() => (ICoroutineWorker) null;

    [Token(Token = "0x600205E")]
    [Address(RVA = "0x2A07AC4", Offset = "0x2A07AC4", VA = "0x2A07AC4")]
    public StoryChapterPlayScene()
    {
    }

    [Token(Token = "0x600205F")]
    [Address(RVA = "0x2A07ACC", Offset = "0x2A07ACC", VA = "0x2A07ACC", Slot = "23")]
    private Coroutine Story\u002EICoroutineWorker\u002EStartCoroutine(IEnumerator routine)
    {
      return (Coroutine) null;
    }
  }
}
