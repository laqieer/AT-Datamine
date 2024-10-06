// Decompiled with JetBrains decompiler
// Type: Network.API.APIMedal_trade_shopCountResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D50")]
  [Serializable]
  public class APIMedal_trade_shopCountResponse
  {
    [Token(Token = "0x4007D39")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerMedalTradeCountType> player_medal_trade_info;

    [Token(Token = "0x170021BD")]
    public List<PlayerMedalTradeCountType> PlayerMedalTradeInfo
    {
      [Token(Token = "0x600ACE6"), Address(RVA = "0x1A47F14", Offset = "0x1A47F14", VA = "0x1A47F14")] get
      {
        return (List<PlayerMedalTradeCountType>) null;
      }
    }

    [Token(Token = "0x600ACE7")]
    [Address(RVA = "0x1A47F1C", Offset = "0x1A47F1C", VA = "0x1A47F1C")]
    public APIMedal_trade_shopCountResponse()
    {
    }
  }
}
