// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaNodeClearRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B67")]
  [Serializable]
  public class APIAreaNodeClearRequest
  {
    [Token(Token = "0x4007572")]
    [FieldOffset(Offset = "0x10")]
    public int area_node_id;

    [Token(Token = "0x600A0E8")]
    [Address(RVA = "0x46C61F8", Offset = "0x46C61F8", VA = "0x46C61F8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A0E9")]
    [Address(RVA = "0x46C6240", Offset = "0x46C6240", VA = "0x46C6240")]
    public APIAreaNodeClearRequest()
    {
    }
  }
}
