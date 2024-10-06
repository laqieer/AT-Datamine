// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerProfileChangeType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ACE")]
  [Serializable]
  public class PlayerProfileChangeType
  {
    [Token(Token = "0x40072E4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string name_change_cool_time_end_at;

    [Token(Token = "0x17001B46")]
    public string NameChangeCoolTimeEndAt
    {
      [Token(Token = "0x6009BC5"), Address(RVA = "0x48F1EB0", Offset = "0x48F1EB0", VA = "0x48F1EB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BC6"), Address(RVA = "0x48F1EB8", Offset = "0x48F1EB8", VA = "0x48F1EB8")] set
      {
      }
    }

    [Token(Token = "0x6009BC7")]
    [Address(RVA = "0x48F1EC0", Offset = "0x48F1EC0", VA = "0x48F1EC0")]
    public PlayerProfileChangeType()
    {
    }
  }
}
