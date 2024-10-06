// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerMainStorySequenceTransitionLogType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AC7")]
  [Serializable]
  public class PlayerMainStorySequenceTransitionLogType
  {
    [Token(Token = "0x40072C2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int from_sequence_id;
    [Token(Token = "0x40072C3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int to_sequence_id;

    [Token(Token = "0x17001B18")]
    public int FromSequenceId
    {
      [Token(Token = "0x6009B6E"), Address(RVA = "0x48F1B84", Offset = "0x48F1B84", VA = "0x48F1B84")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B6F"), Address(RVA = "0x48F1B8C", Offset = "0x48F1B8C", VA = "0x48F1B8C")] set
      {
      }
    }

    [Token(Token = "0x17001B19")]
    public int ToSequenceId
    {
      [Token(Token = "0x6009B70"), Address(RVA = "0x48F1B94", Offset = "0x48F1B94", VA = "0x48F1B94")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B71"), Address(RVA = "0x48F1B9C", Offset = "0x48F1B9C", VA = "0x48F1B9C")] set
      {
      }
    }

    [Token(Token = "0x6009B72")]
    [Address(RVA = "0x48F1BA4", Offset = "0x48F1BA4", VA = "0x48F1BA4")]
    public PlayerMainStorySequenceTransitionLogType()
    {
    }
  }
}
