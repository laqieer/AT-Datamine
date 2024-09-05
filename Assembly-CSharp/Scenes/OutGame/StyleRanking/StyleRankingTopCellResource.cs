// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.StyleRankingTopCellResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x2003379")]
  internal class StyleRankingTopCellResource
  {
    [Token(Token = "0x400DF29")]
    [FieldOffset(Offset = "0x10")]
    public AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400DF2A")]
    [FieldOffset(Offset = "0x18")]
    public int index;
    [Token(Token = "0x400DF2B")]
    [FieldOffset(Offset = "0x20")]
    public BaseRankingListType param;
    [Token(Token = "0x400DF2C")]
    [FieldOffset(Offset = "0x28")]
    public Action<int> OnClick;

    [Token(Token = "0x60143AA")]
    [Address(RVA = "0x1E1B05C", Offset = "0x1E1B05C", VA = "0x1E1B05C")]
    public StyleRankingTopCellResource()
    {
    }
  }
}
