// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SexTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F15")]
  [Serializable]
  public sealed class SexTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004B1C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004B1D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004B1E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D4C")]
    public int Key
    {
      [Token(Token = "0x6005986"), Address(RVA = "0x3C329AC", Offset = "0x3C329AC", VA = "0x3C329AC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005987")]
    [Address(RVA = "0x3C329B4", Offset = "0x3C329B4", VA = "0x3C329B4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005988")]
    [Address(RVA = "0x3C32B20", Offset = "0x3C32B20", VA = "0x3C32B20", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005989")]
    [Address(RVA = "0x3C32BBC", Offset = "0x3C32BBC", VA = "0x3C32BBC")]
    public SexTypeData()
    {
    }
  }
}
