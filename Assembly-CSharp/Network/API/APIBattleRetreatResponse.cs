// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleRetreatResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BAC")]
  [Serializable]
  public class APIBattleRetreatResponse
  {
    [Token(Token = "0x40076A9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int rollback_count;

    [Token(Token = "0x17001E0A")]
    public int RollbackCount
    {
      [Token(Token = "0x600A2A3"), Address(RVA = "0x46CBE6C", Offset = "0x46CBE6C", VA = "0x46CBE6C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A2A4")]
    [Address(RVA = "0x46CBE74", Offset = "0x46CBE74", VA = "0x46CBE74")]
    public APIBattleRetreatResponse()
    {
    }
  }
}
