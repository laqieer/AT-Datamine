// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerStatusResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DB4")]
  [Serializable]
  public class APIPlayerStatusResponse
  {
    [Token(Token = "0x4007EEE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool is_started;

    [Token(Token = "0x170022D6")]
    public bool IsStarted
    {
      [Token(Token = "0x600AF8F"), Address(RVA = "0x1A50780", Offset = "0x1A50780", VA = "0x1A50780")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600AF90")]
    [Address(RVA = "0x1A50788", Offset = "0x1A50788", VA = "0x1A50788")]
    public APIPlayerStatusResponse()
    {
    }
  }
}
