// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001Set_targetRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C8F")]
  [Serializable]
  public class APIG0001Set_targetRequest
  {
    [Token(Token = "0x4007A2B")]
    [FieldOffset(Offset = "0x10")]
    public int target_id;
    [Token(Token = "0x4007A2C")]
    [FieldOffset(Offset = "0x14")]
    public int target_option_id;

    [Token(Token = "0x600A839")]
    [Address(RVA = "0x19111AC", Offset = "0x19111AC", VA = "0x19111AC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A83A")]
    [Address(RVA = "0x19111F4", Offset = "0x19111F4", VA = "0x19111F4")]
    public APIG0001Set_targetRequest()
    {
    }
  }
}
