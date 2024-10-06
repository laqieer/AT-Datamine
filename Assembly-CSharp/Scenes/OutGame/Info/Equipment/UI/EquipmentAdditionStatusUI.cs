// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentAdditionStatusUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035AB")]
  [Serializable]
  public class EquipmentAdditionStatusUI
  {
    [Token(Token = "0x400E98B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public EquipmentPopupAdditionStatusValue additionStatusTitle;
    [Token(Token = "0x400E98C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public EquipmentPopupAdditionStatusValue additionStatusValue;
    [Token(Token = "0x400E98D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject nothingObj;

    [Token(Token = "0x6015205")]
    [Address(RVA = "0x4AACA7C", Offset = "0x4AACA7C", VA = "0x4AACA7C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015206")]
    [Address(RVA = "0x4AACACC", Offset = "0x4AACACC", VA = "0x4AACACC")]
    public void OnChange(StaqData.Equipment equipmentData)
    {
    }

    [Token(Token = "0x6015207")]
    [Address(RVA = "0x4AACC30", Offset = "0x4AACC30", VA = "0x4AACC30")]
    public void CreateTitle(string title)
    {
    }

    [Token(Token = "0x6015208")]
    [Address(RVA = "0x4AACD64", Offset = "0x4AACD64", VA = "0x4AACD64")]
    public void CreateValue(string title, int val)
    {
    }

    [Token(Token = "0x6015209")]
    [Address(RVA = "0x4AACEC0", Offset = "0x4AACEC0", VA = "0x4AACEC0")]
    public void SetIsVisibleNothing(bool isVisible)
    {
    }

    [Token(Token = "0x601520A")]
    [Address(RVA = "0x4AACEE0", Offset = "0x4AACEE0", VA = "0x4AACEE0")]
    public EquipmentAdditionStatusUI()
    {
    }
  }
}
