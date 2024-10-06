// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.TutorialSummaryButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200316D")]
  public class TutorialSummaryButton : MonoBehaviour
  {
    [Token(Token = "0x400D292")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI text;
    [Token(Token = "0x400D293")]
    [FieldOffset(Offset = "0x20")]
    public int tutorialId;

    [Token(Token = "0x60134A8")]
    [Address(RVA = "0x4A2BCE8", Offset = "0x4A2BCE8", VA = "0x4A2BCE8")]
    public void ButtonTextSet(string text)
    {
    }

    [Token(Token = "0x60134A9")]
    [Address(RVA = "0x4A2BD0C", Offset = "0x4A2BD0C", VA = "0x4A2BD0C")]
    public void TutorialButton()
    {
    }

    [Token(Token = "0x60134AA")]
    [Address(RVA = "0x4A2BD94", Offset = "0x4A2BD94", VA = "0x4A2BD94")]
    public TutorialSummaryButton()
    {
    }
  }
}
