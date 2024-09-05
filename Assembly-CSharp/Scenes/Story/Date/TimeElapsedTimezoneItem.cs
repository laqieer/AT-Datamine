// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Date.TimeElapsedTimezoneItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.Common;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Date
{
  [Token(Token = "0x2002EB4")]
  public class TimeElapsedTimezoneItem : MonoBehaviour
  {
    [Token(Token = "0x400C831")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C832")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400C833")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Animator animator;
    [Token(Token = "0x400C834")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string weatherIconName;
    [Token(Token = "0x400C835")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private WeatherIcon weatherIcon;
    [Token(Token = "0x400C836")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string mainTextName;
    [Token(Token = "0x400C837")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string subTextName;
    [Token(Token = "0x400C838")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string glowTextName;
    [Token(Token = "0x400C839")]
    [FieldOffset(Offset = "0x58")]
    [Header("メイン表示テキスト")]
    [SerializeField]
    private TextAccessor mainText;
    [Token(Token = "0x400C83A")]
    [FieldOffset(Offset = "0x60")]
    [Header("サブ表示テキスト")]
    [SerializeField]
    private TextAccessor subText;
    [Token(Token = "0x400C83B")]
    [FieldOffset(Offset = "0x68")]
    [Header("メインの縁取り表示テキスト")]
    [SerializeField]
    private TextAccessor glowText;

    [Token(Token = "0x17003DE1")]
    public Animator Animator
    {
      [Token(Token = "0x60123A4"), Address(RVA = "0x459830C", Offset = "0x459830C", VA = "0x459830C")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x17003DE2")]
    public WeatherIcon WeatherIcon
    {
      [Token(Token = "0x60123A5"), Address(RVA = "0x4598314", Offset = "0x4598314", VA = "0x4598314")] get
      {
        return (WeatherIcon) null;
      }
    }

    [Token(Token = "0x60123A6")]
    [Address(RVA = "0x45969BC", Offset = "0x45969BC", VA = "0x45969BC")]
    public void SetAlpha(float alpha)
    {
    }

    [Token(Token = "0x60123A7")]
    [Address(RVA = "0x4596A30", Offset = "0x4596A30", VA = "0x4596A30")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x60123A8")]
    [Address(RVA = "0x4596A70", Offset = "0x4596A70", VA = "0x4596A70")]
    public void SetUnderText(string text)
    {
    }

    [Token(Token = "0x60123A9")]
    [Address(RVA = "0x459831C", Offset = "0x459831C", VA = "0x459831C")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x60123AA")]
    [Address(RVA = "0x45985C4", Offset = "0x45985C4", VA = "0x45985C4")]
    public TimeElapsedTimezoneItem()
    {
    }
  }
}
