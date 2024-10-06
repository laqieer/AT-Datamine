// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.HighScoreRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000836")]
  public class HighScoreRanking : MonoBehaviour
  {
    [Token(Token = "0x4002722")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private HighScoreRankingItem topHighScoreRankingItem;
    [Token(Token = "0x4002723")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<HighScoreRankingItem> highScoreRankingItems;
    [Token(Token = "0x4002724")]
    [FieldOffset(Offset = "0x28")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x4002725")]
    [FieldOffset(Offset = "0x30")]
    private int scoreAttackId;

    [Token(Token = "0x6002F3D")]
    [Address(RVA = "0x3E6D3C0", Offset = "0x3E6D3C0", VA = "0x3E6D3C0")]
    public void Initialize(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6002F3E")]
    [Address(RVA = "0x3E6D3C8", Offset = "0x3E6D3C8", VA = "0x3E6D3C8")]
    public void Create(APIScoreAttackResponse response, int scoreAttackId)
    {
    }

    [Token(Token = "0x6002F3F")]
    [Address(RVA = "0x3E6E188", Offset = "0x3E6E188", VA = "0x3E6E188")]
    public void OpenRankingRewardPopup()
    {
    }

    [Token(Token = "0x6002F40")]
    [Address(RVA = "0x3E6E1A8", Offset = "0x3E6E1A8", VA = "0x3E6E1A8")]
    private IEnumerator IEOpenRankingRewardPopup() => (IEnumerator) null;

    [Token(Token = "0x6002F41")]
    [Address(RVA = "0x3E6E238", Offset = "0x3E6E238", VA = "0x3E6E238")]
    public HighScoreRanking()
    {
    }
  }
}
