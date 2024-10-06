// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvProcessOneData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DC0")]
  [Serializable]
  public sealed class AdvProcessOneData : IMasterDataEntity
  {
    [Token(Token = "0x40041C6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041C7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int ProcessID;
    [Token(Token = "0x40041C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public AdvVariableTypeEnum VariableKind;
    [Token(Token = "0x40041C9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int VariableID;
    [Token(Token = "0x40041CA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public AdvArithmeticTypeEnum ArithmeticType;
    [Token(Token = "0x40041CB")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int Argument;
    [Token(Token = "0x40041CC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string TextID;

    [Token(Token = "0x17000C00")]
    public int Key
    {
      [Token(Token = "0x6005414"), Address(RVA = "0x3AA0DE4", Offset = "0x3AA0DE4", VA = "0x3AA0DE4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005415")]
    [Address(RVA = "0x3AA0DEC", Offset = "0x3AA0DEC", VA = "0x3AA0DEC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005416")]
    [Address(RVA = "0x3AA11A8", Offset = "0x3AA11A8", VA = "0x3AA11A8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005417")]
    [Address(RVA = "0x3AA1280", Offset = "0x3AA1280", VA = "0x3AA1280")]
    public string GetRewardText() => (string) null;

    [Token(Token = "0x6005418")]
    [Address(RVA = "0x3AA14C4", Offset = "0x3AA14C4", VA = "0x3AA14C4")]
    public string GetOperetorText() => (string) null;

    [Token(Token = "0x6005419")]
    [Address(RVA = "0x3AA1588", Offset = "0x3AA1588", VA = "0x3AA1588")]
    public void GetDetailed(ref string textOutput, ref int intOutput, IAdvTextAccess textaccess)
    {
    }

    [Token(Token = "0x600541A")]
    [Address(RVA = "0x3AA1908", Offset = "0x3AA1908", VA = "0x3AA1908")]
    public AdvProcessOneData()
    {
    }
  }
}
