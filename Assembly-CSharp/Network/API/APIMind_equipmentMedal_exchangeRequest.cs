// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentMedal_exchangeRequest
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
  [Token(Token = "0x2001D63")]
  [Serializable]
  public class APIMind_equipmentMedal_exchangeRequest
  {
    [Token(Token = "0x4007D88")]
    [FieldOffset(Offset = "0x10")]
    public List<PlayerGearMindEquipmentMedalExchangeType> player_mind_equipment_medal_exchanges;

    [Token(Token = "0x600AD62")]
    [Address(RVA = "0x1A499C0", Offset = "0x1A499C0", VA = "0x1A499C0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AD63")]
    [Address(RVA = "0x1A49A08", Offset = "0x1A49A08", VA = "0x1A49A08")]
    public APIMind_equipmentMedal_exchangeRequest()
    {
    }
  }
}
