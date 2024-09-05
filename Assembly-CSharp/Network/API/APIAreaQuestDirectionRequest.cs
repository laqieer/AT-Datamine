// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestDirectionRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B7B")]
  [Serializable]
  public class APIAreaQuestDirectionRequest
  {
    [Token(Token = "0x40075DC")]
    [FieldOffset(Offset = "0x10")]
    public int area_group_id;
    [Token(Token = "0x40075DD")]
    [FieldOffset(Offset = "0x18")]
    public List<int> directed_area_ids;
    [Token(Token = "0x40075DE")]
    [FieldOffset(Offset = "0x20")]
    public List<int> directed_area_node_ids;

    [Token(Token = "0x600A16E")]
    [Address(RVA = "0x46C7D34", Offset = "0x46C7D34", VA = "0x46C7D34")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A16F")]
    [Address(RVA = "0x46C7D7C", Offset = "0x46C7D7C", VA = "0x46C7D7C")]
    public APIAreaQuestDirectionRequest()
    {
    }
  }
}
