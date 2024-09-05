// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.RaidDamageRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029D3")]
  internal class RaidDamageRanking : MonoBehaviour
  {
    [Token(Token = "0x400B24E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private VerticalGridInfiniteScrollView scrollView;
    [Token(Token = "0x400B24F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject nothing;
    [Token(Token = "0x400B250")]
    [FieldOffset(Offset = "0x28")]
    private List<DamageRankingCellResource> resources;

    [Token(Token = "0x60106AD")]
    [Address(RVA = "0x488800C", Offset = "0x488800C", VA = "0x488800C")]
    public void SetRanking(
      List<GuildRaidScoreType> scores,
      List<GuildMemberType> members,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60106AE")]
    [Address(RVA = "0x488B8A0", Offset = "0x488B8A0", VA = "0x488B8A0")]
    private void CreateList(
      List<GuildRaidScoreType> scores,
      List<GuildMemberType> members,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60106AF")]
    [Address(RVA = "0x488BC90", Offset = "0x488BC90", VA = "0x488BC90")]
    private void SetList()
    {
    }

    [Token(Token = "0x60106B0")]
    [Address(RVA = "0x488BFA8", Offset = "0x488BFA8", VA = "0x488BFA8")]
    public RaidDamageRanking()
    {
    }
  }
}
