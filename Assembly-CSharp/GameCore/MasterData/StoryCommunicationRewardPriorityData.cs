// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRewardPriorityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200120B")]
  [Serializable]
  public sealed class StoryCommunicationRewardPriorityData : IMasterDataEntity
  {
    [Token(Token = "0x4005658")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005659")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardTypeID;
    [Token(Token = "0x400565A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int priority;

    [Token(Token = "0x17000F82")]
    public int Key
    {
      [Token(Token = "0x60066E7"), Address(RVA = "0x4D29E3C", Offset = "0x4D29E3C", VA = "0x4D29E3C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60066E8")]
    [Address(RVA = "0x4D29E44", Offset = "0x4D29E44", VA = "0x4D29E44", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60066E9")]
    [Address(RVA = "0x4D29FB0", Offset = "0x4D29FB0", VA = "0x4D29FB0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60066EA")]
    [Address(RVA = "0x4D2A044", Offset = "0x4D2A044", VA = "0x4D2A044")]
    public StoryCommunicationRewardPriorityData()
    {
    }
  }
}
