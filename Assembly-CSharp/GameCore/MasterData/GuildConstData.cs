// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FBC")]
  [Serializable]
  public sealed class GuildConstData : IMasterDataEntity
  {
    [Token(Token = "0x4004F1D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F1E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int guildNameMaxLength;
    [Token(Token = "0x4004F1F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int guildIntroductionMaxLength;
    [Token(Token = "0x4004F20")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int guildBulletinBoardMaxLength;
    [Token(Token = "0x4004F21")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int joinCoolTimeHours;
    [Token(Token = "0x4004F22")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int joinHoursForGiftSending;
    [Token(Token = "0x4004F23")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int guildGiftExpirationHours;
    [Token(Token = "0x4004F24")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int guildGiftReceiveMaxCount;
    [Token(Token = "0x4004F25")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int maxInvestCount;
    [Token(Token = "0x4004F26")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int guildFavoriteMaxCount;
    [Token(Token = "0x4004F27")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int chatPostThrottle;
    [Token(Token = "0x4004F28")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int chatLogMax;
    [Token(Token = "0x4004F29")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int chatPostLengthMax;
    [Token(Token = "0x4004F2A")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int chatActiveTimeSecond;
    [Token(Token = "0x4004F2B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int chatLogThrottle;

    [Token(Token = "0x17000D9E")]
    public int Key
    {
      [Token(Token = "0x6005C4E"), Address(RVA = "0x278AB68", Offset = "0x278AB68", VA = "0x278AB68", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C4F")]
    [Address(RVA = "0x278AB70", Offset = "0x278AB70", VA = "0x278AB70", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C50")]
    [Address(RVA = "0x278B15C", Offset = "0x278B15C", VA = "0x278B15C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005C51")]
    [Address(RVA = "0x278B2B0", Offset = "0x278B2B0", VA = "0x278B2B0")]
    public GuildConstData()
    {
    }
  }
}
