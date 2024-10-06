// Decompiled with JetBrains decompiler
// Type: IntroChapter.SceneProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A8A")]
  public abstract class SceneProcess
  {
    [Token(Token = "0x40030A8")]
    [FieldOffset(Offset = "0x10")]
    private ISceneProcessCoroutineMethod coroutineMethod;
    [Token(Token = "0x40030A9")]
    [FieldOffset(Offset = "0x18")]
    private IntroChapterMain main;

    [Token(Token = "0x6003BE7")]
    [Address(RVA = "0x331DE14", Offset = "0x331DE14", VA = "0x331DE14")]
    public SceneProcess(ISceneProcessCoroutineMethod coMethod, IntroChapterMain main)
    {
    }

    [Token(Token = "0x6003BE8")]
    public abstract void Initialize();

    [Token(Token = "0x6003BE9")]
    public abstract IEnumerator InitializeAsync();

    [Token(Token = "0x6003BEA")]
    public abstract void OnUpdate();

    [Token(Token = "0x6003BEB")]
    public abstract void Destroy();

    [Token(Token = "0x6003BEC")]
    public abstract void OnPause();

    [Token(Token = "0x6003BED")]
    public abstract void OnResume();

    [Token(Token = "0x6003BEE")]
    public abstract void BackKeyDownAction();

    [Token(Token = "0x6003BEF")]
    public abstract void Disable();

    [Token(Token = "0x6003BF0")]
    [Address(RVA = "0x331E3D4", Offset = "0x331E3D4", VA = "0x331E3D4")]
    protected Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6003BF1")]
    [Address(RVA = "0x331F958", Offset = "0x331F958", VA = "0x331F958")]
    protected void StopCoroutine(Coroutine routine)
    {
    }
  }
}
