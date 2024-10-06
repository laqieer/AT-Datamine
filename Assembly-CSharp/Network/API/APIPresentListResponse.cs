// Decompiled with JetBrains decompiler
// Type: Network.API.APIPresentListResponse
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
  [Token(Token = "0x2001DC4")]
  [Serializable]
  public class APIPresentListResponse
  {
    [Token(Token = "0x4007F27")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerPresentType> presents;
    [Token(Token = "0x4007F28")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerPresentType> non_active_presents;
    [Token(Token = "0x4007F29")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int total_presents_number;
    [Token(Token = "0x4007F2A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int non_active_total_presents_number;
    [Token(Token = "0x4007F2B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerPresentType> expired_presents;

    [Token(Token = "0x170022F3")]
    public List<PlayerPresentType> Presents
    {
      [Token(Token = "0x600AFEC"), Address(RVA = "0x1A51CD0", Offset = "0x1A51CD0", VA = "0x1A51CD0")] get
      {
        return (List<PlayerPresentType>) null;
      }
    }

    [Token(Token = "0x170022F4")]
    public List<PlayerPresentType> NonActivePresents
    {
      [Token(Token = "0x600AFED"), Address(RVA = "0x1A51CD8", Offset = "0x1A51CD8", VA = "0x1A51CD8")] get
      {
        return (List<PlayerPresentType>) null;
      }
    }

    [Token(Token = "0x170022F5")]
    public int TotalPresentsNumber
    {
      [Token(Token = "0x600AFEE"), Address(RVA = "0x1A51CE0", Offset = "0x1A51CE0", VA = "0x1A51CE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170022F6")]
    public int NonActiveTotalPresentsNumber
    {
      [Token(Token = "0x600AFEF"), Address(RVA = "0x1A51CE8", Offset = "0x1A51CE8", VA = "0x1A51CE8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170022F7")]
    public List<PlayerPresentType> ExpiredPresents
    {
      [Token(Token = "0x600AFF0"), Address(RVA = "0x1A51CF0", Offset = "0x1A51CF0", VA = "0x1A51CF0")] get
      {
        return (List<PlayerPresentType>) null;
      }
    }

    [Token(Token = "0x600AFF1")]
    [Address(RVA = "0x1A51CF8", Offset = "0x1A51CF8", VA = "0x1A51CF8")]
    public APIPresentListResponse()
    {
    }
  }
}
