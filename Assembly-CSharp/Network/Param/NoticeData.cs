// Decompiled with JetBrains decompiler
// Type: Network.Param.NoticeData
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
  [Token(Token = "0x2001A78")]
  [Serializable]
  public class NoticeData
  {
    [Token(Token = "0x4007180")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<int> mission;

    [Token(Token = "0x170019C4")]
    public List<int> Mission
    {
      [Token(Token = "0x6009889"), Address(RVA = "0x48F022C", Offset = "0x48F022C", VA = "0x48F022C")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600988A"), Address(RVA = "0x48F0234", Offset = "0x48F0234", VA = "0x48F0234")] set
      {
      }
    }

    [Token(Token = "0x600988B")]
    [Address(RVA = "0x48F023C", Offset = "0x48F023C", VA = "0x48F023C")]
    public NoticeData()
    {
    }
  }
}
