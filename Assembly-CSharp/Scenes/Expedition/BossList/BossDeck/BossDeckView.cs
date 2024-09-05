// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDeck.BossDeckView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.BossList.BossDeck
{
  [Token(Token = "0x2002D4A")]
  [AddComponentMenu("Scenes/Expedition/BossList/BossDeck/DeckView")]
  public class BossDeckView : MonoBehaviour
  {
    [Token(Token = "0x400C25E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI combatPower;
    [Token(Token = "0x400C25F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BossDeckUnit[] units;

    [Token(Token = "0x17003C8E")]
    public int TotalCombat
    {
      [Token(Token = "0x6011B46"), Address(RVA = "0x42B5664", Offset = "0x42B5664", VA = "0x42B5664")] get
      {
        return new int();
      }
      [Token(Token = "0x6011B47"), Address(RVA = "0x42B566C", Offset = "0x42B566C", VA = "0x42B566C")] private set
      {
      }
    }

    [Token(Token = "0x17003C8F")]
    public bool IsWait
    {
      [Token(Token = "0x6011B48"), Address(RVA = "0x42B5674", Offset = "0x42B5674", VA = "0x42B5674")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003C90")]
    public ExpeditionBossDescriptionData BossData
    {
      [Token(Token = "0x6011B49"), Address(RVA = "0x42B5770", Offset = "0x42B5770", VA = "0x42B5770")] get
      {
        return (ExpeditionBossDescriptionData) null;
      }
      [Token(Token = "0x6011B4A"), Address(RVA = "0x42B5778", Offset = "0x42B5778", VA = "0x42B5778")] private set
      {
      }
    }

    [Token(Token = "0x6011B4B")]
    [Address(RVA = "0x42AC8D4", Offset = "0x42AC8D4", VA = "0x42AC8D4")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6011B4C")]
    [Address(RVA = "0x42B5780", Offset = "0x42B5780", VA = "0x42B5780")]
    public void SetDeck(int bossStageId, ExpeditionBossDescriptionData bossData)
    {
    }

    [Token(Token = "0x6011B4D")]
    [Address(RVA = "0x42B5B00", Offset = "0x42B5B00", VA = "0x42B5B00")]
    private int CalcPararaBoost(Style style) => new int();

    [Token(Token = "0x6011B4E")]
    [Address(RVA = "0x42B5BE4", Offset = "0x42B5BE4", VA = "0x42B5BE4")]
    private int CalcCombatPower(Style style) => new int();

    [Token(Token = "0x6011B4F")]
    [Address(RVA = "0x42B5C6C", Offset = "0x42B5C6C", VA = "0x42B5C6C")]
    private void SetDeck((Style style, int rank)[] datas)
    {
    }

    [Token(Token = "0x6011B50")]
    [Address(RVA = "0x42B5D48", Offset = "0x42B5D48", VA = "0x42B5D48")]
    public BossDeckView()
    {
    }
  }
}
