// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerSignupResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DB0")]
  [Serializable]
  public class APIPlayerSignupResponse
  {
    [Token(Token = "0x4007EE2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool is_created;

    [Token(Token = "0x170022CF")]
    public bool IsCreated
    {
      [Token(Token = "0x600AF78"), Address(RVA = "0x1A50234", Offset = "0x1A50234", VA = "0x1A50234")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600AF79")]
    [Address(RVA = "0x1A5023C", Offset = "0x1A5023C", VA = "0x1A5023C")]
    public APIPlayerSignupResponse()
    {
    }
  }
}
