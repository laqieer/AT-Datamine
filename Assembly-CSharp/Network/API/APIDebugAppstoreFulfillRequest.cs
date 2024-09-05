// Decompiled with JetBrains decompiler
// Type: Network.API.APIDebugAppstoreFulfillRequest
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
  [Token(Token = "0x2001BEB")]
  [Serializable]
  public class APIDebugAppstoreFulfillRequest
  {
    [Token(Token = "0x400778F")]
    [FieldOffset(Offset = "0x10")]
    public List<DebugFulfillOrders> orders;

    [Token(Token = "0x600A41F")]
    [Address(RVA = "0x46D13CC", Offset = "0x46D13CC", VA = "0x46D13CC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A420")]
    [Address(RVA = "0x46D1414", Offset = "0x46D1414", VA = "0x46D1414")]
    public APIDebugAppstoreFulfillRequest()
    {
    }
  }
}
