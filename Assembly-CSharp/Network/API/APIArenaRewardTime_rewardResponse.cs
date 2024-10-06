// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaRewardTime_rewardResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B9C")]
  [Serializable]
  public class APIArenaRewardTime_rewardResponse
  {
    [Token(Token = "0x4007663")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Reward time_reward;
    [Token(Token = "0x4007664")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17001DE6")]
    public Reward TimeReward
    {
      [Token(Token = "0x600A23F"), Address(RVA = "0x46CA8DC", Offset = "0x46CA8DC", VA = "0x46CA8DC")] get
      {
        return (Reward) null;
      }
    }

    [Token(Token = "0x17001DE7")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600A240"), Address(RVA = "0x46CA8E4", Offset = "0x46CA8E4", VA = "0x46CA8E4")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600A241")]
    [Address(RVA = "0x46CA8EC", Offset = "0x46CA8EC", VA = "0x46CA8EC")]
    public APIArenaRewardTime_rewardResponse()
    {
    }
  }
}
