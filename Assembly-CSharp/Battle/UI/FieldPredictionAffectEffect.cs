// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldPredictionAffectEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Logic.Prediction;
using Il2CppDummyDll;
using UI.Utilities.SerializeUI;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023EF")]
  public class FieldPredictionAffectEffect : MonoBehaviour
  {
    [Token(Token = "0x4009975")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageContainer iconImage;
    [Token(Token = "0x4009976")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextContainer probability;
    [Token(Token = "0x4009977")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject cureBadge;

    [Token(Token = "0x600DC27")]
    [Address(RVA = "0x2154C3C", Offset = "0x2154C3C", VA = "0x2154C3C")]
    public void Set(PredictionUnitResult.EffectIcon effectIcon)
    {
    }

    [Token(Token = "0x600DC28")]
    [Address(RVA = "0x2154DA4", Offset = "0x2154DA4", VA = "0x2154DA4")]
    private Sprite GetBattleIcon(PredictionUnitResult.EffectIcon effectIcon) => (Sprite) null;

    [Token(Token = "0x600DC29")]
    [Address(RVA = "0x2154EA0", Offset = "0x2154EA0", VA = "0x2154EA0")]
    public FieldPredictionAffectEffect()
    {
    }
  }
}
