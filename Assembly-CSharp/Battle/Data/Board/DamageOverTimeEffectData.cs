// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.DamageOverTimeEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200277B")]
  public class DamageOverTimeEffectData : BadStatusEffectData
  {
    [Token(Token = "0x400A87C")]
    [FieldOffset(Offset = "0xB0")]
    protected EffectValue effectValue;

    [Token(Token = "0x170034CD")]
    public override BattleEffectValueTypeEnum ValueType
    {
      [Token(Token = "0x600F68D"), Address(RVA = "0x1ED6DA8", Offset = "0x1ED6DA8", VA = "0x1ED6DA8", Slot = "18")] get
      {
        return new BattleEffectValueTypeEnum();
      }
    }

    [Token(Token = "0x170034CE")]
    public override int Value
    {
      [Token(Token = "0x600F68E"), Address(RVA = "0x1ED6DB0", Offset = "0x1ED6DB0", VA = "0x1ED6DB0", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F68F")]
    [Address(RVA = "0x1ED6DB8", Offset = "0x1ED6DB8", VA = "0x1ED6DB8")]
    public static DamageOverTimeEffectData Create(DamageOverTimeEffectSource source)
    {
      return (DamageOverTimeEffectData) null;
    }

    [Token(Token = "0x600F690")]
    [Address(RVA = "0x1ED6E58", Offset = "0x1ED6E58", VA = "0x1ED6E58")]
    private DamageOverTimeEffectData(
      DamageOverTimeEffectSource source,
      DamageOverTimeEffectData.ContextIndexInfo indexInfo)
    {
    }

    [Token(Token = "0x600F691")]
    [Address(RVA = "0x1ED6F20", Offset = "0x1ED6F20", VA = "0x1ED6F20", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x200277C")]
    protected new struct ContextIndexInfo : BadStatusEffectData.IContextIndexInfo
    {
      [Token(Token = "0x170034CF")]
      public int BadStatusMasterId
      {
        [Token(Token = "0x600F692"), Address(RVA = "0x1ED6FD4", Offset = "0x1ED6FD4", VA = "0x1ED6FD4", Slot = "4")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170034D0")]
      public int Value
      {
        [Token(Token = "0x600F693"), Address(RVA = "0x1ED6F18", Offset = "0x1ED6F18", VA = "0x1ED6F18")] get
        {
          return new int();
        }
      }
    }
  }
}
