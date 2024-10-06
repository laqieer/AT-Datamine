// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardCustomPatternData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001348")]
  [Serializable]
  public sealed class AbilityBoardCustomPatternData : IMasterDataEntity
  {
    [Token(Token = "0x4005AC9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005ACA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005ACB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public ParameterTypeEnum mainParameterType;
    [Token(Token = "0x4005ACC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public ParameterTypeEnum subParameterType;

    [Token(Token = "0x17001067")]
    public int Key
    {
      [Token(Token = "0x6006CB7"), Address(RVA = "0x46F6590", Offset = "0x46F6590", VA = "0x46F6590", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CB8")]
    [Address(RVA = "0x46F6598", Offset = "0x46F6598", VA = "0x46F6598", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CB9")]
    [Address(RVA = "0x46F6764", Offset = "0x46F6764", VA = "0x46F6764", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006CBA")]
    [Address(RVA = "0x46F680C", Offset = "0x46F680C", VA = "0x46F680C")]
    public AbilityBoardCustomPatternData()
    {
    }
  }
}
