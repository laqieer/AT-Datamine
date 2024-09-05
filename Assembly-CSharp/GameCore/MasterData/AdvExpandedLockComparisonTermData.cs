// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvExpandedLockComparisonTermData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DAD")]
  [Serializable]
  public sealed class AdvExpandedLockComparisonTermData : IMasterDataEntity
  {
    [Token(Token = "0x400418C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400418D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int expandedlockGroupId;
    [Token(Token = "0x400418E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int expandedlockVariableId;
    [Token(Token = "0x400418F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public AdvComparisonTypeEnum comparisonType;
    [Token(Token = "0x4004190")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int compExpandedlockVariableId;
    [Token(Token = "0x4004191")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string expandedlockTextID;

    [Token(Token = "0x17000BF7")]
    public int Key
    {
      [Token(Token = "0x60053B9"), Address(RVA = "0x3A9CE44", Offset = "0x3A9CE44", VA = "0x3A9CE44", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60053BA")]
    [Address(RVA = "0x3A9CE4C", Offset = "0x3A9CE4C", VA = "0x3A9CE4C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60053BB")]
    [Address(RVA = "0x3A9D0D8", Offset = "0x3A9D0D8", VA = "0x3A9D0D8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60053BC")]
    [Address(RVA = "0x3A9D1A0", Offset = "0x3A9D1A0", VA = "0x3A9D1A0")]
    public AdvExpandedLockComparisonTermData()
    {
    }
  }
}
