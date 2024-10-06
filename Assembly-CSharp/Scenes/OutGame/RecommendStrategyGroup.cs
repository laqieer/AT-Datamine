// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.RecommendStrategyGroup
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
  [Token(Token = "0x200325B")]
  internal class RecommendStrategyGroup : MonoBehaviour
  {
    [Token(Token = "0x400D776")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text guideText;

    [Token(Token = "0x6013A47")]
    [Address(RVA = "0x460B394", Offset = "0x460B394", VA = "0x460B394")]
    public void SetRecommendStrategy(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x6013A48")]
    [Address(RVA = "0x461A114", Offset = "0x461A114", VA = "0x461A114")]
    public RecommendStrategyGroup()
    {
    }
  }
}
