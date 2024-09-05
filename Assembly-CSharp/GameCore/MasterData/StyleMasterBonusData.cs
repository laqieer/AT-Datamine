// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleMasterBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010D1")]
  [Serializable]
  public sealed class StyleMasterBonusData : IMasterDataEntity
  {
    [Token(Token = "0x400527C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400527D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400527E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int target;
    [Token(Token = "0x400527F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int category;
    [Token(Token = "0x4005280")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int exp;

    [Token(Token = "0x17000E7C")]
    public int Key
    {
      [Token(Token = "0x6006130"), Address(RVA = "0x28DEA18", Offset = "0x28DEA18", VA = "0x28DEA18", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006131")]
    [Address(RVA = "0x28DEA20", Offset = "0x28DEA20", VA = "0x28DEA20", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006132")]
    [Address(RVA = "0x28DEC4C", Offset = "0x28DEC4C", VA = "0x28DEC4C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006133")]
    [Address(RVA = "0x28DED04", Offset = "0x28DED04", VA = "0x28DED04")]
    public StyleMasterBonusData()
    {
    }
  }
}
