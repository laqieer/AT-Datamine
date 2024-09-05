// Decompiled with JetBrains decompiler
// Type: Network.API.APIChargeLimitResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BC4")]
  [Serializable]
  public class APIChargeLimitResponse
  {
    [Token(Token = "0x40076FE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<ChargeLimitType> limits;

    [Token(Token = "0x17001E39")]
    public List<ChargeLimitType> Limits
    {
      [Token(Token = "0x600A332"), Address(RVA = "0x46CDE8C", Offset = "0x46CDE8C", VA = "0x46CDE8C")] get
      {
        return (List<ChargeLimitType>) null;
      }
    }

    [Token(Token = "0x600A333")]
    [Address(RVA = "0x46CDE94", Offset = "0x46CDE94", VA = "0x46CDE94")]
    public APIChargeLimitResponse()
    {
    }
  }
}
