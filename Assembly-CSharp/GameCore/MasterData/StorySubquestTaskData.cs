// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestTaskData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200131A")]
  [Serializable]
  public sealed class StorySubquestTaskData : IMasterDataEntity
  {
    [Token(Token = "0x4005A4C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A4D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int parentQuest;
    [Token(Token = "0x4005A4E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005A4F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int timeslotGroupLabel;
    [Token(Token = "0x4005A50")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int taskFlagID;
    [Token(Token = "0x4005A51")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int taskFlagCheck;
    [Token(Token = "0x4005A52")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int taskType;
    [Token(Token = "0x4005A53")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int researchStaging;
    [Token(Token = "0x4005A54")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int subquestBattleID;
    [Token(Token = "0x4005A55")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int taskRewardPaymentLabel;
    [Token(Token = "0x4005A56")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int progressText;
    [Token(Token = "0x4005A57")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int advID;
    [Token(Token = "0x4005A58")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int objectID;
    [Token(Token = "0x4005A59")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int cameraMovePosition;
    [Token(Token = "0x4005A5A")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int playerMovePosition;
    [Token(Token = "0x4005A5B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public EventNpcActEnum beginNpcAct;
    [Token(Token = "0x4005A5C")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public float iconPositionX;
    [Token(Token = "0x4005A5D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public float iconPositionY;
    [Token(Token = "0x4005A5E")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public float iconPositionZ;

    [Token(Token = "0x1700104C")]
    public int Key
    {
      [Token(Token = "0x6006BE3"), Address(RVA = "0x48E6610", Offset = "0x48E6610", VA = "0x48E6610", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006BE4")]
    [Address(RVA = "0x48E6618", Offset = "0x48E6618", VA = "0x48E6618", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006BE5")]
    [Address(RVA = "0x48E6D84", Offset = "0x48E6D84", VA = "0x48E6D84", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x1700104D")]
    public StorySubquestTaskTypeEnum TaskType
    {
      [Token(Token = "0x6006BE6"), Address(RVA = "0x48E6F1C", Offset = "0x48E6F1C", VA = "0x48E6F1C")] get
      {
        return new StorySubquestTaskTypeEnum();
      }
    }

    [Token(Token = "0x1700104E")]
    public Vector3 IconOffset
    {
      [Token(Token = "0x6006BE7"), Address(RVA = "0x48E6F24", Offset = "0x48E6F24", VA = "0x48E6F24")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x1700104F")]
    public IReadOnlyList<StorySubquestRewardPaymentData> Rewards
    {
      [Token(Token = "0x6006BE8"), Address(RVA = "0x48E6F30", Offset = "0x48E6F30", VA = "0x48E6F30")] get
      {
        return (IReadOnlyList<StorySubquestRewardPaymentData>) null;
      }
    }

    [Token(Token = "0x17001050")]
    public IReadOnlyList<StorySubquestRewardPaymentData> Payments
    {
      [Token(Token = "0x6006BE9"), Address(RVA = "0x48E6FB4", Offset = "0x48E6FB4", VA = "0x48E6FB4")] get
      {
        return (IReadOnlyList<StorySubquestRewardPaymentData>) null;
      }
    }

    [Token(Token = "0x17001051")]
    public string ProgressText
    {
      [Token(Token = "0x6006BEA"), Address(RVA = "0x48E7038", Offset = "0x48E7038", VA = "0x48E7038")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006BEB")]
    [Address(RVA = "0x48E7114", Offset = "0x48E7114", VA = "0x48E7114")]
    public StorySubquestTaskData()
    {
    }
  }
}
