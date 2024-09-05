// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ActiveSkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027F6")]
  public class ActiveSkillData : SkillData
  {
    [Token(Token = "0x1700362F")]
    public RangeData FiringRange
    {
      [Token(Token = "0x600F9DF"), Address(RVA = "0x44C5950", Offset = "0x44C5950", VA = "0x44C5950")] get
      {
        return (RangeData) null;
      }
      [Token(Token = "0x600F9E0"), Address(RVA = "0x44C5958", Offset = "0x44C5958", VA = "0x44C5958")] private set
      {
      }
    }

    [Token(Token = "0x17003630")]
    public bool HasEffectOnStartDuel
    {
      [Token(Token = "0x600F9E1"), Address(RVA = "0x44C5960", Offset = "0x44C5960", VA = "0x44C5960")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F9E2"), Address(RVA = "0x44C5968", Offset = "0x44C5968", VA = "0x44C5968")] private set
      {
      }
    }

    [Token(Token = "0x17003631")]
    public bool HasEffectOnEndDuel
    {
      [Token(Token = "0x600F9E3"), Address(RVA = "0x44C5974", Offset = "0x44C5974", VA = "0x44C5974")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F9E4"), Address(RVA = "0x44C597C", Offset = "0x44C597C", VA = "0x44C597C")] private set
      {
      }
    }

    [Token(Token = "0x600F9E5")]
    [Address(RVA = "0x44C5988", Offset = "0x44C5988", VA = "0x44C5988", Slot = "4")]
    protected override void OnInitialized()
    {
    }

    [Token(Token = "0x600F9E6")]
    [Address(RVA = "0x44C5BF8", Offset = "0x44C5BF8", VA = "0x44C5BF8")]
    public bool HasEffectOn(InDuelEffectTimingTypeEnum timing) => new bool();

    [Token(Token = "0x600F9E7")]
    [Address(RVA = "0x44C5C34", Offset = "0x44C5C34", VA = "0x44C5C34")]
    public ActiveSkillData()
    {
    }
  }
}
