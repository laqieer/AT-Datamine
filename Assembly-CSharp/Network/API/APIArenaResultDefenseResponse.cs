// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaResultDefenseResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B98")]
  [Serializable]
  public class APIArenaResultDefenseResponse
  {
    [Token(Token = "0x4007655")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int win_count;
    [Token(Token = "0x4007656")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int lose_count;

    [Token(Token = "0x17001DDE")]
    public int WinCount
    {
      [Token(Token = "0x600A227"), Address(RVA = "0x46CA380", Offset = "0x46CA380", VA = "0x46CA380")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001DDF")]
    public int LoseCount
    {
      [Token(Token = "0x600A228"), Address(RVA = "0x46CA388", Offset = "0x46CA388", VA = "0x46CA388")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A229")]
    [Address(RVA = "0x46CA390", Offset = "0x46CA390", VA = "0x46CA390")]
    public APIArenaResultDefenseResponse()
    {
    }
  }
}
