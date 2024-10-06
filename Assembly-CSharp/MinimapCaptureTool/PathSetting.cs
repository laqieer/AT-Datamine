// Decompiled with JetBrains decompiler
// Type: MinimapCaptureTool.PathSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace MinimapCaptureTool
{
  [Token(Token = "0x200035F")]
  [Serializable]
  public class PathSetting
  {
    [Token(Token = "0x40013E5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("入力ディレクトリ(Assets以下)")]
    private string assetDirectoryPath;

    [Token(Token = "0x170001E4")]
    public string AssetDirectoryPath
    {
      [Token(Token = "0x6001363"), Address(RVA = "0x2869450", Offset = "0x2869450", VA = "0x2869450")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170001E5")]
    public string OutputDirectoryPath
    {
      [Token(Token = "0x6001364"), Address(RVA = "0x286949C", Offset = "0x286949C", VA = "0x286949C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6001365")]
    [Address(RVA = "0x28694DC", Offset = "0x28694DC", VA = "0x28694DC")]
    public PathSetting()
    {
    }
  }
}
