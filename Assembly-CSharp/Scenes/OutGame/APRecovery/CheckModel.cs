// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.CheckModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x2003966")]
  internal class CheckModel
  {
    [Token(Token = "0x6016907")]
    [Address(RVA = "0x42F0A40", Offset = "0x42F0A40", VA = "0x42F0A40")]
    public CheckModel(ApRecoveryModel apRecoveryModel)
    {
    }

    [Token(Token = "0x17004A3E")]
    public int NowAp
    {
      [Token(Token = "0x6016908"), Address(RVA = "0x42F0AA0", Offset = "0x42F0AA0", VA = "0x42F0AA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A3F")]
    public int RecoveryAp
    {
      [Token(Token = "0x6016909"), Address(RVA = "0x42F0AA8", Offset = "0x42F0AA8", VA = "0x42F0AA8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A40")]
    public int TotalCoin
    {
      [Token(Token = "0x601690A"), Address(RVA = "0x42F0AB0", Offset = "0x42F0AB0", VA = "0x42F0AB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A41")]
    public int PaidCoin
    {
      [Token(Token = "0x601690B"), Address(RVA = "0x42F0ABC", Offset = "0x42F0ABC", VA = "0x42F0ABC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A42")]
    public int FreeCoin
    {
      [Token(Token = "0x601690C"), Address(RVA = "0x42F0AC4", Offset = "0x42F0AC4", VA = "0x42F0AC4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A43")]
    public int ConsumeTotalCoin
    {
      [Token(Token = "0x601690D"), Address(RVA = "0x42F0ACC", Offset = "0x42F0ACC", VA = "0x42F0ACC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A44")]
    public int ConsumePaidCoin
    {
      [Token(Token = "0x601690E"), Address(RVA = "0x42F0AD4", Offset = "0x42F0AD4", VA = "0x42F0AD4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A45")]
    public int ConsumeFreeCoin
    {
      [Token(Token = "0x601690F"), Address(RVA = "0x42F0AEC", Offset = "0x42F0AEC", VA = "0x42F0AEC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A46")]
    public int NextPaidCoin
    {
      [Token(Token = "0x6016910"), Address(RVA = "0x42F0B4C", Offset = "0x42F0B4C", VA = "0x42F0B4C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A47")]
    public int NextFreeCoin
    {
      [Token(Token = "0x6016911"), Address(RVA = "0x42F0BCC", Offset = "0x42F0BCC", VA = "0x42F0BCC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A48")]
    public bool CanApRecovery
    {
      [Token(Token = "0x6016912"), Address(RVA = "0x42F0C3C", Offset = "0x42F0C3C", VA = "0x42F0C3C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6016913")]
    [Address(RVA = "0x42F0C54", Offset = "0x42F0C54", VA = "0x42F0C54")]
    public IEnumerator RequestRecoveryByCoinAsync(
      Action<string> onMessgae,
      Action onBuyConfirmStone,
      Action onSuccess = null,
      Action onError = null)
    {
      return (IEnumerator) null;
    }
  }
}
