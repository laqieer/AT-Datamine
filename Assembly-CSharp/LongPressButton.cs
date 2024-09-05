// Decompiled with JetBrains decompiler
// Type: LongPressButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000216")]
[AddComponentMenu("UI/Long Press Button", 32)]
[RequireComponent(typeof (Image))]
public class LongPressButton : CommonButton
{
  [Token(Token = "0x4000C85")]
  [FieldOffset(Offset = "0x17C")]
  [SerializeField]
  private ButtonLongPressSETypeEnum m_buttonLongPressSEType;
  [Token(Token = "0x4000C86")]
  [FieldOffset(Offset = "0x180")]
  [SerializeField]
  private string m_buttonLongPressSEName;
  [Token(Token = "0x4000C87")]
  [FieldOffset(Offset = "0x188")]
  [SerializeField]
  private LongPressButton.LongPressEvent m_onLongPress;
  [Token(Token = "0x4000C88")]
  [FieldOffset(Offset = "0x190")]
  [SerializeField]
  private LongPressButton.LongPressEvent m_onLongPressing;
  [Token(Token = "0x4000C89")]
  [FieldOffset(Offset = "0x198")]
  [SerializeField]
  private float m_longPressTimeThreshold;
  [Token(Token = "0x4000C8A")]
  [FieldOffset(Offset = "0x19C")]
  private float? pointerDownTime;
  [Token(Token = "0x4000C8B")]
  [FieldOffset(Offset = "0x1A4")]
  private bool isOnLongPressInvoked;

  [Token(Token = "0x17000114")]
  public ButtonLongPressSETypeEnum buttonLongPressSEType
  {
    [Token(Token = "0x6000D2E"), Address(RVA = "0x1C84A6C", Offset = "0x1C84A6C", VA = "0x1C84A6C")] get
    {
      return new ButtonLongPressSETypeEnum();
    }
  }

  [Token(Token = "0x17000115")]
  public string buttonLongPressSEName
  {
    [Token(Token = "0x6000D2F"), Address(RVA = "0x1C84A74", Offset = "0x1C84A74", VA = "0x1C84A74")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000116")]
  public LongPressButton.LongPressEvent onLongPress
  {
    [Token(Token = "0x6000D30"), Address(RVA = "0x1C84A7C", Offset = "0x1C84A7C", VA = "0x1C84A7C")] get
    {
      return (LongPressButton.LongPressEvent) null;
    }
    [Token(Token = "0x6000D31"), Address(RVA = "0x1C84A84", Offset = "0x1C84A84", VA = "0x1C84A84")] set
    {
    }
  }

  [Token(Token = "0x17000117")]
  public LongPressButton.LongPressEvent onLongPressing
  {
    [Token(Token = "0x6000D32"), Address(RVA = "0x1C84A8C", Offset = "0x1C84A8C", VA = "0x1C84A8C")] get
    {
      return (LongPressButton.LongPressEvent) null;
    }
    [Token(Token = "0x6000D33"), Address(RVA = "0x1C84A94", Offset = "0x1C84A94", VA = "0x1C84A94")] set
    {
    }
  }

  [Token(Token = "0x17000118")]
  public float longPressTimeThreshold
  {
    [Token(Token = "0x6000D34"), Address(RVA = "0x1C84A9C", Offset = "0x1C84A9C", VA = "0x1C84A9C")] get
    {
      return new float();
    }
    [Token(Token = "0x6000D35"), Address(RVA = "0x1C84AA4", Offset = "0x1C84AA4", VA = "0x1C84AA4")] set
    {
    }
  }

  [Token(Token = "0x6000D36")]
  [Address(RVA = "0x1C84AAC", Offset = "0x1C84AAC", VA = "0x1C84AAC", Slot = "43")]
  protected override void Update()
  {
  }

  [Token(Token = "0x6000D37")]
  [Address(RVA = "0x1C84D18", Offset = "0x1C84D18", VA = "0x1C84D18", Slot = "5")]
  protected override void OnEnable()
  {
  }

  [Token(Token = "0x6000D38")]
  [Address(RVA = "0x1C84D4C", Offset = "0x1C84D4C", VA = "0x1C84D4C", Slot = "7")]
  protected override void OnDisable()
  {
  }

  [Token(Token = "0x6000D39")]
  [Address(RVA = "0x1C84D3C", Offset = "0x1C84D3C", VA = "0x1C84D3C")]
  private void ResetLongPressStatus()
  {
  }

  [Token(Token = "0x6000D3A")]
  [Address(RVA = "0x1C84C10", Offset = "0x1C84C10", VA = "0x1C84C10")]
  private bool IsAvailable() => new bool();

  [Token(Token = "0x6000D3B")]
  [Address(RVA = "0x1C84D70", Offset = "0x1C84D70", VA = "0x1C84D70", Slot = "41")]
  public override void OnPointerClick(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D3C")]
  [Address(RVA = "0x1C84DAC", Offset = "0x1C84DAC", VA = "0x1C84DAC", Slot = "32")]
  public override void OnPointerDown(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D3D")]
  [Address(RVA = "0x1C84E90", Offset = "0x1C84E90", VA = "0x1C84E90", Slot = "33")]
  public override void OnPointerUp(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D3E")]
  [Address(RVA = "0x1C84ECC", Offset = "0x1C84ECC", VA = "0x1C84ECC", Slot = "35")]
  public override void OnPointerExit(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D3F")]
  [Address(RVA = "0x1C84F0C", Offset = "0x1C84F0C", VA = "0x1C84F0C")]
  public LongPressButton()
  {
  }

  [Token(Token = "0x2000217")]
  [Serializable]
  public class LongPressEvent : UnityEvent
  {
    [Token(Token = "0x6000D40")]
    [Address(RVA = "0x1C84F98", Offset = "0x1C84F98", VA = "0x1C84F98")]
    public LongPressEvent()
    {
    }
  }
}
