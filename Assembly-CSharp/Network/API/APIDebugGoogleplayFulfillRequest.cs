// Decompiled with JetBrains decompiler
// Type: Network.API.APIDebugGoogleplayFulfillRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BEF")]
  [Serializable]
  public class APIDebugGoogleplayFulfillRequest
  {
    [Token(Token = "0x40077A0")]
    [FieldOffset(Offset = "0x10")]
    public List<DebugFulfillOrders> orders;

    [Token(Token = "0x600A43A")]
    [Address(RVA = "0x46D1940", Offset = "0x46D1940", VA = "0x46D1940")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A43B")]
    [Address(RVA = "0x46D1988", Offset = "0x46D1988", VA = "0x46D1988")]
    public APIDebugGoogleplayFulfillRequest()
    {
    }
  }
}
