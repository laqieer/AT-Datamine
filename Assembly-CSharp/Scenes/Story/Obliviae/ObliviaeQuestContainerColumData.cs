// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeQuestContainerColumData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Utility;
using System;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E5A")]
  public class ObliviaeQuestContainerColumData
  {
    [Token(Token = "0x17003D8F")]
    public StoryObliviaeQuestData[] QuestDataList
    {
      [Token(Token = "0x60121C5"), Address(RVA = "0x4588588", Offset = "0x4588588", VA = "0x4588588")] get
      {
        return (StoryObliviaeQuestData[]) null;
      }
      [Token(Token = "0x60121C6"), Address(RVA = "0x4588590", Offset = "0x4588590", VA = "0x4588590")] private set
      {
      }
    }

    [Token(Token = "0x17003D90")]
    public Action<int> OnClickThumbnail
    {
      [Token(Token = "0x60121C7"), Address(RVA = "0x4588598", Offset = "0x4588598", VA = "0x4588598")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x60121C8"), Address(RVA = "0x45885A0", Offset = "0x45885A0", VA = "0x45885A0")] private set
      {
      }
    }

    [Token(Token = "0x17003D91")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x60121C9"), Address(RVA = "0x45885A8", Offset = "0x45885A8", VA = "0x45885A8")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x60121CA"), Address(RVA = "0x45885B0", Offset = "0x45885B0", VA = "0x45885B0")] private set
      {
      }
    }

    [Token(Token = "0x17003D92")]
    public NewBadgeProxy NewBadgeProxy
    {
      [Token(Token = "0x60121CB"), Address(RVA = "0x45885B8", Offset = "0x45885B8", VA = "0x45885B8")] get
      {
        return (NewBadgeProxy) null;
      }
      [Token(Token = "0x60121CC"), Address(RVA = "0x45885C0", Offset = "0x45885C0", VA = "0x45885C0")] private set
      {
      }
    }

    [Token(Token = "0x60121CD")]
    [Address(RVA = "0x4588284", Offset = "0x4588284", VA = "0x4588284")]
    public bool IsEmpty(int index) => new bool();

    [Token(Token = "0x60121CE")]
    [Address(RVA = "0x458824C", Offset = "0x458824C", VA = "0x458824C")]
    public StoryObliviaeQuestData QuestData(int index) => (StoryObliviaeQuestData) null;

    [Token(Token = "0x60121CF")]
    [Address(RVA = "0x45885C8", Offset = "0x45885C8", VA = "0x45885C8")]
    public ObliviaeQuestContainerColumData(
      StoryObliviaeQuestData[] questDataList,
      Action<int> onClickThumbnail,
      AssetCachedSpawner assetCachedSpawner,
      NewBadgeProxy newBadgeProxy)
    {
    }
  }
}
