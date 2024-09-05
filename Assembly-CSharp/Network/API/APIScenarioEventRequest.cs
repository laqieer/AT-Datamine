// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DCF")]
  [Serializable]
  public class APIScenarioEventRequest
  {
    [Token(Token = "0x4007F5A")]
    [FieldOffset(Offset = "0x10")]
    public int scenario_quest_id;

    [Token(Token = "0x600B03B")]
    [Address(RVA = "0x1A52CDC", Offset = "0x1A52CDC", VA = "0x1A52CDC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B03C")]
    [Address(RVA = "0x1A52D24", Offset = "0x1A52D24", VA = "0x1A52D24")]
    public APIScenarioEventRequest()
    {
    }
  }
}
