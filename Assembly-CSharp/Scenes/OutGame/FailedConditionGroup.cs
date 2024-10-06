// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.FailedConditionGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200321B")]
  internal class FailedConditionGroup : MonoBehaviour
  {
    [Token(Token = "0x400D602")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text conditionText;

    [Token(Token = "0x60138B9")]
    [Address(RVA = "0x49C4AC8", Offset = "0x49C4AC8", VA = "0x49C4AC8")]
    public void SetFailedCondition(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x60138BA")]
    [Address(RVA = "0x49C4BB8", Offset = "0x49C4BB8", VA = "0x49C4BB8")]
    public FailedConditionGroup()
    {
    }
  }
}
