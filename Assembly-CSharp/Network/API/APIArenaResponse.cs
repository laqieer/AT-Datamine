// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaResponse
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
  [Token(Token = "0x2001B80")]
  [Serializable]
  public class APIArenaResponse
  {
    [Token(Token = "0x40075EB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerArenaType> player_arenas;

    [Token(Token = "0x17001D9E")]
    public List<PlayerArenaType> PlayerArenas
    {
      [Token(Token = "0x600A187"), Address(RVA = "0x46C82D8", Offset = "0x46C82D8", VA = "0x46C82D8")] get
      {
        return (List<PlayerArenaType>) null;
      }
    }

    [Token(Token = "0x600A188")]
    [Address(RVA = "0x46C82E0", Offset = "0x46C82E0", VA = "0x46C82E0")]
    public APIArenaResponse()
    {
    }
  }
}
