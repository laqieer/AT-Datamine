// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.StyleRankingCellResource
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
  [Token(Token = "0x2003364")]
  internal class StyleRankingCellResource
  {
    [Token(Token = "0x400DEAC")]
    [FieldOffset(Offset = "0x10")]
    public AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400DEAD")]
    [FieldOffset(Offset = "0x18")]
    public BasePowerRankingType param;
    [Token(Token = "0x400DEAE")]
    [FieldOffset(Offset = "0x20")]
    public bool isMyRanking;
    [Token(Token = "0x400DEAF")]
    [FieldOffset(Offset = "0x28")]
    public Action<StyleRankingCellResource> OnClick;

    [Token(Token = "0x6014320")]
    [Address(RVA = "0x1E16D00", Offset = "0x1E16D00", VA = "0x1E16D00")]
    public StyleRankingCellResource()
    {
    }
  }
}
