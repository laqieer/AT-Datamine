// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleConditionElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200237C")]
  public class BattleConditionElement : InfiniteCellBase
  {
    [Token(Token = "0x400971B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image icon;
    [Token(Token = "0x400971C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI effectNameText;
    [Token(Token = "0x400971D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI valueText;
    [Token(Token = "0x400971E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI lengthText;
    [Token(Token = "0x400971F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject disableObj;

    [Token(Token = "0x17002E99")]
    private StatusConditionModel Model
    {
      [Token(Token = "0x600D8BA"), Address(RVA = "0x1B98A6C", Offset = "0x1B98A6C", VA = "0x1B98A6C")] get
      {
        return (StatusConditionModel) null;
      }
    }

    [Token(Token = "0x600D8BB")]
    [Address(RVA = "0x1B98AF4", Offset = "0x1B98AF4", VA = "0x1B98AF4", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x600D8BC")]
    [Address(RVA = "0x1B98E7C", Offset = "0x1B98E7C", VA = "0x1B98E7C")]
    private void SetValue(int value)
    {
    }

    [Token(Token = "0x600D8BD")]
    [Address(RVA = "0x1B98F2C", Offset = "0x1B98F2C", VA = "0x1B98F2C")]
    private void SetPercentValue(int value)
    {
    }

    [Token(Token = "0x600D8BE")]
    [Address(RVA = "0x1B98E20", Offset = "0x1B98E20", VA = "0x1B98E20")]
    private void SetEmptyValue()
    {
    }

    [Token(Token = "0x600D8BF")]
    [Address(RVA = "0x1B9906C", Offset = "0x1B9906C", VA = "0x1B9906C")]
    public BattleConditionElement()
    {
    }
  }
}
