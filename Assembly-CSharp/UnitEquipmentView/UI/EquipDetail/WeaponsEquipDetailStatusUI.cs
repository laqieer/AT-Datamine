// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipDetail.WeaponsEquipDetailStatusUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitEquipmentView.UI.EquipDetail
{
  [Token(Token = "0x2000462")]
  public class WeaponsEquipDetailStatusUI : MonoBehaviour
  {
    [Token(Token = "0x400180E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text parameterName;
    [Token(Token = "0x400180F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text valueText;

    [Token(Token = "0x60018D5")]
    [Address(RVA = "0x24932D0", Offset = "0x24932D0", VA = "0x24932D0")]
    public void Set(string name, int value)
    {
    }

    [Token(Token = "0x60018D6")]
    [Address(RVA = "0x2493334", Offset = "0x2493334", VA = "0x2493334")]
    public WeaponsEquipDetailStatusUI()
    {
    }
  }
}
