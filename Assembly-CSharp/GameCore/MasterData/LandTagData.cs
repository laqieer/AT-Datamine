// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LandTagData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E49")]
  [Serializable]
  public sealed class LandTagData : IMasterDataEntity
  {
    [Token(Token = "0x40044E7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40044E8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000C9F")]
    public int Key
    {
      [Token(Token = "0x60056E7"), Address(RVA = "0x3E3A62C", Offset = "0x3E3A62C", VA = "0x3E3A62C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60056E8")]
    [Address(RVA = "0x3E3A634", Offset = "0x3E3A634", VA = "0x3E3A634", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60056E9")]
    [Address(RVA = "0x3E3A740", Offset = "0x3E3A740", VA = "0x3E3A740", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60056EA")]
    [Address(RVA = "0x3E3A7C8", Offset = "0x3E3A7C8", VA = "0x3E3A7C8")]
    public LandTagData()
    {
    }
  }
}
