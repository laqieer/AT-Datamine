// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel.ConversionRequestor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using StaqData;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel
{
  [Token(Token = "0x2003BFA")]
  public class ConversionRequestor
  {
    [Token(Token = "0x40109B7")]
    [FieldOffset(Offset = "0x20")]
    private MindEquipment _mindEquipment;
    [Token(Token = "0x40109B8")]
    [FieldOffset(Offset = "0x28")]
    private int _conversionCount;
    [Token(Token = "0x40109B9")]
    [FieldOffset(Offset = "0x2C")]
    private bool _isApiError;

    [Token(Token = "0x601792C")]
    [Address(RVA = "0x237C104", Offset = "0x237C104", VA = "0x237C104")]
    public ConversionRequestor(MindEquipment mindEquipment, int conversionCount)
    {
    }

    [Token(Token = "0x17004C94")]
    public Action<APIMind_equipmentMedal_exchangeResponse> OnSuccess
    {
      [Token(Token = "0x601792D"), Address(RVA = "0x237C134", Offset = "0x237C134", VA = "0x237C134")] get
      {
        return (Action<APIMind_equipmentMedal_exchangeResponse>) null;
      }
      [Token(Token = "0x601792E"), Address(RVA = "0x237C13C", Offset = "0x237C13C", VA = "0x237C13C")] set
      {
      }
    }

    [Token(Token = "0x17004C95")]
    public Action<int> OnError
    {
      [Token(Token = "0x601792F"), Address(RVA = "0x237C144", Offset = "0x237C144", VA = "0x237C144")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6017930"), Address(RVA = "0x237C14C", Offset = "0x237C14C", VA = "0x237C14C")] set
      {
      }
    }

    [Token(Token = "0x6017931")]
    [Address(RVA = "0x237C154", Offset = "0x237C154", VA = "0x237C154")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6017932")]
    [Address(RVA = "0x237C1E4", Offset = "0x237C1E4", VA = "0x237C1E4")]
    private IEnumerator ApiError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;
  }
}
