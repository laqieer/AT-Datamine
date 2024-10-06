// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.EquipStatusDetail_WepStatusWin02_BattleParam_Detail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x2003451")]
  public class EquipStatusDetail_WepStatusWin02_BattleParam_Detail : 
    EquipStatusDetail_WepStatusWinBase
  {
    [Token(Token = "0x400E3C1")]
    private const int param_num = 63;
    [Token(Token = "0x400E3C2")]
    [FieldOffset(Offset = "0x40")]
    private PlayerProfile profile;
    [Token(Token = "0x400E3C3")]
    [FieldOffset(Offset = "0x48")]
    private WeaponData weaponMaster;
    [Token(Token = "0x400E3C4")]
    [FieldOffset(Offset = "0x50")]
    private Weapon weaponData;

    [Token(Token = "0x60148C8")]
    [Address(RVA = "0x1AA0F74", Offset = "0x1AA0F74", VA = "0x1AA0F74", Slot = "4")]
    public override void Initialize(UniqueID id)
    {
    }

    [Token(Token = "0x60148C9")]
    [Address(RVA = "0x1AA1704", Offset = "0x1AA1704", VA = "0x1AA1704")]
    private string NextLvValue(int nowLv, int min, int max, int cap) => (string) null;

    [Token(Token = "0x60148CA")]
    [Address(RVA = "0x1AA1760", Offset = "0x1AA1760", VA = "0x1AA1760")]
    public EquipStatusDetail_WepStatusWin02_BattleParam_Detail()
    {
    }
  }
}
