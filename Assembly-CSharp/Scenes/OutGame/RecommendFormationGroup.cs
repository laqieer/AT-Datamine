// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.RecommendFormationGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200325A")]
  internal class RecommendFormationGroup : MonoBehaviour
  {
    [Token(Token = "0x400D774")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TypeIcon typeIcon;
    [Token(Token = "0x400D775")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text elementText;

    [Token(Token = "0x6013A45")]
    [Address(RVA = "0x460B1E0", Offset = "0x460B1E0", VA = "0x460B1E0")]
    public void SetRecommendFormation(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x6013A46")]
    [Address(RVA = "0x461A10C", Offset = "0x461A10C", VA = "0x461A10C")]
    public RecommendFormationGroup()
    {
    }
  }
}
