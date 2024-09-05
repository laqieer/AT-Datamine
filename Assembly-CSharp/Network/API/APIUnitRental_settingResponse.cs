// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitRental_settingResponse
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
  [Token(Token = "0x2001ED4")]
  [Serializable]
  public class APIUnitRental_settingResponse
  {
    [Token(Token = "0x400846B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerUnitRentalSettingType rental_setting;

    [Token(Token = "0x170025E0")]
    public PlayerUnitRentalSettingType RentalSetting
    {
      [Token(Token = "0x600B719"), Address(RVA = "0x212F940", Offset = "0x212F940", VA = "0x212F940")] get
      {
        return (PlayerUnitRentalSettingType) null;
      }
    }

    [Token(Token = "0x600B71A")]
    [Address(RVA = "0x212F948", Offset = "0x212F948", VA = "0x212F948")]
    public APIUnitRental_settingResponse()
    {
    }
  }
}
