// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ClearBadStatusEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002786")]
  public class ClearBadStatusEffectData : EffectData
  {
    [Token(Token = "0x400A894")]
    [FieldOffset(Offset = "0x80")]
    private int group;
    [Token(Token = "0x400A895")]
    [FieldOffset(Offset = "0x88")]
    private string groupText;

    [Token(Token = "0x170034E5")]
    public override string DisplayName
    {
      [Token(Token = "0x600F6BC"), Address(RVA = "0x1ED7498", Offset = "0x1ED7498", VA = "0x1ED7498", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170034E6")]
    public List<BattleBadStatusDetailData> BadStatusDetails
    {
      [Token(Token = "0x600F6BD"), Address(RVA = "0x1ED74AC", Offset = "0x1ED74AC", VA = "0x1ED74AC")] get
      {
        return (List<BattleBadStatusDetailData>) null;
      }
      [Token(Token = "0x600F6BE"), Address(RVA = "0x1ED74B4", Offset = "0x1ED74B4", VA = "0x1ED74B4")] private set
      {
      }
    }

    [Token(Token = "0x600F6BF")]
    [Address(RVA = "0x1ED74BC", Offset = "0x1ED74BC", VA = "0x1ED74BC")]
    public static ClearBadStatusEffectData Create(EffectSource source)
    {
      return (ClearBadStatusEffectData) null;
    }

    [Token(Token = "0x600F6C0")]
    [Address(RVA = "0x1ED7558", Offset = "0x1ED7558", VA = "0x1ED7558")]
    protected ClearBadStatusEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F6C1")]
    [Address(RVA = "0x1ED7B0C", Offset = "0x1ED7B0C", VA = "0x1ED7B0C", Slot = "5")]
    public override bool IsEffectable(UnitParameterData from, UnitParameterData to) => new bool();

    [Token(Token = "0x600F6C2")]
    [Address(RVA = "0x1ED7C9C", Offset = "0x1ED7C9C", VA = "0x1ED7C9C", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x2002787")]
    public enum ContextType
    {
      [Token(Token = "0x400A898")] ClearBadStatusGroup,
    }
  }
}
