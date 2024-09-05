// Decompiled with JetBrains decompiler
// Type: Story.Tracker.UI.TrackerSubSectionElementUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Story.Tracker.UI
{
  [Token(Token = "0x20005D9")]
  public class TrackerSubSectionElementUI : MonoBehaviour
  {
    [Token(Token = "0x4001D25")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI text;
    [Token(Token = "0x4001D26")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform numberRoot;
    [Token(Token = "0x4001D27")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI current;
    [Token(Token = "0x4001D28")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI max;

    [Token(Token = "0x60021D7")]
    [Address(RVA = "0x2D9CCCC", Offset = "0x2D9CCCC", VA = "0x2D9CCCC")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x60021D8")]
    [Address(RVA = "0x2D9CCF0", Offset = "0x2D9CCF0", VA = "0x2D9CCF0")]
    public void ProgressActive(bool active)
    {
    }

    [Token(Token = "0x60021D9")]
    [Address(RVA = "0x2D9CD20", Offset = "0x2D9CD20", VA = "0x2D9CD20")]
    public void SetProgressValue(int current, int max)
    {
    }

    [Token(Token = "0x60021DA")]
    [Address(RVA = "0x2D9CD98", Offset = "0x2D9CD98", VA = "0x2D9CD98")]
    public TrackerSubSectionElementUI()
    {
    }
  }
}
