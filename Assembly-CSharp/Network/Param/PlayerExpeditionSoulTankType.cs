// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpeditionSoulTankType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AAC")]
  [Serializable]
  public class PlayerExpeditionSoulTankType
  {
    [Token(Token = "0x400724C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x400724D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int soul_type;
    [Token(Token = "0x400724E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int level;

    [Token(Token = "0x17001A99")]
    public string Id
    {
      [Token(Token = "0x6009A5E"), Address(RVA = "0x48F11EC", Offset = "0x48F11EC", VA = "0x48F11EC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A5F"), Address(RVA = "0x48F11F4", Offset = "0x48F11F4", VA = "0x48F11F4")] set
      {
      }
    }

    [Token(Token = "0x17001A9A")]
    public int SoulType
    {
      [Token(Token = "0x6009A60"), Address(RVA = "0x48F11FC", Offset = "0x48F11FC", VA = "0x48F11FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A61"), Address(RVA = "0x48F1204", Offset = "0x48F1204", VA = "0x48F1204")] set
      {
      }
    }

    [Token(Token = "0x17001A9B")]
    public int Level
    {
      [Token(Token = "0x6009A62"), Address(RVA = "0x48F120C", Offset = "0x48F120C", VA = "0x48F120C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A63"), Address(RVA = "0x48F1214", Offset = "0x48F1214", VA = "0x48F1214")] set
      {
      }
    }

    [Token(Token = "0x6009A64")]
    [Address(RVA = "0x48F121C", Offset = "0x48F121C", VA = "0x48F121C")]
    public PlayerExpeditionSoulTankType()
    {
    }
  }
}
