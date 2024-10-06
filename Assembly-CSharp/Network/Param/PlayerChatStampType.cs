// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerChatStampType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A9A")]
  [Serializable]
  public class PlayerChatStampType
  {
    [Token(Token = "0x4007204")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;

    [Token(Token = "0x17001A51")]
    public int ItemId
    {
      [Token(Token = "0x60099BC"), Address(RVA = "0x48F0CD8", Offset = "0x48F0CD8", VA = "0x48F0CD8")] get
      {
        return new int();
      }
      [Token(Token = "0x60099BD"), Address(RVA = "0x48F0CE0", Offset = "0x48F0CE0", VA = "0x48F0CE0")] set
      {
      }
    }

    [Token(Token = "0x60099BE")]
    [Address(RVA = "0x48F0CE8", Offset = "0x48F0CE8", VA = "0x48F0CE8")]
    public PlayerChatStampType()
    {
    }
  }
}
