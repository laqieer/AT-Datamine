// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRoleRewardDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200101B")]
  [Serializable]
  public sealed class GuildRoleRewardDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005014")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005015")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardGroupId;
    [Token(Token = "0x4005016")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public GuildRoleTypeEnum roleType;
    [Token(Token = "0x4005017")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x4005018")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4005019")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000DD3")]
    public int Key
    {
      [Token(Token = "0x6005DC8"), Address(RVA = "0x2796CEC", Offset = "0x2796CEC", VA = "0x2796CEC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005DC9")]
    [Address(RVA = "0x2796CF4", Offset = "0x2796CF4", VA = "0x2796CF4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005DCA")]
    [Address(RVA = "0x2796F80", Offset = "0x2796F80", VA = "0x2796F80", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005DCB")]
    [Address(RVA = "0x2797044", Offset = "0x2797044", VA = "0x2797044")]
    public GuildRoleRewardDescriptionData()
    {
    }
  }
}
