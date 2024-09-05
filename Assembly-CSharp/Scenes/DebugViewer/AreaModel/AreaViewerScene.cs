// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F7F")]
  public class AreaViewerScene : GameCore.Scene.Scene
  {
    [Token(Token = "0x400CB51")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private AreaViewerBackground background;
    [Token(Token = "0x400CB52")]
    [FieldOffset(Offset = "0x60")]
    private AreaViewerPresenter presenter;
    [Token(Token = "0x400CB53")]
    [FieldOffset(Offset = "0x68")]
    private AreaViewerModel model;

    [Token(Token = "0x17003EBD")]
    public AreaViewerBackground Background
    {
      [Token(Token = "0x6012923"), Address(RVA = "0x212AA88", Offset = "0x212AA88", VA = "0x212AA88")] get
      {
        return (AreaViewerBackground) null;
      }
    }

    [Token(Token = "0x17003EBE")]
    public BindingParam<bool> IsShowGUI
    {
      [Token(Token = "0x6012924"), Address(RVA = "0x212AA90", Offset = "0x212AA90", VA = "0x212AA90")] private set
      {
      }
      [Token(Token = "0x6012925"), Address(RVA = "0x212AA98", Offset = "0x212AA98", VA = "0x212AA98")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x6012926")]
    [Address(RVA = "0x212AAA0", Offset = "0x212AAA0", VA = "0x212AAA0", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6012927")]
    [Address(RVA = "0x212AB30", Offset = "0x212AB30", VA = "0x212AB30", Slot = "22")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6012928")]
    [Address(RVA = "0x212AC58", Offset = "0x212AC58", VA = "0x212AC58")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x6012929")]
    [Address(RVA = "0x212ADA4", Offset = "0x212ADA4", VA = "0x212ADA4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601292A")]
    [Address(RVA = "0x212AEB4", Offset = "0x212AEB4", VA = "0x212AEB4")]
    public AreaViewerScene()
    {
    }
  }
}
