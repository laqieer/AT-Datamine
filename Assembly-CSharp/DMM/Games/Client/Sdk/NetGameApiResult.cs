// Decompiled with JetBrains decompiler
// Type: DMM.Games.Client.Sdk.NetGameApiResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace DMM.Games.Client.Sdk
{
  [Token(Token = "0x2003FC7")]
  [Serializable]
  public class NetGameApiResult
  {
    [Token(Token = "0x4011768")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [HideInInspector]
    protected NetGameApiSdk.ErrorCode result_code;
    [Token(Token = "0x4011769")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    protected string access_token;
    [Token(Token = "0x401176A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    protected string onetime_token;
    [Token(Token = "0x401176B")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    [SerializeField]
    protected int can_use_point;
    [Token(Token = "0x401176C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [HideInInspector]
    protected int can_use_chip;
    [Token(Token = "0x401176D")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    [SerializeField]
    protected string nickname;
    [Token(Token = "0x401176E")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    [SerializeField]
    protected bool install_status;
    [Token(Token = "0x401176F")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    [SerializeField]
    protected string payment_id;
    [Token(Token = "0x4011770")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [HideInInspector]
    protected long accept_time;

    [Token(Token = "0x170052A8")]
    public string AccessToken
    {
      [Token(Token = "0x6019A58"), Address(RVA = "0x3788668", Offset = "0x3788668", VA = "0x3788668")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A59"), Address(RVA = "0x3788670", Offset = "0x3788670", VA = "0x3788670")] protected set
      {
      }
    }

    [Token(Token = "0x170052A9")]
    public string OnetimeToken
    {
      [Token(Token = "0x6019A5A"), Address(RVA = "0x3788678", Offset = "0x3788678", VA = "0x3788678")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A5B"), Address(RVA = "0x3788680", Offset = "0x3788680", VA = "0x3788680")] protected set
      {
      }
    }

    [Token(Token = "0x170052AA")]
    public int CanUsePoint
    {
      [Token(Token = "0x6019A5C"), Address(RVA = "0x3788688", Offset = "0x3788688", VA = "0x3788688")] get
      {
        return new int();
      }
      [Token(Token = "0x6019A5D"), Address(RVA = "0x3788690", Offset = "0x3788690", VA = "0x3788690")] protected set
      {
      }
    }

    [Token(Token = "0x170052AB")]
    public int CanUseChip
    {
      [Token(Token = "0x6019A5E"), Address(RVA = "0x3788698", Offset = "0x3788698", VA = "0x3788698")] get
      {
        return new int();
      }
      [Token(Token = "0x6019A5F"), Address(RVA = "0x37886A0", Offset = "0x37886A0", VA = "0x37886A0")] protected set
      {
      }
    }

    [Token(Token = "0x170052AC")]
    public string Nickname
    {
      [Token(Token = "0x6019A60"), Address(RVA = "0x37886A8", Offset = "0x37886A8", VA = "0x37886A8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A61"), Address(RVA = "0x37886B0", Offset = "0x37886B0", VA = "0x37886B0")] protected set
      {
      }
    }

    [Token(Token = "0x170052AD")]
    public bool InstallStatus
    {
      [Token(Token = "0x6019A62"), Address(RVA = "0x37886B8", Offset = "0x37886B8", VA = "0x37886B8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6019A63"), Address(RVA = "0x37886C0", Offset = "0x37886C0", VA = "0x37886C0")] protected set
      {
      }
    }

    [Token(Token = "0x170052AE")]
    public string PaymentId
    {
      [Token(Token = "0x6019A64"), Address(RVA = "0x37886CC", Offset = "0x37886CC", VA = "0x37886CC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A65"), Address(RVA = "0x37886D4", Offset = "0x37886D4", VA = "0x37886D4")] protected set
      {
      }
    }

    [Token(Token = "0x170052AF")]
    public long AcceptTime
    {
      [Token(Token = "0x6019A66"), Address(RVA = "0x37886DC", Offset = "0x37886DC", VA = "0x37886DC")] get
      {
        return new long();
      }
      [Token(Token = "0x6019A67"), Address(RVA = "0x37886E4", Offset = "0x37886E4", VA = "0x37886E4")] protected set
      {
      }
    }

    [Token(Token = "0x6019A68")]
    [Address(RVA = "0x3788488", Offset = "0x3788488", VA = "0x3788488")]
    public static NetGameApiResult Parse(string json) => (NetGameApiResult) null;

    [Token(Token = "0x6019A69")]
    [Address(RVA = "0x37886F4", Offset = "0x37886F4", VA = "0x37886F4")]
    public string ToJson() => (string) null;

    [Token(Token = "0x6019A6A")]
    [Address(RVA = "0x3788588", Offset = "0x3788588", VA = "0x3788588")]
    public bool IsSuccess() => new bool();

    [Token(Token = "0x6019A6B")]
    [Address(RVA = "0x37886FC", Offset = "0x37886FC", VA = "0x37886FC")]
    public NetGameApiSdk.ErrorCode GetErrorCode() => new NetGameApiSdk.ErrorCode();

    [Token(Token = "0x6019A6C")]
    [Address(RVA = "0x37886EC", Offset = "0x37886EC", VA = "0x37886EC")]
    public NetGameApiResult()
    {
    }
  }
}
