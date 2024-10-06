// Decompiled with JetBrains decompiler
// Type: Scenes.Story.HeaderView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D7D")]
  public class HeaderView : MonoBehaviour
  {
    [Token(Token = "0x400C359")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public GameObject containerHeader;
    [Token(Token = "0x400C35A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public Image imageMonthNum1;
    [Token(Token = "0x400C35B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public Image imageMonthNum2;
    [Token(Token = "0x400C35C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public Image imageDayNum1;
    [Token(Token = "0x400C35D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public Image imageDayNum2;
    [Token(Token = "0x400C35E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public Image imageMonthNum1DS;
    [Token(Token = "0x400C35F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public Image imageMonthNum2DS;
    [Token(Token = "0x400C360")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public Image imageDayNum1DS;
    [Token(Token = "0x400C361")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public Image imageDayNum2DS;
    [Token(Token = "0x400C362")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public Image imageWeek;
    [Token(Token = "0x400C363")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public Image imageTimeZone;
    [Token(Token = "0x400C364")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public Sprite[] spriteNum;
    [Token(Token = "0x400C365")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public Sprite[] spriteWeek;
    [Token(Token = "0x400C366")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public Sprite[] spriteTimeZone;
    [Token(Token = "0x400C367")]
    [FieldOffset(Offset = "0x88")]
    private UIAnimationController animationController;
    [Token(Token = "0x400C368")]
    [FieldOffset(Offset = "0x90")]
    private Action callback;

    [Token(Token = "0x6011C86")]
    [Address(RVA = "0x3F9C674", Offset = "0x3F9C674", VA = "0x3F9C674")]
    private void Awake()
    {
    }

    [Token(Token = "0x6011C87")]
    [Address(RVA = "0x3F9C74C", Offset = "0x3F9C74C", VA = "0x3F9C74C")]
    private void Update()
    {
    }

    [Token(Token = "0x6011C88")]
    [Address(RVA = "0x3F9C760", Offset = "0x3F9C760", VA = "0x3F9C760")]
    public void StartHeader(string date, int timeZone, Action callback = null)
    {
    }

    [Token(Token = "0x6011C89")]
    [Address(RVA = "0x3F9CC18", Offset = "0x3F9CC18", VA = "0x3F9CC18")]
    public void EndHeader(Action callback = null)
    {
    }

    [Token(Token = "0x6011C8A")]
    [Address(RVA = "0x3F9CBB0", Offset = "0x3F9CBB0", VA = "0x3F9CBB0")]
    private IEnumerator StartFlow() => (IEnumerator) null;

    [Token(Token = "0x6011C8B")]
    [Address(RVA = "0x3F9CC3C", Offset = "0x3F9CC3C", VA = "0x3F9CC3C")]
    private IEnumerator EndFlow() => (IEnumerator) null;

    [Token(Token = "0x6011C8C")]
    [Address(RVA = "0x3F9CCF4", Offset = "0x3F9CCF4", VA = "0x3F9CCF4")]
    private IEnumerator WaitAnim(string anim) => (IEnumerator) null;

    [Token(Token = "0x6011C8D")]
    [Address(RVA = "0x3F9C80C", Offset = "0x3F9C80C", VA = "0x3F9C80C")]
    private void SetHeaderDraw(DateTime date, int timeZone)
    {
    }

    [Token(Token = "0x6011C8E")]
    [Address(RVA = "0x3F9CD90", Offset = "0x3F9CD90", VA = "0x3F9CD90")]
    public HeaderView()
    {
    }
  }
}
