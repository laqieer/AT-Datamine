// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B1")]
  [Serializable]
  public sealed class TotalMissionEventData : IMasterDataEntity
  {
    [Token(Token = "0x4005222")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005223")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005224")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x4005225")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x4005226")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int updateTime;
    [Token(Token = "0x4005227")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int aggregateTime;
    [Token(Token = "0x4005228")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string bgmPackName;
    [Token(Token = "0x4005229")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string bgmEventName;

    [Token(Token = "0x17000E62")]
    public int Key
    {
      [Token(Token = "0x600608F"), Address(RVA = "0x28D87C8", Offset = "0x28D87C8", VA = "0x28D87C8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006090")]
    [Address(RVA = "0x28D87D0", Offset = "0x28D87D0", VA = "0x28D87D0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006091")]
    [Address(RVA = "0x28D8B1C", Offset = "0x28D8B1C", VA = "0x28D8B1C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006092")]
    [Address(RVA = "0x28D8C64", Offset = "0x28D8C64", VA = "0x28D8C64")]
    public TotalMissionEventData()
    {
    }
  }
}
