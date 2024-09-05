// Decompiled with JetBrains decompiler
// Type: LoginBonus.DebugMultipleItemDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000ABC")]
  internal class DebugMultipleItemDetail
  {
    [Token(Token = "0x400314D")]
    [FieldOffset(Offset = "0x10")]
    private DebugLoginBonusBehaviour loginBonusBehaviour;
    [Token(Token = "0x400314F")]
    [FieldOffset(Offset = "0x20")]
    private IEnumerable<LoginBonusSingleRewardUIParam> rewards;

    [Token(Token = "0x140000EB")]
    private event Action OnClickClose
    {
      [Token(Token = "0x6003D13"), Address(RVA = "0x2C09E70", Offset = "0x2C09E70", VA = "0x2C09E70")] add
      {
      }
      [Token(Token = "0x6003D14"), Address(RVA = "0x2C09F0C", Offset = "0x2C09F0C", VA = "0x2C09F0C")] remove
      {
      }
    }

    [Token(Token = "0x6003D15")]
    [Address(RVA = "0x2C09FA8", Offset = "0x2C09FA8", VA = "0x2C09FA8")]
    public void Initialize(IEnumerable<LoginBonusSingleRewardUIParam> rewards, Action onClickClose)
    {
    }

    [Token(Token = "0x6003D16")]
    [Address(RVA = "0x2C0A04C", Offset = "0x2C0A04C", VA = "0x2C0A04C")]
    public void Release()
    {
    }

    [Token(Token = "0x6003D17")]
    [Address(RVA = "0x2C0A0F0", Offset = "0x2C0A0F0", VA = "0x2C0A0F0")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x6003D18")]
    [Address(RVA = "0x2C0A910", Offset = "0x2C0A910", VA = "0x2C0A910")]
    private void OnClickDetail(LoginBonusSingleRewardUIParam reward)
    {
    }

    [Token(Token = "0x6003D19")]
    [Address(RVA = "0x2C0AA50", Offset = "0x2C0AA50", VA = "0x2C0AA50")]
    public DebugMultipleItemDetail()
    {
    }
  }
}
