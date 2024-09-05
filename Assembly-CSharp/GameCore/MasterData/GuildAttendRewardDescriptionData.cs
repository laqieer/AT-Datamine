// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildAttendRewardDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001016")]
  [Serializable]
  public sealed class GuildAttendRewardDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005002")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005003")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardGroupId;
    [Token(Token = "0x4005004")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x4005005")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4005006")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;
    [Token(Token = "0x4005007")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int numberOfAttendees;

    [Token(Token = "0x17000DD1")]
    public int Key
    {
      [Token(Token = "0x6005DB2"), Address(RVA = "0x2795ED0", Offset = "0x2795ED0", VA = "0x2795ED0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005DB3")]
    [Address(RVA = "0x2795ED8", Offset = "0x2795ED8", VA = "0x2795ED8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005DB4")]
    [Address(RVA = "0x2796164", Offset = "0x2796164", VA = "0x2796164", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005DB5")]
    [Address(RVA = "0x2796228", Offset = "0x2796228", VA = "0x2796228")]
    public GuildAttendRewardDescriptionData()
    {
    }
  }
}
