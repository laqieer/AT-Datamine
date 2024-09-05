// Decompiled with JetBrains decompiler
// Type: Network.API.APIFggfcMissionAcceptRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C43")]
  [Serializable]
  public class APIFggfcMissionAcceptRequest
  {
    [Token(Token = "0x4007909")]
    [FieldOffset(Offset = "0x10")]
    public List<int> achievement_mission_ids;
    [Token(Token = "0x400790A")]
    [FieldOffset(Offset = "0x18")]
    public List<int> coin_mission_ids;

    [Token(Token = "0x600A669")]
    [Address(RVA = "0x190AB98", Offset = "0x190AB98", VA = "0x190AB98")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A66A")]
    [Address(RVA = "0x190ABE0", Offset = "0x190ABE0", VA = "0x190ABE0")]
    public APIFggfcMissionAcceptRequest()
    {
    }
  }
}
