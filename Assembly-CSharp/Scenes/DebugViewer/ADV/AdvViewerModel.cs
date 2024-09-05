// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.DebugViewer.AreaMap;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2002FB2")]
  public class AdvViewerModel : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CBE4")]
    [FieldOffset(Offset = "0x10")]
    private List<IAdvViewerModel> models;

    [Token(Token = "0x17003EE8")]
    public Rect MainWindowRect
    {
      [Token(Token = "0x6012A61"), Address(RVA = "0x429D194", Offset = "0x429D194", VA = "0x429D194")] set
      {
      }
      [Token(Token = "0x6012A62"), Address(RVA = "0x429D1A0", Offset = "0x429D1A0", VA = "0x429D1A0")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x17003EE9")]
    public DebugAreaMapLoader Loader
    {
      [Token(Token = "0x6012A63"), Address(RVA = "0x429D1AC", Offset = "0x429D1AC", VA = "0x429D1AC")] get
      {
        return (DebugAreaMapLoader) null;
      }
    }

    [Token(Token = "0x17003EEA")]
    public AdvViewerModelPlayADV PlayADV
    {
      [Token(Token = "0x6012A64"), Address(RVA = "0x429D1B4", Offset = "0x429D1B4", VA = "0x429D1B4")] get
      {
        return (AdvViewerModelPlayADV) null;
      }
    }

    [Token(Token = "0x17003EEB")]
    public AdvViewerModelFreeMap FreeMap
    {
      [Token(Token = "0x6012A65"), Address(RVA = "0x429D1BC", Offset = "0x429D1BC", VA = "0x429D1BC")] get
      {
        return (AdvViewerModelFreeMap) null;
      }
    }

    [Token(Token = "0x17003EEC")]
    public AdvViewerScene AdvScene
    {
      [Token(Token = "0x6012A66"), Address(RVA = "0x429D1C4", Offset = "0x429D1C4", VA = "0x429D1C4")] get
      {
        return (AdvViewerScene) null;
      }
    }

    [Token(Token = "0x6012A67")]
    [Address(RVA = "0x4293044", Offset = "0x4293044", VA = "0x4293044")]
    public AdvViewerModel(AdvViewerScene scene, DebugAreaMapLoader loader)
    {
    }

    [Token(Token = "0x6012A68")]
    [Address(RVA = "0x4296FB4", Offset = "0x4296FB4", VA = "0x4296FB4", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012A69")]
    [Address(RVA = "0x42970CC", Offset = "0x42970CC", VA = "0x42970CC", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012A6A")]
    internal T Register<T>(T model) where T : IAdvViewerModel => (T) null;
  }
}
