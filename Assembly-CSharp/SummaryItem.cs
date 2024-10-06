// Decompiled with JetBrains decompiler
// Type: SummaryItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002B3")]
public class SummaryItem : MonoBehaviour
{
  [Token(Token = "0x4000FED")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private GameObject Root;
  [Token(Token = "0x4000FEE")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private TextMeshProUGUI SummayTitleText;
  [Token(Token = "0x4000FEF")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private TextMeshProUGUI SummayMonthText;
  [Token(Token = "0x4000FF0")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private TextMeshProUGUI SummayDayText;
  [Token(Token = "0x4000FF1")]
  [FieldOffset(Offset = "0x38")]
  private bool isValidSummary;

  [Token(Token = "0x60010E7")]
  [Address(RVA = "0x1BEB73C", Offset = "0x1BEB73C", VA = "0x1BEB73C")]
  public void SetupSummary(int sequenceId = 0)
  {
  }

  [Token(Token = "0x60010E8")]
  [Address(RVA = "0x1BEB9AC", Offset = "0x1BEB9AC", VA = "0x1BEB9AC")]
  public void Show()
  {
  }

  [Token(Token = "0x60010E9")]
  [Address(RVA = "0x1BEB9DC", Offset = "0x1BEB9DC", VA = "0x1BEB9DC")]
  public void Hide()
  {
  }

  [Token(Token = "0x60010EA")]
  [Address(RVA = "0x1BEB9FC", Offset = "0x1BEB9FC", VA = "0x1BEB9FC")]
  public SummaryItem()
  {
  }
}
