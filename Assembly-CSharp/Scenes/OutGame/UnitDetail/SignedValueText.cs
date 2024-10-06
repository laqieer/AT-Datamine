// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.SignedValueText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using TMPro;
using Tween.Tweeners;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail
{
  [Token(Token = "0x20032D1")]
  public class SignedValueText : MonoBehaviour
  {
    [Token(Token = "0x400DB17")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI signedValueText;
    [Token(Token = "0x400DB18")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TweenColor normalTween;
    [Token(Token = "0x400DB19")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TweenColor plusTween;
    [Token(Token = "0x400DB1A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TweenColor minusTween;

    [Token(Token = "0x6013F68")]
    [Address(RVA = "0x23436C8", Offset = "0x23436C8", VA = "0x23436C8")]
    public void SetValue(int value)
    {
    }

    [Token(Token = "0x6013F69")]
    [Address(RVA = "0x2343B94", Offset = "0x2343B94", VA = "0x2343B94")]
    private IEnumerator SetDelayTween(TweenColor tween) => (IEnumerator) null;

    [Token(Token = "0x6013F6A")]
    [Address(RVA = "0x2343C24", Offset = "0x2343C24", VA = "0x2343C24")]
    public SignedValueText()
    {
    }
  }
}
