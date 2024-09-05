// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitAbilityBoardParameterType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AF1")]
  [Serializable]
  public class PlayerUnitAbilityBoardParameterType
  {
    [Token(Token = "0x400739F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int parameter_id;
    [Token(Token = "0x40073A0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int parameter_value;

    [Token(Token = "0x17001C01")]
    public int ParameterId
    {
      [Token(Token = "0x6009D5E"), Address(RVA = "0x48F2BA0", Offset = "0x48F2BA0", VA = "0x48F2BA0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D5F"), Address(RVA = "0x48F2BA8", Offset = "0x48F2BA8", VA = "0x48F2BA8")] set
      {
      }
    }

    [Token(Token = "0x17001C02")]
    public int ParameterValue
    {
      [Token(Token = "0x6009D60"), Address(RVA = "0x48F2BB0", Offset = "0x48F2BB0", VA = "0x48F2BB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D61"), Address(RVA = "0x48F2BB8", Offset = "0x48F2BB8", VA = "0x48F2BB8")] set
      {
      }
    }

    [Token(Token = "0x6009D62")]
    [Address(RVA = "0x48F2BC0", Offset = "0x48F2BC0", VA = "0x48F2BC0")]
    public PlayerUnitAbilityBoardParameterType()
    {
    }
  }
}
