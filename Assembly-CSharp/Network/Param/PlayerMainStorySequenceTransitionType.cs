// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerMainStorySequenceTransitionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AC8")]
  [Serializable]
  public class PlayerMainStorySequenceTransitionType
  {
    [Token(Token = "0x40072C4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int from_sequence_id;
    [Token(Token = "0x40072C5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int to_sequence_id;

    [Token(Token = "0x17001B1A")]
    public int FromSequenceId
    {
      [Token(Token = "0x6009B73"), Address(RVA = "0x48F1BAC", Offset = "0x48F1BAC", VA = "0x48F1BAC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B74"), Address(RVA = "0x48F1BB4", Offset = "0x48F1BB4", VA = "0x48F1BB4")] set
      {
      }
    }

    [Token(Token = "0x17001B1B")]
    public int ToSequenceId
    {
      [Token(Token = "0x6009B75"), Address(RVA = "0x48F1BBC", Offset = "0x48F1BBC", VA = "0x48F1BBC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B76"), Address(RVA = "0x48F1BC4", Offset = "0x48F1BC4", VA = "0x48F1BC4")] set
      {
      }
    }

    [Token(Token = "0x6009B77")]
    [Address(RVA = "0x48F1BCC", Offset = "0x48F1BCC", VA = "0x48F1BCC")]
    public PlayerMainStorySequenceTransitionType()
    {
    }
  }
}
