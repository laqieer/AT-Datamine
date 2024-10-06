// Decompiled with JetBrains decompiler
// Type: Gacha.GachaScheduleView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001598")]
  internal class GachaScheduleView : MonoBehaviour
  {
    [Token(Token = "0x400630C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject rootObject;
    [Token(Token = "0x400630D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor textSchedule;
    [Token(Token = "0x400630E")]
    [FieldOffset(Offset = "0x28")]
    private GachaScheduleView.CountDownTimer countDownTimer;
    [Token(Token = "0x400630F")]
    [FieldOffset(Offset = "0x30")]
    private RectTransform syncTransformTarget;

    [Token(Token = "0x6007A6A")]
    [Address(RVA = "0x2297A10", Offset = "0x2297A10", VA = "0x2297A10")]
    public void SetScheduleText(DateTime beginAt, DateTime endAt)
    {
    }

    [Token(Token = "0x6007A6B")]
    [Address(RVA = "0x229C884", Offset = "0x229C884", VA = "0x229C884")]
    public void SetRemainingCountDown(DateTime endTime)
    {
    }

    [Token(Token = "0x6007A6C")]
    [Address(RVA = "0x229CA14", Offset = "0x229CA14", VA = "0x229CA14")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6007A6D")]
    [Address(RVA = "0x229CA34", Offset = "0x229CA34", VA = "0x229CA34")]
    public void SetRemainingTime(TimeSpan timeSpan)
    {
    }

    [Token(Token = "0x6007A6E")]
    [Address(RVA = "0x229CB14", Offset = "0x229CB14", VA = "0x229CB14")]
    private void Update()
    {
    }

    [Token(Token = "0x6007A6F")]
    [Address(RVA = "0x229CB24", Offset = "0x229CB24", VA = "0x229CB24")]
    public void SetTransformSync(RectTransform rectTransform)
    {
    }

    [Token(Token = "0x6007A70")]
    [Address(RVA = "0x229CB2C", Offset = "0x229CB2C", VA = "0x229CB2C")]
    public void SyncTransform()
    {
    }

    [Token(Token = "0x6007A71")]
    [Address(RVA = "0x229CC18", Offset = "0x229CC18", VA = "0x229CC18")]
    public GachaScheduleView()
    {
    }

    [Token(Token = "0x2001599")]
    private class CountDownTimer
    {
      [Token(Token = "0x4006310")]
      [FieldOffset(Offset = "0x10")]
      private DateTime EndAt;
      [Token(Token = "0x4006311")]
      [FieldOffset(Offset = "0x18")]
      public Action<TimeSpan> ValueChanged;

      [Token(Token = "0x170012C7")]
      private DateTime Now
      {
        [Token(Token = "0x6007A72"), Address(RVA = "0x229CC20", Offset = "0x229CC20", VA = "0x229CC20")] get
        {
          return new DateTime();
        }
      }

      [Token(Token = "0x6007A73")]
      [Address(RVA = "0x229C958", Offset = "0x229C958", VA = "0x229C958")]
      public CountDownTimer(DateTime endAt)
      {
      }

      [Token(Token = "0x6007A74")]
      [Address(RVA = "0x229C980", Offset = "0x229C980", VA = "0x229C980")]
      public void Update()
      {
      }
    }
  }
}
