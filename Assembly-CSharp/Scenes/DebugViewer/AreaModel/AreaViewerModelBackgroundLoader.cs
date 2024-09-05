// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerModelBackgroundLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Text;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F8A")]
  public class AreaViewerModelBackgroundLoader : IAreaViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CB74")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapSceneHolder holder;
    [Token(Token = "0x400CB75")]
    [FieldOffset(Offset = "0x18")]
    private Coroutine loadScene;
    [Token(Token = "0x400CB76")]
    [FieldOffset(Offset = "0x20")]
    private Func<IEnumerator, Coroutine> StartCoroutine;
    [Token(Token = "0x400CB7A")]
    [FieldOffset(Offset = "0x40")]
    public EventHandler<AreaViewerBackground.Data> OnLoaded;
    [Token(Token = "0x400CB7B")]
    [FieldOffset(Offset = "0x48")]
    public EventHandler OnUnloaded;

    [Token(Token = "0x17003ED3")]
    public AreaViewerBackground.Data[] Backgrounds
    {
      [Token(Token = "0x6012972"), Address(RVA = "0x4290BFC", Offset = "0x4290BFC", VA = "0x4290BFC")] private set
      {
      }
      [Token(Token = "0x6012973"), Address(RVA = "0x4290C04", Offset = "0x4290C04", VA = "0x4290C04")] get
      {
        return (AreaViewerBackground.Data[]) null;
      }
    }

    [Token(Token = "0x17003ED4")]
    public AreaViewerBackground.Data Current
    {
      [Token(Token = "0x6012974"), Address(RVA = "0x4290C0C", Offset = "0x4290C0C", VA = "0x4290C0C")] private set
      {
      }
      [Token(Token = "0x6012975"), Address(RVA = "0x4290C14", Offset = "0x4290C14", VA = "0x4290C14")] get
      {
        return (AreaViewerBackground.Data) null;
      }
    }

    [Token(Token = "0x17003ED5")]
    public Camera AreaCamera
    {
      [Token(Token = "0x6012976"), Address(RVA = "0x4290C1C", Offset = "0x4290C1C", VA = "0x4290C1C")] private set
      {
      }
      [Token(Token = "0x6012977"), Address(RVA = "0x4290C24", Offset = "0x4290C24", VA = "0x4290C24")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x6012978")]
    [Address(RVA = "0x4290C2C", Offset = "0x4290C2C", VA = "0x4290C2C")]
    public AreaViewerModelBackgroundLoader(AreaViewerBackground data, MonoBehaviour behaviour)
    {
    }

    [Token(Token = "0x6012979")]
    [Address(RVA = "0x4290D00", Offset = "0x4290D00", VA = "0x4290D00", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601297A")]
    [Address(RVA = "0x4290D88", Offset = "0x4290D88", VA = "0x4290D88")]
    public void Load(int index)
    {
    }

    [Token(Token = "0x601297B")]
    [Address(RVA = "0x4290E7C", Offset = "0x4290E7C", VA = "0x4290E7C")]
    private IEnumerator LoadAsync(AreaViewerBackground.Data data) => (IEnumerator) null;

    [Token(Token = "0x601297C")]
    [Address(RVA = "0x4290E30", Offset = "0x4290E30", VA = "0x4290E30")]
    private void Unload()
    {
    }

    [Token(Token = "0x601297D")]
    [Address(RVA = "0x4290F18", Offset = "0x4290F18", VA = "0x4290F18", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x601297E")]
    [Address(RVA = "0x4290F1C", Offset = "0x4290F1C", VA = "0x4290F1C", Slot = "6")]
    public void Destroy()
    {
    }

    [Token(Token = "0x601297F")]
    [Address(RVA = "0x4290F40", Offset = "0x4290F40", VA = "0x4290F40")]
    public StringBuilder GetFullInfo(StringBuilder sb) => (StringBuilder) null;
  }
}
