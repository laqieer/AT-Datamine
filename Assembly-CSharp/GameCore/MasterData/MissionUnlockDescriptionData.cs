// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionUnlockDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A8")]
  [Serializable]
  public sealed class MissionUnlockDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005211")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005212")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int missionUnlock;
    [Token(Token = "0x4005213")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int commonMissionBooleanType;
    [Token(Token = "0x4005214")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int commonMissionUnlockType;
    [Token(Token = "0x4005215")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int missionUnlockConditionValue1;
    [Token(Token = "0x4005216")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int missionUnlockConditionValue2;

    [Token(Token = "0x17000E5E")]
    public int Key
    {
      [Token(Token = "0x6006066"), Address(RVA = "0x28D7130", Offset = "0x28D7130", VA = "0x28D7130", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006067")]
    [Address(RVA = "0x28D7138", Offset = "0x28D7138", VA = "0x28D7138", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006068")]
    [Address(RVA = "0x28D73C4", Offset = "0x28D73C4", VA = "0x28D73C4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006069")]
    [Address(RVA = "0x28D7488", Offset = "0x28D7488", VA = "0x28D7488")]
    public MissionUnlockDescriptionData()
    {
    }
  }
}
