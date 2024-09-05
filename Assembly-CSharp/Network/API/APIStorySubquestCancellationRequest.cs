// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestCancellationRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E7B")]
  [Serializable]
  public class APIStorySubquestCancellationRequest
  {
    [Token(Token = "0x4008302")]
    [FieldOffset(Offset = "0x10")]
    public int subquest_id;

    [Token(Token = "0x600B4E7")]
    [Address(RVA = "0x22E76C4", Offset = "0x22E76C4", VA = "0x22E76C4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B4E8")]
    [Address(RVA = "0x22E770C", Offset = "0x22E770C", VA = "0x22E770C")]
    public APIStorySubquestCancellationRequest()
    {
    }
  }
}
