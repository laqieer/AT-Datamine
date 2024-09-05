// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaSettingsListItemButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003130")]
  public class ArenaSettingsListItemButton : MonoBehaviour
  {
    [Token(Token = "0x400D177")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject onObj;
    [Token(Token = "0x400D178")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject offObj;
    [Token(Token = "0x400D179")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400D17A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int value;

    [Token(Token = "0x17004049")]
    public int Value
    {
      [Token(Token = "0x6013325"), Address(RVA = "0x45E6930", Offset = "0x45E6930", VA = "0x45E6930")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700404A")]
    public bool ActiveSelf
    {
      [Token(Token = "0x6013326"), Address(RVA = "0x45E6738", Offset = "0x45E6738", VA = "0x45E6738")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6013327")]
    [Address(RVA = "0x45E6860", Offset = "0x45E6860", VA = "0x45E6860")]
    public void Initialize(Action onClickAny)
    {
    }

    [Token(Token = "0x6013328")]
    [Address(RVA = "0x45E676C", Offset = "0x45E676C", VA = "0x45E676C")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6013329")]
    [Address(RVA = "0x45E6940", Offset = "0x45E6940", VA = "0x45E6940")]
    public ArenaSettingsListItemButton()
    {
    }
  }
}
