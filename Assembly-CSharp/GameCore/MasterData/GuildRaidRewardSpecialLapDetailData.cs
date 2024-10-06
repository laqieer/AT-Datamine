// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardSpecialLapDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FFF")]
  [Serializable]
  public sealed class GuildRaidRewardSpecialLapDetailData : IMasterDataEntity
  {
    [Token(Token = "0x4004FC8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FC9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int specialLapRewardID;
    [Token(Token = "0x4004FCA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int lap;
    [Token(Token = "0x4004FCB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x4004FCC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4004FCD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000DBF")]
    public int Key
    {
      [Token(Token = "0x6005D48"), Address(RVA = "0x279252C", Offset = "0x279252C", VA = "0x279252C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D49")]
    [Address(RVA = "0x2792534", Offset = "0x2792534", VA = "0x2792534", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D4A")]
    [Address(RVA = "0x27927C0", Offset = "0x27927C0", VA = "0x27927C0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D4B")]
    [Address(RVA = "0x2792884", Offset = "0x2792884", VA = "0x2792884")]
    public GuildRaidRewardSpecialLapDetailData()
    {
    }
  }
}
