// Decompiled with JetBrains decompiler
// Type: Network.Param.AdvRequest
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
  [Token(Token = "0x2001A3C")]
  [Serializable]
  public class AdvRequest
  {
    [Token(Token = "0x4007029")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int adv_id;
    [Token(Token = "0x400702A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<int> selected_option_ids;
    [Token(Token = "0x400702B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<int> unlocked_option_ids;
    [Token(Token = "0x400702C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<int> selected_additional_option_ids;

    [Token(Token = "0x1700185F")]
    public int AdvId
    {
      [Token(Token = "0x6009590"), Address(RVA = "0x48EEAA0", Offset = "0x48EEAA0", VA = "0x48EEAA0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009591"), Address(RVA = "0x48EEAA8", Offset = "0x48EEAA8", VA = "0x48EEAA8")] set
      {
      }
    }

    [Token(Token = "0x17001860")]
    public List<int> SelectedOptionIds
    {
      [Token(Token = "0x6009592"), Address(RVA = "0x48EEAB0", Offset = "0x48EEAB0", VA = "0x48EEAB0")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6009593"), Address(RVA = "0x48EEAB8", Offset = "0x48EEAB8", VA = "0x48EEAB8")] set
      {
      }
    }

    [Token(Token = "0x17001861")]
    public List<int> UnlockedOptionIds
    {
      [Token(Token = "0x6009594"), Address(RVA = "0x48EEAC0", Offset = "0x48EEAC0", VA = "0x48EEAC0")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6009595"), Address(RVA = "0x48EEAC8", Offset = "0x48EEAC8", VA = "0x48EEAC8")] set
      {
      }
    }

    [Token(Token = "0x17001862")]
    public List<int> SelectedAdditionalOptionIds
    {
      [Token(Token = "0x6009596"), Address(RVA = "0x48EEAD0", Offset = "0x48EEAD0", VA = "0x48EEAD0")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6009597"), Address(RVA = "0x48EEAD8", Offset = "0x48EEAD8", VA = "0x48EEAD8")] set
      {
      }
    }

    [Token(Token = "0x6009598")]
    [Address(RVA = "0x48EEAE0", Offset = "0x48EEAE0", VA = "0x48EEAE0")]
    public AdvRequest()
    {
    }
  }
}
