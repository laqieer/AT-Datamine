// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001361")]
  [Serializable]
  public sealed class CharacterConstData : IMasterDataEntity
  {
    [Token(Token = "0x4005B04")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B05")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int maxLp;
    [Token(Token = "0x4005B06")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int lostComebackTime;
    [Token(Token = "0x4005B07")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int shorteningLostComebackTimeByCoin;

    [Token(Token = "0x17001073")]
    public int Key
    {
      [Token(Token = "0x6006D2A"), Address(RVA = "0x46FA5AC", Offset = "0x46FA5AC", VA = "0x46FA5AC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D2B")]
    [Address(RVA = "0x46FA5B4", Offset = "0x46FA5B4", VA = "0x46FA5B4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D2C")]
    [Address(RVA = "0x46FA780", Offset = "0x46FA780", VA = "0x46FA780", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D2D")]
    [Address(RVA = "0x46FA824", Offset = "0x46FA824", VA = "0x46FA824")]
    public CharacterConstData()
    {
    }
  }
}
