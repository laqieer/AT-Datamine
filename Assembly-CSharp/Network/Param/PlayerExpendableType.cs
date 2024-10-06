// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpendableType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AB0")]
  [Serializable]
  public class PlayerExpendableType
  {
    [Token(Token = "0x400725F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007260")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x4007261")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int quantity;

    [Token(Token = "0x17001AAC")]
    public string Id
    {
      [Token(Token = "0x6009A88"), Address(RVA = "0x48F133C", Offset = "0x48F133C", VA = "0x48F133C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A89"), Address(RVA = "0x48F1344", Offset = "0x48F1344", VA = "0x48F1344")] set
      {
      }
    }

    [Token(Token = "0x17001AAD")]
    public int ItemId
    {
      [Token(Token = "0x6009A8A"), Address(RVA = "0x48F134C", Offset = "0x48F134C", VA = "0x48F134C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A8B"), Address(RVA = "0x48F1354", Offset = "0x48F1354", VA = "0x48F1354")] set
      {
      }
    }

    [Token(Token = "0x17001AAE")]
    public int Quantity
    {
      [Token(Token = "0x6009A8C"), Address(RVA = "0x48F135C", Offset = "0x48F135C", VA = "0x48F135C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A8D"), Address(RVA = "0x48F1364", Offset = "0x48F1364", VA = "0x48F1364")] set
      {
      }
    }

    [Token(Token = "0x6009A8E")]
    [Address(RVA = "0x48F136C", Offset = "0x48F136C", VA = "0x48F136C")]
    public PlayerExpendableType()
    {
    }
  }
}
