// Decompiled with JetBrains decompiler
// Type: Network.API.APIBlockRemoveResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BB8")]
  [Serializable]
  public class APIBlockRemoveResponse
  {
    [Token(Token = "0x40076D0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string removed_player_id;

    [Token(Token = "0x17001E1F")]
    public string RemovedPlayerId
    {
      [Token(Token = "0x600A2E8"), Address(RVA = "0x46CCE68", Offset = "0x46CCE68", VA = "0x46CCE68")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600A2E9")]
    [Address(RVA = "0x46CCE70", Offset = "0x46CCE70", VA = "0x46CCE70")]
    public APIBlockRemoveResponse()
    {
    }
  }
}
