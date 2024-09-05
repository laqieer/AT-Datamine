// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.CoverHealView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003728")]
  public class CoverHealView : MonoBehaviour
  {
    [Token(Token = "0x400F0E8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EventTrigger _healEventTrigger;
    [Token(Token = "0x400F0E9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private HealGaugeView _healGauge;
    [Token(Token = "0x400F0EA")]
    [FieldOffset(Offset = "0x28")]
    private UnityAction _onPressHealButton;
    [Token(Token = "0x400F0EB")]
    [FieldOffset(Offset = "0x30")]
    private UnityAction _onReleaseHealButton;

    [Token(Token = "0x6015BB8")]
    [Address(RVA = "0x1B22328", Offset = "0x1B22328", VA = "0x1B22328")]
    private void Awake()
    {
    }

    [Token(Token = "0x6015BB9")]
    [Address(RVA = "0x1B22588", Offset = "0x1B22588", VA = "0x1B22588")]
    public void SetHealButtonEvent(UnityAction onPressHealButton, UnityAction onReleaseHealButton)
    {
    }

    [Token(Token = "0x6015BBA")]
    [Address(RVA = "0x1B22590", Offset = "0x1B22590", VA = "0x1B22590")]
    public void SetHealGaugeValue(float value)
    {
    }

    [Token(Token = "0x6015BBB")]
    [Address(RVA = "0x1B225AC", Offset = "0x1B225AC", VA = "0x1B225AC")]
    public void SetHealGaugeActive(bool isActive)
    {
    }

    [Token(Token = "0x6015BBC")]
    [Address(RVA = "0x1B223F0", Offset = "0x1B223F0", VA = "0x1B223F0")]
    private void AddHealEventTrigger(EventTriggerType eventType, UnityAction callback)
    {
    }

    [Token(Token = "0x6015BBD")]
    [Address(RVA = "0x1B22674", Offset = "0x1B22674", VA = "0x1B22674")]
    public CoverHealView()
    {
    }
  }
}
