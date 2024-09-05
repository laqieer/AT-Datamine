// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.InscriptionDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F55")]
  [Serializable]
  public sealed class InscriptionDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004D09")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D0A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int inscription;
    [Token(Token = "0x4004D0B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ParameterTypeEnum correction;
    [Token(Token = "0x4004D0C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int value;

    [Token(Token = "0x17000D64")]
    public int Key
    {
      [Token(Token = "0x6005A41"), Address(RVA = "0x3C3C7D8", Offset = "0x3C3C7D8", VA = "0x3C3C7D8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A42")]
    [Address(RVA = "0x3C3C7E0", Offset = "0x3C3C7E0", VA = "0x3C3C7E0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A43")]
    [Address(RVA = "0x3C3C9AC", Offset = "0x3C3C9AC", VA = "0x3C3C9AC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A44")]
    [Address(RVA = "0x3C3CA50", Offset = "0x3C3CA50", VA = "0x3C3CA50")]
    public InscriptionDescriptionData()
    {
    }
  }
}
