// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StageLevelData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001153")]
  [Serializable]
  public sealed class StageLevelData : IMasterDataEntity
  {
    [Token(Token = "0x400540D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400540E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int stageId;
    [Token(Token = "0x400540F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4005410")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int battleId;
    [Token(Token = "0x4005411")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int correctionType;
    [Token(Token = "0x4005412")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int currectionValue;
    [Token(Token = "0x4005413")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int recommendedCombatPower;

    [Token(Token = "0x17000EFC")]
    public int Key
    {
      [Token(Token = "0x600639A"), Address(RVA = "0x4AE97DC", Offset = "0x4AE97DC", VA = "0x4AE97DC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600639B")]
    [Address(RVA = "0x4AE97E4", Offset = "0x4AE97E4", VA = "0x4AE97E4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600639C")]
    [Address(RVA = "0x4AE9AD0", Offset = "0x4AE9AD0", VA = "0x4AE9AD0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600639D")]
    [Address(RVA = "0x4AE9BA4", Offset = "0x4AE9BA4", VA = "0x4AE9BA4")]
    public StageLevelData()
    {
    }
  }
}
