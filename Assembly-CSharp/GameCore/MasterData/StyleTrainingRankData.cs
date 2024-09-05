// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleTrainingRankData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013C4")]
  [Serializable]
  public sealed class StyleTrainingRankData : IMasterDataEntity
  {
    [Token(Token = "0x4005C65")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005C66")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public TrainingRankTypeEnum rankType;
    [Token(Token = "0x4005C67")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rankThreshold;

    [Token(Token = "0x170010B7")]
    public int Key
    {
      [Token(Token = "0x6006F16"), Address(RVA = "0x4710AC4", Offset = "0x4710AC4", VA = "0x4710AC4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006F17")]
    [Address(RVA = "0x4710ACC", Offset = "0x4710ACC", VA = "0x4710ACC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006F18")]
    [Address(RVA = "0x4710C38", Offset = "0x4710C38", VA = "0x4710C38", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006F19")]
    [Address(RVA = "0x4710CCC", Offset = "0x4710CCC", VA = "0x4710CCC")]
    public StyleTrainingRankData()
    {
    }
  }
}
