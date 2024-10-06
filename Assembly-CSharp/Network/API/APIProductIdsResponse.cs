// Decompiled with JetBrains decompiler
// Type: Network.API.APIProductIdsResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DCC")]
  [Serializable]
  public class APIProductIdsResponse
  {
    [Token(Token = "0x4007F4E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<string> product_ids;

    [Token(Token = "0x1700230D")]
    public List<string> ProductIds
    {
      [Token(Token = "0x600B026"), Address(RVA = "0x1A527D8", Offset = "0x1A527D8", VA = "0x1A527D8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x600B027")]
    [Address(RVA = "0x1A527E0", Offset = "0x1A527E0", VA = "0x1A527E0")]
    public APIProductIdsResponse()
    {
    }
  }
}
