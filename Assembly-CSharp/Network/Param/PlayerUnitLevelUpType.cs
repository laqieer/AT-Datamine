// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitLevelUpType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AFC")]
  [Serializable]
  public class PlayerUnitLevelUpType
  {
    [Token(Token = "0x40073E3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_unit_id;
    [Token(Token = "0x40073E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerUnitLevelUpStatusType> statuses;

    [Token(Token = "0x17001C45")]
    public string PlayerUnitId
    {
      [Token(Token = "0x6009DF1"), Address(RVA = "0x48F303C", Offset = "0x48F303C", VA = "0x48F303C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009DF2"), Address(RVA = "0x48F3044", Offset = "0x48F3044", VA = "0x48F3044")] set
      {
      }
    }

    [Token(Token = "0x17001C46")]
    public List<PlayerUnitLevelUpStatusType> Statuses
    {
      [Token(Token = "0x6009DF3"), Address(RVA = "0x48F304C", Offset = "0x48F304C", VA = "0x48F304C")] get
      {
        return (List<PlayerUnitLevelUpStatusType>) null;
      }
      [Token(Token = "0x6009DF4"), Address(RVA = "0x48F3054", Offset = "0x48F3054", VA = "0x48F3054")] set
      {
      }
    }

    [Token(Token = "0x6009DF5")]
    [Address(RVA = "0x48F305C", Offset = "0x48F305C", VA = "0x48F305C")]
    public PlayerUnitLevelUpType()
    {
    }
  }
}
