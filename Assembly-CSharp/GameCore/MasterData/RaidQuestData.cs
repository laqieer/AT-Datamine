// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RaidQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200112F")]
  [Serializable]
  public sealed class RaidQuestData : IMasterDataEntity, IStoryQuestData
  {
    [Token(Token = "0x40053A5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053A6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int raidID;
    [Token(Token = "0x40053A7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int positionID;
    [Token(Token = "0x40053A8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x40053A9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int minApplicableLap;
    [Token(Token = "0x40053AA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int maxApplicableLap;
    [Token(Token = "0x40053AB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x40053AC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int suppressRewardID;

    [Token(Token = "0x17000ED0")]
    public int Key
    {
      [Token(Token = "0x60062E6"), Address(RVA = "0x4AE3A04", Offset = "0x4AE3A04", VA = "0x4AE3A04", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062E7")]
    [Address(RVA = "0x4AE3A0C", Offset = "0x4AE3A0C", VA = "0x4AE3A0C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60062E8")]
    [Address(RVA = "0x4AE3D58", Offset = "0x4AE3D58", VA = "0x4AE3D58", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60062E9")]
    [Address(RVA = "0x4AE3E3C", Offset = "0x4AE3E3C", VA = "0x4AE3E3C", Slot = "7")]
    public int GetID() => new int();

    [Token(Token = "0x17000ED1")]
    public QuestTypeEnum TypeEnum
    {
      [Token(Token = "0x60062EA"), Address(RVA = "0x4AE3E44", Offset = "0x4AE3E44", VA = "0x4AE3E44", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000ED2")]
    public int StageId
    {
      [Token(Token = "0x60062EB"), Address(RVA = "0x4AE3E4C", Offset = "0x4AE3E4C", VA = "0x4AE3E4C", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ED3")]
    public int QuestLevel
    {
      [Token(Token = "0x60062EC"), Address(RVA = "0x4AE3E54", Offset = "0x4AE3E54", VA = "0x4AE3E54", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ED4")]
    public int MissionId
    {
      [Token(Token = "0x60062ED"), Address(RVA = "0x4AE3E5C", Offset = "0x4AE3E5C", VA = "0x4AE3E5C", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ED5")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x60062EE"), Address(RVA = "0x4AE3E64", Offset = "0x4AE3E64", VA = "0x4AE3E64", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ED6")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x60062EF"), Address(RVA = "0x4AE3E6C", Offset = "0x4AE3E6C", VA = "0x4AE3E6C", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062F0")]
    [Address(RVA = "0x4AE3E74", Offset = "0x4AE3E74", VA = "0x4AE3E74")]
    public RaidQuestData()
    {
    }
  }
}
