// Decompiled with JetBrains decompiler
// Type: Battle.Data.MapEditorDataAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002702")]
  public sealed class MapEditorDataAsset : ScriptableObject
  {
    [Token(Token = "0x400A6C9")]
    [FieldOffset(Offset = "0x18")]
    public int MapWidth;
    [Token(Token = "0x400A6CA")]
    [FieldOffset(Offset = "0x1C")]
    public int MapHeight;
    [Token(Token = "0x400A6CB")]
    [FieldOffset(Offset = "0x20")]
    public int MovableWidth;
    [Token(Token = "0x400A6CC")]
    [FieldOffset(Offset = "0x24")]
    public int MovableHeight;
    [Token(Token = "0x400A6CD")]
    [FieldOffset(Offset = "0x28")]
    public List<Ground> Grounds;
    [Token(Token = "0x400A6CE")]
    [FieldOffset(Offset = "0x30")]
    public List<MapObject> Objects;
    [Token(Token = "0x400A6CF")]
    [FieldOffset(Offset = "0x38")]
    public List<int> LandformAttributes;
    [Token(Token = "0x400A6D0")]
    [FieldOffset(Offset = "0x40")]
    public List<List<float>> SquareHeights;

    [Token(Token = "0x600F1B6")]
    [Address(RVA = "0x41AF5BC", Offset = "0x41AF5BC", VA = "0x41AF5BC")]
    public void SetDatas(MapEditorData data)
    {
    }

    [Token(Token = "0x600F1B7")]
    [Address(RVA = "0x41AF5F4", Offset = "0x41AF5F4", VA = "0x41AF5F4")]
    public MapEditorDataAsset()
    {
    }
  }
}
