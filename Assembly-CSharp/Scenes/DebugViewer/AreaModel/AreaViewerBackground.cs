// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerBackground
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F8F")]
  public class AreaViewerBackground : ScriptableObject
  {
    [Token(Token = "0x400CB88")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AreaViewerBackground.Data[] backgrounds;

    [Token(Token = "0x17003EE0")]
    public AreaViewerBackground.Data[] Backgrounds
    {
      [Token(Token = "0x60129A4"), Address(RVA = "0x4291E78", Offset = "0x4291E78", VA = "0x4291E78")] get
      {
        return (AreaViewerBackground.Data[]) null;
      }
    }

    [Token(Token = "0x60129A5")]
    [Address(RVA = "0x4291E80", Offset = "0x4291E80", VA = "0x4291E80")]
    public void SetBackground(AreaViewerBackground.Data[] data)
    {
    }

    [Token(Token = "0x60129A6")]
    [Address(RVA = "0x4291E88", Offset = "0x4291E88", VA = "0x4291E88")]
    public AreaViewerBackground()
    {
    }

    [Token(Token = "0x2002F90")]
    [Serializable]
    public class Data
    {
      [Token(Token = "0x400CB89")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      public string name;
      [Token(Token = "0x400CB8A")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      public string assetName;
      [Token(Token = "0x400CB8B")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      public string assetBundleName;

      [Token(Token = "0x60129A7")]
      [Address(RVA = "0x4291E90", Offset = "0x4291E90", VA = "0x4291E90")]
      public Data()
      {
      }
    }
  }
}
