// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardListResponse
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
  [Token(Token = "0x2001E9C")]
  [Serializable]
  public class APIUnitAbilityboardListResponse
  {
    [Token(Token = "0x400838B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerUnitAbilityBoardType> release_nodes;
    [Token(Token = "0x400838C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerUnitAbilityBoardCustomANodeType> customA_data;
    [Token(Token = "0x400838D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerUnitAbilityBoardCustomBNodeType> customB_data;

    [Token(Token = "0x17002563")]
    public List<PlayerUnitAbilityBoardType> ReleaseNodes
    {
      [Token(Token = "0x600B5BC"), Address(RVA = "0x22EA28C", Offset = "0x22EA28C", VA = "0x22EA28C")] get
      {
        return (List<PlayerUnitAbilityBoardType>) null;
      }
    }

    [Token(Token = "0x17002564")]
    public List<PlayerUnitAbilityBoardCustomANodeType> CustomaData
    {
      [Token(Token = "0x600B5BD"), Address(RVA = "0x22EA294", Offset = "0x22EA294", VA = "0x22EA294")] get
      {
        return (List<PlayerUnitAbilityBoardCustomANodeType>) null;
      }
    }

    [Token(Token = "0x17002565")]
    public List<PlayerUnitAbilityBoardCustomBNodeType> CustombData
    {
      [Token(Token = "0x600B5BE"), Address(RVA = "0x22EA29C", Offset = "0x22EA29C", VA = "0x22EA29C")] get
      {
        return (List<PlayerUnitAbilityBoardCustomBNodeType>) null;
      }
    }

    [Token(Token = "0x600B5BF")]
    [Address(RVA = "0x22EA2A4", Offset = "0x22EA2A4", VA = "0x22EA2A4")]
    public APIUnitAbilityboardListResponse()
    {
    }
  }
}
