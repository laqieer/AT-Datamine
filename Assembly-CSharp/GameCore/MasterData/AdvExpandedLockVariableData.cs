// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvExpandedLockVariableData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DB1")]
  [Serializable]
  public sealed class AdvExpandedLockVariableData : IMasterDataEntity
  {
    [Token(Token = "0x4004196")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004197")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public AdvVariableTypeEnum variableKind;
    [Token(Token = "0x4004198")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int variableID1;
    [Token(Token = "0x4004199")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int variableID2;
    [Token(Token = "0x400419A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int variableID3;
    [Token(Token = "0x400419B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int coefficientPercentValue;

    [Token(Token = "0x17000BF9")]
    public int Key
    {
      [Token(Token = "0x60053C9"), Address(RVA = "0x3A9D640", Offset = "0x3A9D640", VA = "0x3A9D640", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60053CA")]
    [Address(RVA = "0x3A9D648", Offset = "0x3A9D648", VA = "0x3A9D648", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60053CB")]
    [Address(RVA = "0x3A9D9A4", Offset = "0x3A9D9A4", VA = "0x3A9D9A4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60053CC")]
    [Address(RVA = "0x3A9DA68", Offset = "0x3A9DA68", VA = "0x3A9DA68")]
    public AdvExpandedLockVariableData()
    {
    }
  }
}
