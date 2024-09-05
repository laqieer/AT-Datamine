// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestDetailCaptureInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200322D")]
  internal class QuestDetailCaptureInfo : MonoBehaviour
  {
    [Token(Token = "0x400D658")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RecommendFormationGroup recommendFormationGroup;
    [Token(Token = "0x400D659")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RecommendStrategyGroup strategyGroup;

    [Token(Token = "0x601391E")]
    [Address(RVA = "0x460B1A8", Offset = "0x460B1A8", VA = "0x460B1A8")]
    public void SetData(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x601391F")]
    [Address(RVA = "0x460B464", Offset = "0x460B464", VA = "0x460B464")]
    public QuestDetailCaptureInfo()
    {
    }
  }
}
