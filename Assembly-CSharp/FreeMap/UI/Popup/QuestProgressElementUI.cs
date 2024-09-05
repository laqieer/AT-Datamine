// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestProgressElementUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x200163C")]
  public class QuestProgressElementUI : MonoBehaviour
  {
    [Token(Token = "0x40064F1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform checkOff;
    [Token(Token = "0x40064F2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform checkOn;
    [Token(Token = "0x40064F3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextAccessor text;
    [Token(Token = "0x40064F4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform countRoot;
    [Token(Token = "0x40064F5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextAccessor current;
    [Token(Token = "0x40064F6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextAccessor max;
    [Token(Token = "0x40064F7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private HorizontalLayoutGroup horizontalLayoutGroup;

    [Token(Token = "0x6007E1B")]
    [Address(RVA = "0x21A8828", Offset = "0x21A8828", VA = "0x21A8828")]
    public void Check(bool check)
    {
    }

    [Token(Token = "0x6007E1C")]
    [Address(RVA = "0x21A88F0", Offset = "0x21A88F0", VA = "0x21A88F0")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x6007E1D")]
    [Address(RVA = "0x21A890C", Offset = "0x21A890C", VA = "0x21A890C")]
    public void SetActiveCount(bool active)
    {
    }

    [Token(Token = "0x6007E1E")]
    [Address(RVA = "0x21A8888", Offset = "0x21A8888", VA = "0x21A8888")]
    public void SetCount(int current, int max)
    {
    }

    [Token(Token = "0x6007E1F")]
    [Address(RVA = "0x21AD248", Offset = "0x21AD248", VA = "0x21AD248")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x6007E20")]
    [Address(RVA = "0x21AD298", Offset = "0x21AD298", VA = "0x21AD298")]
    public QuestProgressElementUI()
    {
    }
  }
}
