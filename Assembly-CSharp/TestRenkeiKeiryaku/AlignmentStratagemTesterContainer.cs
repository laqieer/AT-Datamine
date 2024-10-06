// Decompiled with JetBrains decompiler
// Type: TestRenkeiKeiryaku.AlignmentStratagemTesterContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TestRenkeiKeiryaku
{
  [Token(Token = "0x2000776")]
  public class AlignmentStratagemTesterContainer : MonoBehaviour
  {
    [Token(Token = "0x400220D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject rootObject;
    [Token(Token = "0x400220E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle viewToggle;
    [Token(Token = "0x400220F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Slider personNumberSlider;
    [Token(Token = "0x4002210")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI rangeText;
    [Token(Token = "0x4002211")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<TMP_InputField> unitIdsInputField;
    [Token(Token = "0x4002212")]
    [FieldOffset(Offset = "0x40")]
    private List<int> styleIds;

    [Token(Token = "0x17000641")]
    public bool IsView
    {
      [Token(Token = "0x6002999"), Address(RVA = "0x34F70C0", Offset = "0x34F70C0", VA = "0x34F70C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000642")]
    public int PersonNumber
    {
      [Token(Token = "0x600299A"), Address(RVA = "0x34F70DC", Offset = "0x34F70DC", VA = "0x34F70DC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000643")]
    public List<int> StyleIds
    {
      [Token(Token = "0x600299B"), Address(RVA = "0x34F711C", Offset = "0x34F711C", VA = "0x34F711C")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600299C")]
    [Address(RVA = "0x34F7254", Offset = "0x34F7254", VA = "0x34F7254")]
    private void Start()
    {
    }

    [Token(Token = "0x600299D")]
    [Address(RVA = "0x34F781C", Offset = "0x34F781C", VA = "0x34F781C")]
    private void UpdateViewToggle(bool value)
    {
    }

    [Token(Token = "0x600299E")]
    [Address(RVA = "0x34F7710", Offset = "0x34F7710", VA = "0x34F7710")]
    private void UpdateCharaCountLabel(float value)
    {
    }

    [Token(Token = "0x600299F")]
    [Address(RVA = "0x34F783C", Offset = "0x34F783C", VA = "0x34F783C")]
    private void UpdateInputFieldEvent_Unit1(string value)
    {
    }

    [Token(Token = "0x60029A0")]
    [Address(RVA = "0x34F7A30", Offset = "0x34F7A30", VA = "0x34F7A30")]
    private void UpdateInputFieldEvent_Unit2(string value)
    {
    }

    [Token(Token = "0x60029A1")]
    [Address(RVA = "0x34F7A3C", Offset = "0x34F7A3C", VA = "0x34F7A3C")]
    private void UpdateInputFieldEvent_Unit3(string value)
    {
    }

    [Token(Token = "0x60029A2")]
    [Address(RVA = "0x34F7A48", Offset = "0x34F7A48", VA = "0x34F7A48")]
    private void UpdateInputFieldEvent_Unit4(string value)
    {
    }

    [Token(Token = "0x60029A3")]
    [Address(RVA = "0x34F7848", Offset = "0x34F7848", VA = "0x34F7848")]
    private void UpdateInputFieldEvent(int index, string value)
    {
    }

    [Token(Token = "0x60029A4")]
    [Address(RVA = "0x34F7A54", Offset = "0x34F7A54", VA = "0x34F7A54")]
    public AlignmentStratagemTesterContainer()
    {
    }
  }
}
