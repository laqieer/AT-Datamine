// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationParamData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001200")]
  [Serializable]
  public sealed class StoryCommunicationParamData : IMasterDataEntity
  {
    [Token(Token = "0x4005632")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005633")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int communicationID;
    [Token(Token = "0x4005634")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rank;
    [Token(Token = "0x4005635")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int normalConditionDate;
    [Token(Token = "0x4005636")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int normalConditionWeather;
    [Token(Token = "0x4005637")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int normalConditionTimeslot;
    [Token(Token = "0x4005638")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int rankupConditionDate;
    [Token(Token = "0x4005639")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int rankupConditionWeather;
    [Token(Token = "0x400563A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int rankupConditionTimeslot;
    [Token(Token = "0x400563B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int conditionRelationShipValue;
    [Token(Token = "0x400563C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int rankUpCommunicationADVID;
    [Token(Token = "0x400563D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int rankUpFirstRewardSetLabel;
    [Token(Token = "0x400563E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int rankUpRewardSetLabel;
    [Token(Token = "0x400563F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int generalRewardSetLabel;
    [Token(Token = "0x4005640")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int obtainRelationShipValue;
    [Token(Token = "0x4005641")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int communicationADVID;

    [Token(Token = "0x17000F7B")]
    public int Key
    {
      [Token(Token = "0x60066B9"), Address(RVA = "0x4D28334", Offset = "0x4D28334", VA = "0x4D28334", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60066BA")]
    [Address(RVA = "0x4D2833C", Offset = "0x4D2833C", VA = "0x4D2833C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60066BB")]
    [Address(RVA = "0x4D28988", Offset = "0x4D28988", VA = "0x4D28988", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60066BC")]
    [Address(RVA = "0x4D28AEC", Offset = "0x4D28AEC", VA = "0x4D28AEC")]
    public StoryCommunicationParamData()
    {
    }
  }
}
