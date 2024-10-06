// Decompiled with JetBrains decompiler
// Type: Battle.UI.OperationTextView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002300")]
  public class OperationTextView : MonoBehaviour
  {
    [Token(Token = "0x400941B")]
    [FieldOffset(Offset = "0x18")]
    [Header("Tween")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400941C")]
    [FieldOffset(Offset = "0x20")]
    [Header("Text")]
    [SerializeField]
    private TextMeshProUGUI text;
    [Token(Token = "0x400941D")]
    private const string OpenTween = "Info_Title_In";
    [Token(Token = "0x400941E")]
    private const string CloseTween = "Info_Title_Out";

    [Token(Token = "0x600D5EE")]
    [Address(RVA = "0x1D193E4", Offset = "0x1D193E4", VA = "0x1D193E4")]
    public void Open(string str)
    {
    }

    [Token(Token = "0x600D5EF")]
    [Address(RVA = "0x1D1948C", Offset = "0x1D1948C", VA = "0x1D1948C")]
    public void Close()
    {
    }

    [Token(Token = "0x600D5F0")]
    [Address(RVA = "0x1D19894", Offset = "0x1D19894", VA = "0x1D19894")]
    public OperationTextView()
    {
    }
  }
}
