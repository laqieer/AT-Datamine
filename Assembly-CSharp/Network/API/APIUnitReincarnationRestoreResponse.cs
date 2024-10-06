// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitReincarnationRestoreResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001ED0")]
  [Serializable]
  public class APIUnitReincarnationRestoreResponse
  {
    [Token(Token = "0x4008457")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerUnitType updated_unit;
    [Token(Token = "0x4008458")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerUnitWarrantyParameterType updated_player_unit_warranty_parameter;

    [Token(Token = "0x170025D8")]
    public PlayerUnitType UpdatedUnit
    {
      [Token(Token = "0x600B701"), Address(RVA = "0x212F3E4", Offset = "0x212F3E4", VA = "0x212F3E4")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x170025D9")]
    public PlayerUnitWarrantyParameterType UpdatedPlayerUnitWarrantyParameter
    {
      [Token(Token = "0x600B702"), Address(RVA = "0x212F3EC", Offset = "0x212F3EC", VA = "0x212F3EC")] get
      {
        return (PlayerUnitWarrantyParameterType) null;
      }
    }

    [Token(Token = "0x600B703")]
    [Address(RVA = "0x212F3F4", Offset = "0x212F3F4", VA = "0x212F3F4")]
    public APIUnitReincarnationRestoreResponse()
    {
    }
  }
}
