// Decompiled with JetBrains decompiler
// Type: UI.Direction.ResourceLoadData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x20008F2")]
  [Serializable]
  public class ResourceLoadData
  {
    [Token(Token = "0x40029D5")]
    [FieldOffset(Offset = "0x10")]
    [Tooltip("Resources フォルダからの相対ディレクトリ")]
    public string resourcesDir;
    [Token(Token = "0x40029D6")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("アセット名")]
    public string assetName;

    [Token(Token = "0x600327E")]
    [Address(RVA = "0x3C23014", Offset = "0x3C23014", VA = "0x3C23014")]
    public ResourceLoadData(string label, string asset)
    {
    }
  }
}
