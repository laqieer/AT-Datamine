// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionListRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D73")]
  [Serializable]
  public class APIMissionListRequest
  {
    [Token(Token = "0x4007DD3")]
    [FieldOffset(Offset = "0x10")]
    public List<int> group_ids;

    [Token(Token = "0x600ADD4")]
    [Address(RVA = "0x1A4AFC0", Offset = "0x1A4AFC0", VA = "0x1A4AFC0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600ADD5")]
    [Address(RVA = "0x1A4B008", Offset = "0x1A4B008", VA = "0x1A4B008")]
    public APIMissionListRequest()
    {
    }
  }
}
