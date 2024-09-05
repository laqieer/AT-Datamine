// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A6")]
  [Serializable]
  public sealed class MissionData : IMasterDataEntity
  {
    [Token(Token = "0x4005206")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005207")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005208")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string description;
    [Token(Token = "0x4005209")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x400520A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string subGroupName;
    [Token(Token = "0x400520B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int scheduleId;
    [Token(Token = "0x400520C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int receiveRewardScheduleId;
    [Token(Token = "0x400520D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public MissionResetTypeEnum resetTypeId;
    [Token(Token = "0x400520E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int missionAchievementCondition;
    [Token(Token = "0x400520F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int missionUnlock;
    [Token(Token = "0x4005210")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int progressPoint;

    [Token(Token = "0x17000E5B")]
    public int Key
    {
      [Token(Token = "0x600605C"), Address(RVA = "0x28D68D4", Offset = "0x28D68D4", VA = "0x28D68D4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600605D")]
    [Address(RVA = "0x28D68DC", Offset = "0x28D68DC", VA = "0x28D68DC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600605E")]
    [Address(RVA = "0x28D6D48", Offset = "0x28D6D48", VA = "0x28D6D48", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E5C")]
    public string Name
    {
      [Token(Token = "0x600605F"), Address(RVA = "0x28D6E68", Offset = "0x28D6E68", VA = "0x28D6E68")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E5D")]
    public string Description
    {
      [Token(Token = "0x6006060"), Address(RVA = "0x28D6F44", Offset = "0x28D6F44", VA = "0x28D6F44")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006061")]
    [Address(RVA = "0x28D7020", Offset = "0x28D7020", VA = "0x28D7020")]
    public MissionData()
    {
    }
  }
}
