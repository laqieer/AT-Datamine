// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerItemsetType
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
  [Token(Token = "0x2001AC5")]
  [Serializable]
  public class PlayerItemsetType
  {
    [Token(Token = "0x40072B9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int player_item_set_id;
    [Token(Token = "0x40072BA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerExpendableType> player_items;

    [Token(Token = "0x17001B0F")]
    public int PlayerItemSetId
    {
      [Token(Token = "0x6009B5A"), Address(RVA = "0x48F1AE4", Offset = "0x48F1AE4", VA = "0x48F1AE4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B5B"), Address(RVA = "0x48F1AEC", Offset = "0x48F1AEC", VA = "0x48F1AEC")] set
      {
      }
    }

    [Token(Token = "0x17001B10")]
    public List<PlayerExpendableType> PlayerItems
    {
      [Token(Token = "0x6009B5C"), Address(RVA = "0x48F1AF4", Offset = "0x48F1AF4", VA = "0x48F1AF4")] get
      {
        return (List<PlayerExpendableType>) null;
      }
      [Token(Token = "0x6009B5D"), Address(RVA = "0x48F1AFC", Offset = "0x48F1AFC", VA = "0x48F1AFC")] set
      {
      }
    }

    [Token(Token = "0x6009B5E")]
    [Address(RVA = "0x48F1B04", Offset = "0x48F1B04", VA = "0x48F1B04")]
    public PlayerItemsetType()
    {
    }
  }
}
