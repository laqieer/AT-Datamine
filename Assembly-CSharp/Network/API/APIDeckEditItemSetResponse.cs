// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckEditItemSetResponse
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
  [Token(Token = "0x2001BFC")]
  [Serializable]
  public class APIDeckEditItemSetResponse
  {
    [Token(Token = "0x40077D0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerItemsetType item_set;

    [Token(Token = "0x17001EAD")]
    public PlayerItemsetType ItemSet
    {
      [Token(Token = "0x600A486"), Address(RVA = "0x46D29B4", Offset = "0x46D29B4", VA = "0x46D29B4")] get
      {
        return (PlayerItemsetType) null;
      }
    }

    [Token(Token = "0x600A487")]
    [Address(RVA = "0x46D29BC", Offset = "0x46D29BC", VA = "0x46D29BC")]
    public APIDeckEditItemSetResponse()
    {
    }
  }
}
