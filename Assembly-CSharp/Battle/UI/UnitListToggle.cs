// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitListToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002346")]
  [Serializable]
  public sealed class UnitListToggle
  {
    [Token(Token = "0x40095BF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text toggleText;
    [Token(Token = "0x40095C0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonToggle toggle;
    [Token(Token = "0x40095C1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Color offTextColor;
    [Token(Token = "0x40095C2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Color onTextColor;

    [Token(Token = "0x17002E69")]
    public Toggle Toggle
    {
      [Token(Token = "0x600D795"), Address(RVA = "0x1B882BC", Offset = "0x1B882BC", VA = "0x1B882BC")] get
      {
        return (Toggle) null;
      }
    }

    [Token(Token = "0x600D796")]
    [Address(RVA = "0x1B882C4", Offset = "0x1B882C4", VA = "0x1B882C4")]
    public void Initialize(UnityAction<bool> userListener = null)
    {
    }

    [Token(Token = "0x600D797")]
    [Address(RVA = "0x1B883C0", Offset = "0x1B883C0", VA = "0x1B883C0")]
    private void OnChangedValue(bool isOn)
    {
    }

    [Token(Token = "0x600D798")]
    [Address(RVA = "0x1B88424", Offset = "0x1B88424", VA = "0x1B88424")]
    public UnitListToggle()
    {
    }
  }
}
