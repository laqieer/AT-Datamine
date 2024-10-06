// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.DamageRankingCellResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029B5")]
  internal class DamageRankingCellResource
  {
    [Token(Token = "0x400B1AA")]
    [FieldOffset(Offset = "0x10")]
    public AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B1AB")]
    [FieldOffset(Offset = "0x18")]
    public GuildRaidScoreType scoreParam;
    [Token(Token = "0x400B1AC")]
    [FieldOffset(Offset = "0x20")]
    public GuildMemberType memberParam;
    [Token(Token = "0x400B1AD")]
    [FieldOffset(Offset = "0x28")]
    public bool isMyRanking;

    [Token(Token = "0x601060C")]
    [Address(RVA = "0x4884E68", Offset = "0x4884E68", VA = "0x4884E68")]
    public DamageRankingCellResource()
    {
    }
  }
}
