// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel.BatchConversionRequestor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel
{
  [Token(Token = "0x2003BF7")]
  public class BatchConversionRequestor
  {
    [Token(Token = "0x40109AC")]
    [FieldOffset(Offset = "0x20")]
    private bool _isApiError;
    [Token(Token = "0x40109AD")]
    [FieldOffset(Offset = "0x28")]
    private List<PlayerGearMindEquipmentMedalExchangeType> conversionList;

    [Token(Token = "0x6017919")]
    [Address(RVA = "0x237BC7C", Offset = "0x237BC7C", VA = "0x237BC7C")]
    public BatchConversionRequestor(
      List<PlayerGearMindEquipmentMedalExchangeType> list)
    {
    }

    [Token(Token = "0x17004C8E")]
    public Action<APIMind_equipmentMedal_exchangeResponse> OnSuccess
    {
      [Token(Token = "0x601791A"), Address(RVA = "0x237BD0C", Offset = "0x237BD0C", VA = "0x237BD0C")] get
      {
        return (Action<APIMind_equipmentMedal_exchangeResponse>) null;
      }
      [Token(Token = "0x601791B"), Address(RVA = "0x237BD14", Offset = "0x237BD14", VA = "0x237BD14")] set
      {
      }
    }

    [Token(Token = "0x17004C8F")]
    public Action<int> OnError
    {
      [Token(Token = "0x601791C"), Address(RVA = "0x237BD1C", Offset = "0x237BD1C", VA = "0x237BD1C")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x601791D"), Address(RVA = "0x237BD24", Offset = "0x237BD24", VA = "0x237BD24")] set
      {
      }
    }

    [Token(Token = "0x601791E")]
    [Address(RVA = "0x237BD2C", Offset = "0x237BD2C", VA = "0x237BD2C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x601791F")]
    [Address(RVA = "0x237BDBC", Offset = "0x237BDBC", VA = "0x237BDBC")]
    private IEnumerator ApiError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;
  }
}
