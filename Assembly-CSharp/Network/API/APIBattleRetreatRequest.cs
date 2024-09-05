// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleRetreatRequest
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
  [Token(Token = "0x2001BAB")]
  [Serializable]
  public class APIBattleRetreatRequest
  {
    [Token(Token = "0x40076A7")]
    [FieldOffset(Offset = "0x10")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x40076A8")]
    [FieldOffset(Offset = "0x18")]
    public List<int> remain_hps;

    [Token(Token = "0x600A2A1")]
    [Address(RVA = "0x46CBE1C", Offset = "0x46CBE1C", VA = "0x46CBE1C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A2A2")]
    [Address(RVA = "0x46CBE64", Offset = "0x46CBE64", VA = "0x46CBE64")]
    public APIBattleRetreatRequest()
    {
    }
  }
}
