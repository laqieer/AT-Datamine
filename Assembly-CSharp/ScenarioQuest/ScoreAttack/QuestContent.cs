// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.QuestContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200083D")]
  public class QuestContent : MonoBehaviour
  {
    [Token(Token = "0x400273F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI title;
    [Token(Token = "0x4002740")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject lockIcon;

    [Token(Token = "0x6002F5D")]
    [Address(RVA = "0x3E6EE88", Offset = "0x3E6EE88", VA = "0x3E6EE88")]
    public void Set(string name, int id)
    {
    }

    [Token(Token = "0x6002F5E")]
    [Address(RVA = "0x3E6EEC8", Offset = "0x3E6EEC8", VA = "0x3E6EEC8")]
    public void SetTitle(string name)
    {
    }

    [Token(Token = "0x6002F5F")]
    [Address(RVA = "0x3E6EEEC", Offset = "0x3E6EEEC", VA = "0x3E6EEEC")]
    private void SetLockIcon(int selectedQuestId)
    {
    }

    [Token(Token = "0x6002F60")]
    [Address(RVA = "0x3E6EF58", Offset = "0x3E6EF58", VA = "0x3E6EF58")]
    public QuestContent()
    {
    }
  }
}
