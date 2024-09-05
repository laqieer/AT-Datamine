// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.LpRecoveryRequestor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003709")]
  public class LpRecoveryRequestor
  {
    [Token(Token = "0x400F048")]
    [FieldOffset(Offset = "0x10")]
    private readonly int _characterId;
    [Token(Token = "0x400F049")]
    [FieldOffset(Offset = "0x18")]
    private readonly List<RequestPaymentType> _payments;

    [Token(Token = "0x6015ACB")]
    [Address(RVA = "0x1D85ACC", Offset = "0x1D85ACC", VA = "0x1D85ACC")]
    public static LpRecoveryRequestor CreateFromRecoveryNum(int characterId, int recoveryNum)
    {
      return (LpRecoveryRequestor) null;
    }

    [Token(Token = "0x6015ACC")]
    [Address(RVA = "0x1D85F64", Offset = "0x1D85F64", VA = "0x1D85F64")]
    public LpRecoveryRequestor(int characterId, List<RequestPaymentType> payments)
    {
    }

    [Token(Token = "0x6015ACD")]
    [Address(RVA = "0x1D85F94", Offset = "0x1D85F94", VA = "0x1D85F94")]
    public IEnumerator Connect(
      Action<APIUnitCharacterLp_recoveryResponse> callback)
    {
      return (IEnumerator) null;
    }
  }
}
