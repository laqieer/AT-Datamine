// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.RewardView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029E7")]
  internal class RewardView : MonoBehaviour
  {
    [Token(Token = "0x400B2A9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SubjugationRewardView subjugationReward;
    [Token(Token = "0x400B2AA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private DamageRewardView damageReward;

    [Token(Token = "0x601072B")]
    [Address(RVA = "0x4888280", Offset = "0x4888280", VA = "0x4888280")]
    public void SetReward(
      int raidId,
      int lap,
      int position,
      int score,
      int maxHp,
      AssetCachedSpawner assetCachedSpawner,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x601072C")]
    [Address(RVA = "0x4890030", Offset = "0x4890030", VA = "0x4890030")]
    public RewardView()
    {
    }
  }
}
