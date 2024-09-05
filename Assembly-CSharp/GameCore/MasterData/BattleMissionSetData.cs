// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleMissionSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E56")]
  [Serializable]
  public sealed class BattleMissionSetData : IMasterDataEntity
  {
    [Token(Token = "0x4004517")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004518")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004519")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardGroupId;
    [Token(Token = "0x400451A")]
    public const int ID_EMPTY_MISSIONS = 1000000;

    [Token(Token = "0x17000CCB")]
    public int Key
    {
      [Token(Token = "0x6005750"), Address(RVA = "0x3E3D0DC", Offset = "0x3E3D0DC", VA = "0x3E3D0DC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005751")]
    [Address(RVA = "0x3E3D0E4", Offset = "0x3E3D0E4", VA = "0x3E3D0E4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005752")]
    [Address(RVA = "0x3E3D250", Offset = "0x3E3D250", VA = "0x3E3D250", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005753")]
    [Address(RVA = "0x3E3D2E8", Offset = "0x3E3D2E8", VA = "0x3E3D2E8")]
    public static bool IsInvalidID(int id) => new bool();

    [Token(Token = "0x6005754")]
    [Address(RVA = "0x3E3D310", Offset = "0x3E3D310", VA = "0x3E3D310")]
    public BattleMissionSetData()
    {
    }
  }
}
