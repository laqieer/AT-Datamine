// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitReincarnationMemorizeResponse
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
  [Token(Token = "0x2001EC8")]
  [Serializable]
  public class APIUnitReincarnationMemorizeResponse
  {
    [Token(Token = "0x4008434")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerUnitReincarnationMemoryType> player_unit_reincarnation_memories;

    [Token(Token = "0x170025C3")]
    public List<PlayerUnitReincarnationMemoryType> PlayerUnitReincarnationMemories
    {
      [Token(Token = "0x600B6CC"), Address(RVA = "0x22EDDC0", Offset = "0x22EDDC0", VA = "0x22EDDC0")] get
      {
        return (List<PlayerUnitReincarnationMemoryType>) null;
      }
    }

    [Token(Token = "0x600B6CD")]
    [Address(RVA = "0x22EDDC8", Offset = "0x22EDDC8", VA = "0x22EDDC8")]
    public APIUnitReincarnationMemorizeResponse()
    {
    }
  }
}
