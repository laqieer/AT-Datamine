// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000452")]
  [Serializable]
  public class ItemIcon
  {
    [Token(Token = "0x40017E2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image itemIcon;
    [Token(Token = "0x40017E3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI countNum;

    [Token(Token = "0x6001890")]
    [Address(RVA = "0x24908E0", Offset = "0x24908E0", VA = "0x24908E0")]
    public void Set(Sprite iconImg, int count)
    {
    }

    [Token(Token = "0x6001891")]
    [Address(RVA = "0x2491380", Offset = "0x2491380", VA = "0x2491380")]
    public ItemIcon()
    {
    }
  }
}
