// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryFavoriteResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B38")]
  [Serializable]
  public class APIAccessoryFavoriteResponse
  {
    [Token(Token = "0x40074C6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerGearAccessoryType> accessories;

    [Token(Token = "0x17001D03")]
    public List<PlayerGearAccessoryType> Accessories
    {
      [Token(Token = "0x6009FCC"), Address(RVA = "0x46C2208", Offset = "0x46C2208", VA = "0x46C2208")] get
      {
        return (List<PlayerGearAccessoryType>) null;
      }
    }

    [Token(Token = "0x6009FCD")]
    [Address(RVA = "0x46C2210", Offset = "0x46C2210", VA = "0x46C2210")]
    public APIAccessoryFavoriteResponse()
    {
    }
  }
}
