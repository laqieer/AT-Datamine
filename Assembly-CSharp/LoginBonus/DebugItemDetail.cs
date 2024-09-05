// Decompiled with JetBrains decompiler
// Type: LoginBonus.DebugItemDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000ABB")]
  internal class DebugItemDetail
  {
    [Token(Token = "0x400314A")]
    [FieldOffset(Offset = "0x10")]
    private DebugLoginBonusBehaviour loginBonusBehaviour;
    [Token(Token = "0x400314B")]
    [FieldOffset(Offset = "0x18")]
    private ItemUtility.Parameter parameter;

    [Token(Token = "0x140000EA")]
    private event Action OnClickClose
    {
      [Token(Token = "0x6003D0D"), Address(RVA = "0x2C095E0", Offset = "0x2C095E0", VA = "0x2C095E0")] add
      {
      }
      [Token(Token = "0x6003D0E"), Address(RVA = "0x2C0967C", Offset = "0x2C0967C", VA = "0x2C0967C")] remove
      {
      }
    }

    [Token(Token = "0x6003D0F")]
    [Address(RVA = "0x2C09718", Offset = "0x2C09718", VA = "0x2C09718")]
    public void Initialize(ItemUtility.Parameter parameter, Action onClickClose)
    {
    }

    [Token(Token = "0x6003D10")]
    [Address(RVA = "0x2C097CC", Offset = "0x2C097CC", VA = "0x2C097CC")]
    public void Release()
    {
    }

    [Token(Token = "0x6003D11")]
    [Address(RVA = "0x2C09870", Offset = "0x2C09870", VA = "0x2C09870")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x6003D12")]
    [Address(RVA = "0x2C09E68", Offset = "0x2C09E68", VA = "0x2C09E68")]
    public DebugItemDetail()
    {
    }
  }
}
