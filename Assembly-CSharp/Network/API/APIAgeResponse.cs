// Decompiled with JetBrains decompiler
// Type: Network.API.APIAgeResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B64")]
  [Serializable]
  public class APIAgeResponse
  {
    [Token(Token = "0x4007566")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int age;

    [Token(Token = "0x17001D5A")]
    public int Age
    {
      [Token(Token = "0x600A0D3"), Address(RVA = "0x46C5CF4", Offset = "0x46C5CF4", VA = "0x46C5CF4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A0D4")]
    [Address(RVA = "0x46C5CFC", Offset = "0x46C5CFC", VA = "0x46C5CFC")]
    public APIAgeResponse()
    {
    }
  }
}
