// Decompiled with JetBrains decompiler
// Type: Battle.UI.ParameterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using StaqData;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002392")]
  public class ParameterModel : ParameterModelBase
  {
    [Token(Token = "0x600D945")]
    [Address(RVA = "0x22C7160", Offset = "0x22C7160", VA = "0x22C7160")]
    public void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D946")]
    [Address(RVA = "0x22C8C88", Offset = "0x22C8C88", VA = "0x22C8C88")]
    public void Set(WeaponParameterData weapon)
    {
    }

    [Token(Token = "0x600D947")]
    [Address(RVA = "0x22C91A8", Offset = "0x22C91A8", VA = "0x22C91A8")]
    public void Set(AccessoryData acc)
    {
    }

    [Token(Token = "0x600D948")]
    [Address(RVA = "0x22C9264", Offset = "0x22C9264", VA = "0x22C9264")]
    public void Set(TrustData trust)
    {
    }

    [Token(Token = "0x600D949")]
    [Address(RVA = "0x22C6844", Offset = "0x22C6844", VA = "0x22C6844")]
    public void Set(MindEquipmentData mind)
    {
    }

    [Token(Token = "0x600D94A")]
    [Address(RVA = "0x22C6A48", Offset = "0x22C6A48", VA = "0x22C6A48")]
    public void Set(ParameterModel model)
    {
    }

    [Token(Token = "0x600D94B")]
    [Address(RVA = "0x22C8CE8", Offset = "0x22C8CE8", VA = "0x22C8CE8")]
    private int CalcEquipmentCombatPower(IBattleParameter param, int weight) => new int();

    [Token(Token = "0x600D94C")]
    [Address(RVA = "0x22C7150", Offset = "0x22C7150", VA = "0x22C7150")]
    public ParameterModel()
    {
    }
  }
}
