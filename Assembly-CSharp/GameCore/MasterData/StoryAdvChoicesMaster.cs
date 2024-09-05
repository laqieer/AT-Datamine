// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAdvChoicesMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DC6")]
  [Serializable]
  public sealed class StoryAdvChoicesMaster : BaseMaster<StoryAdvChoicesData>
  {
    [Token(Token = "0x40041E1")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryAdvChoicesMaster.ChoiceData>> choicesOnSuggestionTable;
    [Token(Token = "0x40041E2")]
    private const int ChoiceSize = 5;

    [Token(Token = "0x600542E")]
    [Address(RVA = "0x3AA26AC", Offset = "0x3AA26AC", VA = "0x3AA26AC")]
    public IReadOnlyDictionary<int, StoryAdvChoicesData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAdvChoicesData>) null;
    }

    [Token(Token = "0x600542F")]
    [Address(RVA = "0x3AA26B4", Offset = "0x3AA26B4", VA = "0x3AA26B4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005430")]
    [Address(RVA = "0x3AA2778", Offset = "0x3AA2778", VA = "0x3AA2778", Slot = "5")]
    protected override StoryAdvChoicesData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAdvChoicesData) null;
    }

    [Token(Token = "0x6005431")]
    [Address(RVA = "0x3AA271C", Offset = "0x3AA271C", VA = "0x3AA271C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005432")]
    [Address(RVA = "0x3AA27E8", Offset = "0x3AA27E8", VA = "0x3AA27E8")]
    private void OnLoadEntity(StoryAdvChoicesData entity)
    {
    }

    [Token(Token = "0x6005433")]
    [Address(RVA = "0x3AA2BE8", Offset = "0x3AA2BE8", VA = "0x3AA2BE8")]
    public StoryAdvChoicesMaster.ChoiceData GetChoice(int suggestionID, int number)
    {
      return (StoryAdvChoicesMaster.ChoiceData) null;
    }

    [Token(Token = "0x6005434")]
    [Address(RVA = "0x3AA2C9C", Offset = "0x3AA2C9C", VA = "0x3AA2C9C")]
    public StoryAdvChoicesMaster()
    {
    }

    [Token(Token = "0x2000DC7")]
    public class ChoiceData
    {
      [Token(Token = "0x17000C03")]
      public StoryAdvChoicesMaster.ChoiceData.Types Type
      {
        [Token(Token = "0x6005435"), Address(RVA = "0x3AA2D2C", Offset = "0x3AA2D2C", VA = "0x3AA2D2C")] get
        {
          return new StoryAdvChoicesMaster.ChoiceData.Types();
        }
      }

      [Token(Token = "0x17000C04")]
      public int ID
      {
        [Token(Token = "0x6005436"), Address(RVA = "0x3AA2D34", Offset = "0x3AA2D34", VA = "0x3AA2D34")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000C05")]
      public int Value
      {
        [Token(Token = "0x6005437"), Address(RVA = "0x3AA2D3C", Offset = "0x3AA2D3C", VA = "0x3AA2D3C")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6005438")]
      [Address(RVA = "0x3AA2BAC", Offset = "0x3AA2BAC", VA = "0x3AA2BAC")]
      public ChoiceData(int type, int id, int value)
      {
      }

      [Token(Token = "0x2000DC8")]
      public enum Types
      {
        [Token(Token = "0x40041E7")] None,
        [Token(Token = "0x40041E8")] StoryPoint,
      }
    }
  }
}
