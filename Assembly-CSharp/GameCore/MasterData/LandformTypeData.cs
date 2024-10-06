// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LandformTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EF6")]
  [Serializable]
  public sealed class LandformTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004A39")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004A3A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D48")]
    public int Key
    {
      [Token(Token = "0x6005966"), Address(RVA = "0x3C31E14", Offset = "0x3C31E14", VA = "0x3C31E14", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005967")]
    [Address(RVA = "0x3C31E1C", Offset = "0x3C31E1C", VA = "0x3C31E1C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005968")]
    [Address(RVA = "0x3C31F28", Offset = "0x3C31F28", VA = "0x3C31F28", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005969")]
    [Address(RVA = "0x3C31FB0", Offset = "0x3C31FB0", VA = "0x3C31FB0")]
    public LandformTypeData()
    {
    }
  }
}
