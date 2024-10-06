// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRankupTermData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001207")]
  [Serializable]
  public sealed class StoryCommunicationRankupTermData : IMasterDataEntity
  {
    [Token(Token = "0x4005650")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005651")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int communicationID;
    [Token(Token = "0x4005652")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int communicationRank;
    [Token(Token = "0x4005653")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int conditionRouteID;
    [Token(Token = "0x4005654")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int seasonBegin;
    [Token(Token = "0x4005655")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int seasonEnd;

    [Token(Token = "0x17000F80")]
    public int Key
    {
      [Token(Token = "0x60066D7"), Address(RVA = "0x4D29728", Offset = "0x4D29728", VA = "0x4D29728", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60066D8")]
    [Address(RVA = "0x4D29730", Offset = "0x4D29730", VA = "0x4D29730", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60066D9")]
    [Address(RVA = "0x4D299BC", Offset = "0x4D299BC", VA = "0x4D299BC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60066DA")]
    [Address(RVA = "0x4D29A80", Offset = "0x4D29A80", VA = "0x4D29A80")]
    public StoryCommunicationRankupTermData()
    {
    }
  }
}
