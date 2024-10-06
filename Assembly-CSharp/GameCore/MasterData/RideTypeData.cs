// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RideTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F11")]
  [Serializable]
  public sealed class RideTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004B10")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004B11")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004B12")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D4B")]
    public int Key
    {
      [Token(Token = "0x600597E"), Address(RVA = "0x3C3268C", Offset = "0x3C3268C", VA = "0x3C3268C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600597F")]
    [Address(RVA = "0x3C32694", Offset = "0x3C32694", VA = "0x3C32694", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005980")]
    [Address(RVA = "0x3C32800", Offset = "0x3C32800", VA = "0x3C32800", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005981")]
    [Address(RVA = "0x3C3289C", Offset = "0x3C3289C", VA = "0x3C3289C")]
    public RideTypeData()
    {
    }
  }
}
