// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MoveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200137D")]
  [Serializable]
  public sealed class MoveData : IMasterDataEntity
  {
    [Token(Token = "0x4005B42")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B43")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005B44")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public MoveTypeEnum type;
    [Token(Token = "0x4005B45")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int mobility;
    [Token(Token = "0x4005B46")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public bool isAir;

    [Token(Token = "0x17001083")]
    public int Key
    {
      [Token(Token = "0x6006DA6"), Address(RVA = "0x46FEA3C", Offset = "0x46FEA3C", VA = "0x46FEA3C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006DA7")]
    [Address(RVA = "0x46FEA44", Offset = "0x46FEA44", VA = "0x46FEA44", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006DA8")]
    [Address(RVA = "0x46FEC74", Offset = "0x46FEC74", VA = "0x46FEC74", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001084")]
    public bool IgnoreLandformParamOffsets
    {
      [Token(Token = "0x6006DA9"), Address(RVA = "0x46FED2C", Offset = "0x46FED2C", VA = "0x46FED2C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001085")]
    public bool IgnoreLandformDamage
    {
      [Token(Token = "0x6006DAA"), Address(RVA = "0x46FED34", Offset = "0x46FED34", VA = "0x46FED34")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001086")]
    public bool IgnoreLandformHealing
    {
      [Token(Token = "0x6006DAB"), Address(RVA = "0x46FED3C", Offset = "0x46FED3C", VA = "0x46FED3C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006DAC")]
    [Address(RVA = "0x46FED44", Offset = "0x46FED44", VA = "0x46FED44")]
    public MoveData()
    {
    }
  }
}
