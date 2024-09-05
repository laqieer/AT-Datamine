// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAreaMapObjectStatus
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
  [Token(Token = "0x2001A83")]
  [Serializable]
  public class PlayerAreaMapObjectStatus
  {
    [Token(Token = "0x40071AA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<int> opened_chest_ids;
    [Token(Token = "0x40071AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<int> broken_object_ids;

    [Token(Token = "0x170019EE")]
    public List<int> OpenedChestIds
    {
      [Token(Token = "0x60098E8"), Address(RVA = "0x48F053C", Offset = "0x48F053C", VA = "0x48F053C")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x60098E9"), Address(RVA = "0x48F0544", Offset = "0x48F0544", VA = "0x48F0544")] set
      {
      }
    }

    [Token(Token = "0x170019EF")]
    public List<int> BrokenObjectIds
    {
      [Token(Token = "0x60098EA"), Address(RVA = "0x48F054C", Offset = "0x48F054C", VA = "0x48F054C")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x60098EB"), Address(RVA = "0x48F0554", Offset = "0x48F0554", VA = "0x48F0554")] set
      {
      }
    }

    [Token(Token = "0x60098EC")]
    [Address(RVA = "0x48F055C", Offset = "0x48F055C", VA = "0x48F055C")]
    public PlayerAreaMapObjectStatus()
    {
    }
  }
}
