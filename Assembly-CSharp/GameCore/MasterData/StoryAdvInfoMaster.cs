// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAdvInfoMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DCA")]
  [Serializable]
  public sealed class StoryAdvInfoMaster : BaseMaster<StoryAdvInfoData>
  {
    [Token(Token = "0x40041FA")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<int>> suggestionListTable;
    [Token(Token = "0x40041FB")]
    private const int SuggestionSize = 5;

    [Token(Token = "0x600543D")]
    [Address(RVA = "0x3AA3578", Offset = "0x3AA3578", VA = "0x3AA3578")]
    public IReadOnlyDictionary<int, StoryAdvInfoData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAdvInfoData>) null;
    }

    [Token(Token = "0x600543E")]
    [Address(RVA = "0x3AA3580", Offset = "0x3AA3580", VA = "0x3AA3580", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600543F")]
    [Address(RVA = "0x3AA3644", Offset = "0x3AA3644", VA = "0x3AA3644", Slot = "5")]
    protected override StoryAdvInfoData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAdvInfoData) null;
    }

    [Token(Token = "0x6005440")]
    [Address(RVA = "0x3AA35E8", Offset = "0x3AA35E8", VA = "0x3AA35E8")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005441")]
    [Address(RVA = "0x3AA36B4", Offset = "0x3AA36B4", VA = "0x3AA36B4")]
    private void OnLoadEntity(StoryAdvInfoData entity)
    {
    }

    [Token(Token = "0x6005442")]
    [Address(RVA = "0x3AA3810", Offset = "0x3AA3810", VA = "0x3AA3810")]
    private int[] ConvertSuggestionIDsArray(StoryAdvInfoData entity) => (int[]) null;

    [Token(Token = "0x6005443")]
    [Address(RVA = "0x3AA38BC", Offset = "0x3AA38BC", VA = "0x3AA38BC")]
    public IReadOnlyCollection<StoryAdvChoicesMaster.ChoiceData> GetChoices(
      int advID,
      int[] choices)
    {
      return (IReadOnlyCollection<StoryAdvChoicesMaster.ChoiceData>) null;
    }

    [Token(Token = "0x6005444")]
    [Address(RVA = "0x3AA3AD0", Offset = "0x3AA3AD0", VA = "0x3AA3AD0")]
    public StoryAdvInfoMaster()
    {
    }
  }
}
