// Decompiled with JetBrains decompiler
// Type: SliderHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002E1")]
public class SliderHelper : MonoBehaviour, IPointerUpHandler, IEventSystemHandler
{
  [Token(Token = "0x40010B2")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Slider slider;

  [Token(Token = "0x170001CC")]
  public Action<float> OnUpAction
  {
    [Token(Token = "0x6001203"), Address(RVA = "0x27DB434", Offset = "0x27DB434", VA = "0x27DB434")] get
    {
      return (Action<float>) null;
    }
    [Token(Token = "0x6001204"), Address(RVA = "0x27DB43C", Offset = "0x27DB43C", VA = "0x27DB43C")] set
    {
    }
  }

  [Token(Token = "0x6001205")]
  [Address(RVA = "0x27DB444", Offset = "0x27DB444", VA = "0x27DB444", Slot = "4")]
  public void OnPointerUp(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6001206")]
  [Address(RVA = "0x27DB488", Offset = "0x27DB488", VA = "0x27DB488")]
  public SliderHelper()
  {
  }
}
