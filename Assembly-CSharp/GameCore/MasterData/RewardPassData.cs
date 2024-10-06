// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RewardPassData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010C7")]
  [Serializable]
  public sealed class RewardPassData : IMasterDataEntity
  {
    [Token(Token = "0x400525A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400525B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400525C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int loginbonusID;
    [Token(Token = "0x400525D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int effectiveDays;
    [Token(Token = "0x400525E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int repeatPurchasableDays;

    [Token(Token = "0x17000E78")]
    public int Key
    {
      [Token(Token = "0x60060FF"), Address(RVA = "0x28DC098", Offset = "0x28DC098", VA = "0x28DC098", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006100")]
    [Address(RVA = "0x28DC0A0", Offset = "0x28DC0A0", VA = "0x28DC0A0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006101")]
    [Address(RVA = "0x28DC2CC", Offset = "0x28DC2CC", VA = "0x28DC2CC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006102")]
    [Address(RVA = "0x28DC384", Offset = "0x28DC384", VA = "0x28DC384")]
    public RewardPassData()
    {
    }
  }
}
