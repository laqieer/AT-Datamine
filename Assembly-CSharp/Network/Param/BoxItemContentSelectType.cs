// Decompiled with JetBrains decompiler
// Type: Network.Param.BoxItemContentSelectType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A46")]
  [Serializable]
  public class BoxItemContentSelectType
  {
    [Token(Token = "0x400705A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int content_id;
    [Token(Token = "0x400705B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int count;

    [Token(Token = "0x17001890")]
    public int ContentId
    {
      [Token(Token = "0x60095FC"), Address(RVA = "0x48EEE1C", Offset = "0x48EEE1C", VA = "0x48EEE1C")] get
      {
        return new int();
      }
      [Token(Token = "0x60095FD"), Address(RVA = "0x48EEE24", Offset = "0x48EEE24", VA = "0x48EEE24")] set
      {
      }
    }

    [Token(Token = "0x17001891")]
    public int Count
    {
      [Token(Token = "0x60095FE"), Address(RVA = "0x48EEE2C", Offset = "0x48EEE2C", VA = "0x48EEE2C")] get
      {
        return new int();
      }
      [Token(Token = "0x60095FF"), Address(RVA = "0x48EEE34", Offset = "0x48EEE34", VA = "0x48EEE34")] set
      {
      }
    }

    [Token(Token = "0x6009600")]
    [Address(RVA = "0x48EEE3C", Offset = "0x48EEE3C", VA = "0x48EEE3C")]
    public BoxItemContentSelectType()
    {
    }
  }
}
