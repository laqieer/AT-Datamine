// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItem.BattleResultItemList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItem
{
  [Token(Token = "0x20037E2")]
  public class BattleResultItemList : MonoBehaviour
  {
    [Token(Token = "0x400F434")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BattleResultItemCell _cellBase;

    [Token(Token = "0x6015FCC")]
    [Address(RVA = "0x232F1A0", Offset = "0x232F1A0", VA = "0x232F1A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6015FCD")]
    [Address(RVA = "0x232F1CC", Offset = "0x232F1CC", VA = "0x232F1CC")]
    public void Initialize(
      ResultData.ItemData[] dropItemList,
      ItemDetailPopupProvider itemDetailPopupProvider,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6015FCE")]
    [Address(RVA = "0x232F308", Offset = "0x232F308", VA = "0x232F308")]
    public BattleResultItemList()
    {
    }
  }
}
