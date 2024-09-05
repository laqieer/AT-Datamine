// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvVariablesData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DC2")]
  [Serializable]
  public sealed class AdvVariablesData : IMasterDataEntity
  {
    [Token(Token = "0x40041CD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041CE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x40041CF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public AdvVariableTypeEnum VariableKind;
    [Token(Token = "0x40041D0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int VariableID;

    [Token(Token = "0x17000C01")]
    public int Key
    {
      [Token(Token = "0x6005421"), Address(RVA = "0x3AA1DCC", Offset = "0x3AA1DCC", VA = "0x3AA1DCC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005422")]
    [Address(RVA = "0x3AA1DD4", Offset = "0x3AA1DD4", VA = "0x3AA1DD4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005423")]
    [Address(RVA = "0x3AA2070", Offset = "0x3AA2070", VA = "0x3AA2070", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005424")]
    [Address(RVA = "0x3AA2118", Offset = "0x3AA2118", VA = "0x3AA2118")]
    public AdvVariablesData()
    {
    }
  }
}
