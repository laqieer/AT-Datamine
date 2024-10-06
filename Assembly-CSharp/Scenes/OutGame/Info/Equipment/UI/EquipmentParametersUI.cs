// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentParametersUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035B2")]
  public class EquipmentParametersUI : MonoBehaviour
  {
    [Token(Token = "0x400E9A1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ParameterValueTypeNumeric typeNumeric;
    [Token(Token = "0x400E9A2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ParameterValueTypeRange typeRange;

    [Token(Token = "0x6015226")]
    [Address(RVA = "0x4AAD454", Offset = "0x4AAD454", VA = "0x4AAD454")]
    public ParameterValueTypeNumeric CreateNumericInstance() => (ParameterValueTypeNumeric) null;

    [Token(Token = "0x6015227")]
    [Address(RVA = "0x4AAD4E4", Offset = "0x4AAD4E4", VA = "0x4AAD4E4")]
    public ParameterValueTypeRange CreateRangeInstance() => (ParameterValueTypeRange) null;

    [Token(Token = "0x6015228")]
    [Address(RVA = "0x4AAD574", Offset = "0x4AAD574", VA = "0x4AAD574")]
    public EquipmentParametersUI()
    {
    }
  }
}
