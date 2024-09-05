// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.AdditionalParameterElementUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035E4")]
  public class AdditionalParameterElementUI : MonoBehaviour
  {
    [Token(Token = "0x400EA77")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400EA78")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor value;
    [Token(Token = "0x400EA79")]
    [FieldOffset(Offset = "0x28")]
    [Header("0を表示するか")]
    [SerializeField]
    private bool displayZero;

    [Token(Token = "0x170046B3")]
    public bool DisplayZero
    {
      [Token(Token = "0x6015392"), Address(RVA = "0x4D8C4F8", Offset = "0x4D8C4F8", VA = "0x4D8C4F8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015393")]
    [Address(RVA = "0x4D86DC4", Offset = "0x4D86DC4", VA = "0x4D86DC4")]
    public void Set(string title, string value)
    {
    }

    [Token(Token = "0x6015394")]
    [Address(RVA = "0x4D8C500", Offset = "0x4D8C500", VA = "0x4D8C500")]
    public AdditionalParameterElementUI()
    {
    }
  }
}
