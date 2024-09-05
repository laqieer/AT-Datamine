// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.DebugAreaMapViewScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.DebugViewer.AreaMap.UI;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap
{
  [Token(Token = "0x2002F30")]
  internal class DebugAreaMapViewScene : GameCore.Scene.Scene
  {
    [Token(Token = "0x400CA6B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITweenGroup testFadeTweens;
    [Token(Token = "0x400CA6D")]
    [FieldOffset(Offset = "0x68")]
    private DebugAreaMapLoader loader;
    [Token(Token = "0x400CA6E")]
    [FieldOffset(Offset = "0x70")]
    private DebugAreaMapUIPresenter uiPresenter;

    [Token(Token = "0x17003E88")]
    private FreeMapCommonElement element
    {
      [Token(Token = "0x6012715"), Address(RVA = "0x2117098", Offset = "0x2117098", VA = "0x2117098")] set
      {
      }
      [Token(Token = "0x6012716"), Address(RVA = "0x21170A0", Offset = "0x21170A0", VA = "0x21170A0")] get
      {
        return (FreeMapCommonElement) null;
      }
    }

    [Token(Token = "0x6012717")]
    [Address(RVA = "0x21170A8", Offset = "0x21170A8", VA = "0x21170A8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6012718")]
    [Address(RVA = "0x2117138", Offset = "0x2117138", VA = "0x2117138")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x6012719")]
    [Address(RVA = "0x21172C0", Offset = "0x21172C0", VA = "0x21172C0", Slot = "22")]
    protected override void Update()
    {
    }

    [Token(Token = "0x601271A")]
    [Address(RVA = "0x21172EC", Offset = "0x21172EC", VA = "0x21172EC")]
    private void OnDrawGizmos()
    {
    }

    [Token(Token = "0x601271B")]
    [Address(RVA = "0x21173B0", Offset = "0x21173B0", VA = "0x21173B0", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x601271C")]
    [Address(RVA = "0x21173DC", Offset = "0x21173DC", VA = "0x21173DC")]
    public DebugAreaMapViewScene()
    {
    }
  }
}
