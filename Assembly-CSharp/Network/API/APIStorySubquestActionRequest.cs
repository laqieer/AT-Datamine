// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestActionRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E6F")]
  [Serializable]
  public class APIStorySubquestActionRequest
  {
    [Token(Token = "0x40082B0")]
    [FieldOffset(Offset = "0x10")]
    public int subquest_task_id;

    [Token(Token = "0x600B48B")]
    [Address(RVA = "0x22E6610", Offset = "0x22E6610", VA = "0x22E6610")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B48C")]
    [Address(RVA = "0x22E6658", Offset = "0x22E6658", VA = "0x22E6658")]
    public APIStorySubquestActionRequest()
    {
    }
  }
}
