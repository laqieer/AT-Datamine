// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.ParameterValueTypeNumericText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035F0")]
  public class ParameterValueTypeNumericText : ParameterValueTypeNumeric
  {
    [Token(Token = "0x400EA98")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400EA99")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor value;

    [Token(Token = "0x60153B7")]
    [Address(RVA = "0x4D8D84C", Offset = "0x4D8D84C", VA = "0x4D8D84C", Slot = "4")]
    public override void Set(string title, string value)
    {
    }

    [Token(Token = "0x60153B8")]
    [Address(RVA = "0x4D8D88C", Offset = "0x4D8D88C", VA = "0x4D8D88C")]
    public ParameterValueTypeNumericText()
    {
    }
  }
}
