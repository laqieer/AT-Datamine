// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryAreaEventQuestActionRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E27")]
  [Serializable]
  public class APIStoryAreaEventQuestActionRequest
  {
    [Token(Token = "0x4008124")]
    [FieldOffset(Offset = "0x10")]
    public int area_event_quest_task_id;
    [Token(Token = "0x4008125")]
    [FieldOffset(Offset = "0x18")]
    public AdvRequest adv_request;

    [Token(Token = "0x600B285")]
    [Address(RVA = "0x22E02E8", Offset = "0x22E02E8", VA = "0x22E02E8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B286")]
    [Address(RVA = "0x22E0330", Offset = "0x22E0330", VA = "0x22E0330")]
    public APIStoryAreaEventQuestActionRequest()
    {
    }
  }
}
