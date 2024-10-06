// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDetail.PararaBoostUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.BossList.BossDetail
{
  [Token(Token = "0x2002D3C")]
  public class PararaBoostUp : MonoBehaviour
  {
    [Token(Token = "0x400C1FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject[] boostUpObjs;

    [Token(Token = "0x6011AF7")]
    [Address(RVA = "0x42B0F6C", Offset = "0x42B0F6C", VA = "0x42B0F6C")]
    public void UpdatePararaBoost(ExpeditionBossDescriptionData bossData, Style style)
    {
    }

    [Token(Token = "0x6011AF8")]
    [Address(RVA = "0x42B14A0", Offset = "0x42B14A0", VA = "0x42B14A0")]
    public void UpdatePararaBoostIndividual(
      float parara,
      float pararaStageLimit,
      float pararaStyleLimit)
    {
    }

    [Token(Token = "0x6011AF9")]
    [Address(RVA = "0x42B11E4", Offset = "0x42B11E4", VA = "0x42B11E4")]
    public void PararaBoostOff()
    {
    }

    [Token(Token = "0x6011AFA")]
    [Address(RVA = "0x42B1700", Offset = "0x42B1700", VA = "0x42B1700")]
    private static float CalcOnePararaUpPercent(
      float parara,
      float pararaStageLimit,
      float pararaStyleLimit)
    {
      return new float();
    }

    [Token(Token = "0x6011AFB")]
    [Address(RVA = "0x42B1248", Offset = "0x42B1248", VA = "0x42B1248")]
    public static float CalcPararaUpPercent(ExpeditionBossDescriptionData bossData, Style style)
    {
      return new float();
    }

    [Token(Token = "0x6011AFC")]
    [Address(RVA = "0x42B1984", Offset = "0x42B1984", VA = "0x42B1984")]
    public PararaBoostUp()
    {
    }
  }
}
