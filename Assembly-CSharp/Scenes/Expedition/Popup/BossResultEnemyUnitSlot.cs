// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.BossResultEnemyUnitSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Expedition.Boss.BattleResult;
using Scenes.OutGame.OutGameMenu;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C52")]
  public class BossResultEnemyUnitSlot : MonoBehaviour
  {
    [Token(Token = "0x400BCD0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x400BCD1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI hpText;
    [Token(Token = "0x400BCD2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Slider hpSlider;
    [Token(Token = "0x400BCD3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private StyleThumb styleThumb;

    [Token(Token = "0x60115CD")]
    [Address(RVA = "0x4E1924C", Offset = "0x4E1924C", VA = "0x4E1924C")]
    public void Initialized(BossData bossData)
    {
    }

    [Token(Token = "0x60115CE")]
    [Address(RVA = "0x4E19444", Offset = "0x4E19444", VA = "0x4E19444")]
    private void EmptySlot()
    {
    }

    [Token(Token = "0x60115CF")]
    [Address(RVA = "0x4E19574", Offset = "0x4E19574", VA = "0x4E19574")]
    public BossResultEnemyUnitSlot()
    {
    }
  }
}
