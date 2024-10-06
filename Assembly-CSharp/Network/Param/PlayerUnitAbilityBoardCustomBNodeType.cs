// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitAbilityBoardCustomBNodeType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AF0")]
  [Serializable]
  public class PlayerUnitAbilityBoardCustomBNodeType
  {
    [Token(Token = "0x400739B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int node_id;
    [Token(Token = "0x400739C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int parameter_id;
    [Token(Token = "0x400739D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int parameter_value;
    [Token(Token = "0x400739E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int lottery_count;

    [Token(Token = "0x17001BFD")]
    public int NodeId
    {
      [Token(Token = "0x6009D55"), Address(RVA = "0x48F2B58", Offset = "0x48F2B58", VA = "0x48F2B58")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D56"), Address(RVA = "0x48F2B60", Offset = "0x48F2B60", VA = "0x48F2B60")] set
      {
      }
    }

    [Token(Token = "0x17001BFE")]
    public int ParameterId
    {
      [Token(Token = "0x6009D57"), Address(RVA = "0x48F2B68", Offset = "0x48F2B68", VA = "0x48F2B68")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D58"), Address(RVA = "0x48F2B70", Offset = "0x48F2B70", VA = "0x48F2B70")] set
      {
      }
    }

    [Token(Token = "0x17001BFF")]
    public int ParameterValue
    {
      [Token(Token = "0x6009D59"), Address(RVA = "0x48F2B78", Offset = "0x48F2B78", VA = "0x48F2B78")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D5A"), Address(RVA = "0x48F2B80", Offset = "0x48F2B80", VA = "0x48F2B80")] set
      {
      }
    }

    [Token(Token = "0x17001C00")]
    public int LotteryCount
    {
      [Token(Token = "0x6009D5B"), Address(RVA = "0x48F2B88", Offset = "0x48F2B88", VA = "0x48F2B88")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D5C"), Address(RVA = "0x48F2B90", Offset = "0x48F2B90", VA = "0x48F2B90")] set
      {
      }
    }

    [Token(Token = "0x6009D5D")]
    [Address(RVA = "0x48F2B98", Offset = "0x48F2B98", VA = "0x48F2B98")]
    public PlayerUnitAbilityBoardCustomBNodeType()
    {
    }
  }
}
