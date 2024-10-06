// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleResumeResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BA8")]
  [Serializable]
  public class APIBattleResumeResponse
  {
    [Token(Token = "0x400769A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x400769B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int rollback_index;

    [Token(Token = "0x17001E02")]
    public int RollbackCount
    {
      [Token(Token = "0x600A28B"), Address(RVA = "0x46CB910", Offset = "0x46CB910", VA = "0x46CB910")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E03")]
    public int RollbackIndex
    {
      [Token(Token = "0x600A28C"), Address(RVA = "0x46CB918", Offset = "0x46CB918", VA = "0x46CB918")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A28D")]
    [Address(RVA = "0x46CB920", Offset = "0x46CB920", VA = "0x46CB920")]
    public APIBattleResumeResponse()
    {
    }
  }
}
