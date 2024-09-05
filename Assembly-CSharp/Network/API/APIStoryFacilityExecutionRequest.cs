// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFacilityExecutionRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E2F")]
  [Serializable]
  public class APIStoryFacilityExecutionRequest
  {
    [Token(Token = "0x400814B")]
    [FieldOffset(Offset = "0x10")]
    public int facility_id;
    [Token(Token = "0x400814C")]
    [FieldOffset(Offset = "0x14")]
    public int used_item_id;
    [Token(Token = "0x400814D")]
    [FieldOffset(Offset = "0x18")]
    public int selected_menu_id;
    [Token(Token = "0x400814E")]
    [FieldOffset(Offset = "0x1C")]
    public int rent_item_id;
    [Token(Token = "0x400814F")]
    [FieldOffset(Offset = "0x20")]
    public int selected_communication_id;
    [Token(Token = "0x4008150")]
    [FieldOffset(Offset = "0x24")]
    public int selected_work_id;
    [Token(Token = "0x4008151")]
    [FieldOffset(Offset = "0x28")]
    public AdvRequest adv_request;

    [Token(Token = "0x600B2BE")]
    [Address(RVA = "0x22E0DE8", Offset = "0x22E0DE8", VA = "0x22E0DE8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B2BF")]
    [Address(RVA = "0x22E0E30", Offset = "0x22E0E30", VA = "0x22E0E30")]
    public APIStoryFacilityExecutionRequest()
    {
    }
  }
}
