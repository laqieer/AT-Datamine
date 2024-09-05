// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvVariableTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DC5")]
  [Serializable]
  public sealed class AdvVariableTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40041DE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x40041E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public AdvVariableTypeEnum AdvVariableType;

    [Token(Token = "0x17000C02")]
    public int Key
    {
      [Token(Token = "0x600542A"), Address(RVA = "0x3AA23C8", Offset = "0x3AA23C8", VA = "0x3AA23C8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600542B")]
    [Address(RVA = "0x3AA23D0", Offset = "0x3AA23D0", VA = "0x3AA23D0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600542C")]
    [Address(RVA = "0x3AA260C", Offset = "0x3AA260C", VA = "0x3AA260C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600542D")]
    [Address(RVA = "0x3AA26A4", Offset = "0x3AA26A4", VA = "0x3AA26A4")]
    public AdvVariableTypeData()
    {
    }
  }
}
