// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LevelUpParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001390")]
  [Serializable]
  public sealed class LevelUpParameterData : IMasterDataEntity
  {
    [Token(Token = "0x4005B63")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B64")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public float baseExpCorrection;
    [Token(Token = "0x4005B65")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public float backExpCorrection;
    [Token(Token = "0x4005B66")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public float gainExpCorrection;
    [Token(Token = "0x4005B67")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float gainExpCountAdjust;
    [Token(Token = "0x4005B68")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int maxLevelDiffCorrection;
    [Token(Token = "0x4005B69")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int levelDiffCorrectionDivisor;

    [Token(Token = "0x1700108E")]
    public int Key
    {
      [Token(Token = "0x6006DFC"), Address(RVA = "0x4701224", Offset = "0x4701224", VA = "0x4701224", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006DFD")]
    [Address(RVA = "0x470122C", Offset = "0x470122C", VA = "0x470122C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006DFE")]
    [Address(RVA = "0x4701518", Offset = "0x4701518", VA = "0x4701518", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006DFF")]
    [Address(RVA = "0x47015EC", Offset = "0x47015EC", VA = "0x47015EC")]
    public LevelUpParameterData()
    {
    }
  }
}
