// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaBattleHistoryDetailDamageReportItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003118")]
  public class ArenaBattleHistoryDetailDamageReportItem : MonoBehaviour
  {
    [Token(Token = "0x400D0FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI txtDamage;
    [Token(Token = "0x400D0FF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleThumb thumb;
    [Token(Token = "0x400D100")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Slider slider;

    [Token(Token = "0x60132BA")]
    [Address(RVA = "0x45E27D4", Offset = "0x45E27D4", VA = "0x45E27D4")]
    public void Initialize(PlayerUnitArenaHistoryType unit, long damage, float damageRatio)
    {
    }

    [Token(Token = "0x60132BB")]
    [Address(RVA = "0x45E29A0", Offset = "0x45E29A0", VA = "0x45E29A0")]
    public ArenaBattleHistoryDetailDamageReportItem()
    {
    }
  }
}
