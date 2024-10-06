// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.BackSceneHook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C57")]
  public class BackSceneHook : MonoBehaviour
  {
    [Token(Token = "0x60046EA")]
    [Address(RVA = "0x351CD9C", Offset = "0x351CD9C", VA = "0x351CD9C")]
    public static BackSceneHook AddComponent(SubScene subScene) => (BackSceneHook) null;

    [Token(Token = "0x60046EB")]
    public static T AddComponent<T>(SubScene subScene) where T : BackSceneHook => (T) null;

    [Token(Token = "0x60046EC")]
    [Address(RVA = "0x351CDE4", Offset = "0x351CDE4", VA = "0x351CDE4")]
    public static BackSceneHook AddPreBackScene(SubScene subScene, Action action)
    {
      return (BackSceneHook) null;
    }

    [Token(Token = "0x60046ED")]
    [Address(RVA = "0x351CF14", Offset = "0x351CF14", VA = "0x351CF14")]
    public static BackSceneHook AddPostBackScene(SubScene subScene, Action action)
    {
      return (BackSceneHook) null;
    }

    [Token(Token = "0x60046EE")]
    [Address(RVA = "0x351CE6C", Offset = "0x351CE6C", VA = "0x351CE6C")]
    private static BackSceneHook GetOrAddComponent(SubScene subScene) => (BackSceneHook) null;

    [Token(Token = "0x60046EF")]
    [Address(RVA = "0x351CF9C", Offset = "0x351CF9C", VA = "0x351CF9C")]
    public void AutoDestroy()
    {
    }

    [Token(Token = "0x17000A37")]
    public bool IsAutoDestroy
    {
      [Token(Token = "0x60046F0"), Address(RVA = "0x351D008", Offset = "0x351D008", VA = "0x351D008")] get
      {
        return new bool();
      }
      [Token(Token = "0x60046F1"), Address(RVA = "0x351D010", Offset = "0x351D010", VA = "0x351D010")] set
      {
      }
    }

    [Token(Token = "0x17000A38")]
    public Action PreBackScene
    {
      [Token(Token = "0x60046F2"), Address(RVA = "0x351D01C", Offset = "0x351D01C", VA = "0x351D01C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60046F3"), Address(RVA = "0x351D024", Offset = "0x351D024", VA = "0x351D024")] set
      {
      }
    }

    [Token(Token = "0x17000A39")]
    public Action PostBackScene
    {
      [Token(Token = "0x60046F4"), Address(RVA = "0x351D02C", Offset = "0x351D02C", VA = "0x351D02C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60046F5"), Address(RVA = "0x351D034", Offset = "0x351D034", VA = "0x351D034")] set
      {
      }
    }

    [Token(Token = "0x60046F6")]
    [Address(RVA = "0x351D03C", Offset = "0x351D03C", VA = "0x351D03C")]
    public BackSceneHook()
    {
    }
  }
}
