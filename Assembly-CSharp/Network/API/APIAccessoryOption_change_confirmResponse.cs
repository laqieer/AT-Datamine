// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryOption_change_confirmResponse
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
  [Token(Token = "0x2001B44")]
  [Serializable]
  public class APIAccessoryOption_change_confirmResponse
  {
    [Token(Token = "0x40074F1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerGearAccessoryType player_accessory;

    [Token(Token = "0x17001D1B")]
    public PlayerGearAccessoryType PlayerAccessory
    {
      [Token(Token = "0x600A014"), Address(RVA = "0x46C321C", Offset = "0x46C321C", VA = "0x46C321C")] get
      {
        return (PlayerGearAccessoryType) null;
      }
    }

    [Token(Token = "0x600A015")]
    [Address(RVA = "0x46C3224", Offset = "0x46C3224", VA = "0x46C3224")]
    public APIAccessoryOption_change_confirmResponse()
    {
    }
  }
}
