// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRankupConditionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001202")]
  [Serializable]
  public sealed class StoryCommunicationRankupConditionData : IMasterDataEntity
  {
    [Token(Token = "0x4005644")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005645")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int communicationID;
    [Token(Token = "0x4005646")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int communicationRank;
    [Token(Token = "0x4005647")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int conditionHumanParameterID;
    [Token(Token = "0x4005648")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int conditionHumanParameterRank;

    [Token(Token = "0x17000F7C")]
    public int Key
    {
      [Token(Token = "0x60066C5"), Address(RVA = "0x4D28F48", Offset = "0x4D28F48", VA = "0x4D28F48", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60066C6")]
    [Address(RVA = "0x4D28F50", Offset = "0x4D28F50", VA = "0x4D28F50", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60066C7")]
    [Address(RVA = "0x4D2917C", Offset = "0x4D2917C", VA = "0x4D2917C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60066C8")]
    [Address(RVA = "0x4D29230", Offset = "0x4D29230", VA = "0x4D29230")]
    public StoryCommunicationRankupConditionData()
    {
    }
  }
}
