// Decompiled with JetBrains decompiler
// Type: Network.API.APIBoxItemOpenRequest
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
  [Token(Token = "0x2001BBB")]
  [Serializable]
  public class APIBoxItemOpenRequest
  {
    [Token(Token = "0x40076DC")]
    [FieldOffset(Offset = "0x10")]
    public int item_id;
    [Token(Token = "0x40076DD")]
    [FieldOffset(Offset = "0x14")]
    public int count;
    [Token(Token = "0x40076DE")]
    [FieldOffset(Offset = "0x18")]
    public List<BoxItemContentSelectType> select_contents;

    [Token(Token = "0x600A2FD")]
    [Address(RVA = "0x46CD36C", Offset = "0x46CD36C", VA = "0x46CD36C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A2FE")]
    [Address(RVA = "0x46CD3B4", Offset = "0x46CD3B4", VA = "0x46CD3B4")]
    public APIBoxItemOpenRequest()
    {
    }
  }
}
