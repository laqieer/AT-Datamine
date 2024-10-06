// Decompiled with JetBrains decompiler
// Type: Network.API.APIPresentHistoryResponse
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
  [Token(Token = "0x2001DC0")]
  [Serializable]
  public class APIPresentHistoryResponse
  {
    [Token(Token = "0x4007F17")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerPresentType> histories;
    [Token(Token = "0x4007F18")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int total_histories_number;

    [Token(Token = "0x170022EB")]
    public List<PlayerPresentType> Histories
    {
      [Token(Token = "0x600AFD4"), Address(RVA = "0x1A51774", Offset = "0x1A51774", VA = "0x1A51774")] get
      {
        return (List<PlayerPresentType>) null;
      }
    }

    [Token(Token = "0x170022EC")]
    public int TotalHistoriesNumber
    {
      [Token(Token = "0x600AFD5"), Address(RVA = "0x1A5177C", Offset = "0x1A5177C", VA = "0x1A5177C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600AFD6")]
    [Address(RVA = "0x1A51784", Offset = "0x1A51784", VA = "0x1A51784")]
    public APIPresentHistoryResponse()
    {
    }
  }
}
