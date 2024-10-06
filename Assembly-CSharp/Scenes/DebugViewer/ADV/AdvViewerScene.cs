// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap;
using Il2CppDummyDll;
using Scenes.DebugViewer.AreaMap;
using System.Collections;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2002FA9")]
  public class AdvViewerScene : GameCore.Scene.Scene
  {
    [Token(Token = "0x400CBC7")]
    [FieldOffset(Offset = "0x58")]
    private AdvViewerPresenter presenter;
    [Token(Token = "0x400CBC8")]
    [FieldOffset(Offset = "0x60")]
    private DebugAreaMapLoader loader;
    [Token(Token = "0x400CBC9")]
    [FieldOffset(Offset = "0x68")]
    private FreeMapCommonElement element;

    [Token(Token = "0x17003EE5")]
    public BindingParam<bool> IsShowGUI
    {
      [Token(Token = "0x6012A40"), Address(RVA = "0x429BBCC", Offset = "0x429BBCC", VA = "0x429BBCC")] private set
      {
      }
      [Token(Token = "0x6012A41"), Address(RVA = "0x429BBD4", Offset = "0x429BBD4", VA = "0x429BBD4")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012A42")]
    [Address(RVA = "0x429BBDC", Offset = "0x429BBDC", VA = "0x429BBDC", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6012A43")]
    [Address(RVA = "0x429BC6C", Offset = "0x429BC6C", VA = "0x429BC6C", Slot = "22")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6012A44")]
    [Address(RVA = "0x429BCC8", Offset = "0x429BCC8", VA = "0x429BCC8")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x6012A45")]
    [Address(RVA = "0x429BFAC", Offset = "0x429BFAC", VA = "0x429BFAC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6012A46")]
    [Address(RVA = "0x429BFE8", Offset = "0x429BFE8", VA = "0x429BFE8")]
    public AdvViewerScene()
    {
    }
  }
}
