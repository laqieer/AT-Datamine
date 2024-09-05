// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerApType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A82")]
  [Serializable]
  public class PlayerApType
  {
    [Token(Token = "0x40071A6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int last_modified_ap;
    [Token(Token = "0x40071A7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string ap_modified_at;
    [Token(Token = "0x40071A8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int ap_day_recovery_item_count;
    [Token(Token = "0x40071A9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int ap_day_recovery_coin_count;

    [Token(Token = "0x170019EA")]
    public int LastModifiedAp
    {
      [Token(Token = "0x60098DF"), Address(RVA = "0x48F04F4", Offset = "0x48F04F4", VA = "0x48F04F4")] get
      {
        return new int();
      }
      [Token(Token = "0x60098E0"), Address(RVA = "0x48F04FC", Offset = "0x48F04FC", VA = "0x48F04FC")] set
      {
      }
    }

    [Token(Token = "0x170019EB")]
    public string ApModifiedAt
    {
      [Token(Token = "0x60098E1"), Address(RVA = "0x48F0504", Offset = "0x48F0504", VA = "0x48F0504")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098E2"), Address(RVA = "0x48F050C", Offset = "0x48F050C", VA = "0x48F050C")] set
      {
      }
    }

    [Token(Token = "0x170019EC")]
    public int ApDayRecoveryItemCount
    {
      [Token(Token = "0x60098E3"), Address(RVA = "0x48F0514", Offset = "0x48F0514", VA = "0x48F0514")] get
      {
        return new int();
      }
      [Token(Token = "0x60098E4"), Address(RVA = "0x48F051C", Offset = "0x48F051C", VA = "0x48F051C")] set
      {
      }
    }

    [Token(Token = "0x170019ED")]
    public int ApDayRecoveryCoinCount
    {
      [Token(Token = "0x60098E5"), Address(RVA = "0x48F0524", Offset = "0x48F0524", VA = "0x48F0524")] get
      {
        return new int();
      }
      [Token(Token = "0x60098E6"), Address(RVA = "0x48F052C", Offset = "0x48F052C", VA = "0x48F052C")] set
      {
      }
    }

    [Token(Token = "0x60098E7")]
    [Address(RVA = "0x48F0534", Offset = "0x48F0534", VA = "0x48F0534")]
    public PlayerApType()
    {
    }
  }
}
