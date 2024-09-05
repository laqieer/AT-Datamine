// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleTrainingRankConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013C1")]
  [Serializable]
  public sealed class StyleTrainingRankConstData : IMasterDataEntity
  {
    [Token(Token = "0x4005C60")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005C61")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int coefficientA;
    [Token(Token = "0x4005C62")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int coefficientB;
    [Token(Token = "0x4005C63")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int coefficientC;

    [Token(Token = "0x170010B6")]
    public int Key
    {
      [Token(Token = "0x6006F08"), Address(RVA = "0x4710394", Offset = "0x4710394", VA = "0x4710394", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006F09")]
    [Address(RVA = "0x471039C", Offset = "0x471039C", VA = "0x471039C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006F0A")]
    [Address(RVA = "0x4710568", Offset = "0x4710568", VA = "0x4710568", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006F0B")]
    [Address(RVA = "0x471060C", Offset = "0x471060C", VA = "0x471060C")]
    public StyleTrainingRankConstData()
    {
    }
  }
}
