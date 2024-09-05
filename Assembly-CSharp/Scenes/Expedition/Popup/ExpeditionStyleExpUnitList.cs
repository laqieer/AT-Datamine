// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ExpeditionStyleExpUnitList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Expedition.Main;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C8D")]
  public class ExpeditionStyleExpUnitList : MonoBehaviour
  {
    [Token(Token = "0x400BE00")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ExpeditionStyleExpUnitSlot[] unitSlots;

    [Token(Token = "0x17003C0D")]
    public int SlotNum
    {
      [Token(Token = "0x60116E8"), Address(RVA = "0x4E20E24", Offset = "0x4E20E24", VA = "0x4E20E24")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60116E9")]
    [Address(RVA = "0x4E24D20", Offset = "0x4E24D20", VA = "0x4E24D20")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60116EA")]
    [Address(RVA = "0x4E20DC0", Offset = "0x4E20DC0", VA = "0x4E20DC0")]
    public void UpdateView(
      int index,
      Style style,
      ExpeditionOrganization.ExpeditionOldStyle oldData,
      bool isLevelUp,
      bool isLock,
      Action<Style> onLevelUpStyleAction)
    {
    }

    [Token(Token = "0x60116EB")]
    [Address(RVA = "0x4E20D4C", Offset = "0x4E20D4C", VA = "0x4E20D4C")]
    public void UpdateViewLockParty()
    {
    }

    [Token(Token = "0x60116EC")]
    [Address(RVA = "0x4E218F8", Offset = "0x4E218F8", VA = "0x4E218F8")]
    public void ShowLevelUpEffect()
    {
    }

    [Token(Token = "0x60116ED")]
    [Address(RVA = "0x4E24EA8", Offset = "0x4E24EA8", VA = "0x4E24EA8")]
    public ExpeditionStyleExpUnitList()
    {
    }
  }
}
