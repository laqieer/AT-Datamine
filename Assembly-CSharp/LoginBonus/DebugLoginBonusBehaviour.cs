// Decompiled with JetBrains decompiler
// Type: LoginBonus.DebugLoginBonusBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000ABA")]
  internal class DebugLoginBonusBehaviour : MonoBehaviour
  {
    [Token(Token = "0x140000E9")]
    private event Action OnDraw
    {
      [Token(Token = "0x6003D08"), Address(RVA = "0x2C09324", Offset = "0x2C09324", VA = "0x2C09324")] add
      {
      }
      [Token(Token = "0x6003D09"), Address(RVA = "0x2C093C0", Offset = "0x2C093C0", VA = "0x2C093C0")] remove
      {
      }
    }

    [Token(Token = "0x6003D0A")]
    [Address(RVA = "0x2C0945C", Offset = "0x2C0945C", VA = "0x2C0945C")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x6003D0B")]
    [Address(RVA = "0x2C09478", Offset = "0x2C09478", VA = "0x2C09478")]
    public static DebugLoginBonusBehaviour CreateNewInstance(string name, Action onDraw)
    {
      return (DebugLoginBonusBehaviour) null;
    }

    [Token(Token = "0x6003D0C")]
    [Address(RVA = "0x2C095D8", Offset = "0x2C095D8", VA = "0x2C095D8")]
    public DebugLoginBonusBehaviour()
    {
    }
  }
}
