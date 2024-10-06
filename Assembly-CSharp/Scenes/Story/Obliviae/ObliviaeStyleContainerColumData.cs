// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeStyleContainerColumData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E73")]
  public class ObliviaeStyleContainerColumData
  {
    [Token(Token = "0x17003DAA")]
    public StoryObliviaeDetailData[] DetailDataList
    {
      [Token(Token = "0x6012264"), Address(RVA = "0x458E994", Offset = "0x458E994", VA = "0x458E994")] get
      {
        return (StoryObliviaeDetailData[]) null;
      }
      [Token(Token = "0x6012265"), Address(RVA = "0x458E99C", Offset = "0x458E99C", VA = "0x458E99C")] private set
      {
      }
    }

    [Token(Token = "0x17003DAB")]
    public bool IsMarginObject
    {
      [Token(Token = "0x6012266"), Address(RVA = "0x458E9A4", Offset = "0x458E9A4", VA = "0x458E9A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6012267"), Address(RVA = "0x458E9AC", Offset = "0x458E9AC", VA = "0x458E9AC")] private set
      {
      }
    }

    [Token(Token = "0x17003DAC")]
    public int StartDetailDataIndex
    {
      [Token(Token = "0x6012268"), Address(RVA = "0x458E9B8", Offset = "0x458E9B8", VA = "0x458E9B8")] get
      {
        return new int();
      }
      [Token(Token = "0x6012269"), Address(RVA = "0x458E9C0", Offset = "0x458E9C0", VA = "0x458E9C0")] private set
      {
      }
    }

    [Token(Token = "0x17003DAD")]
    public Action<int> OnClickIcon
    {
      [Token(Token = "0x601226A"), Address(RVA = "0x458E9C8", Offset = "0x458E9C8", VA = "0x458E9C8")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x601226B"), Address(RVA = "0x458E9D0", Offset = "0x458E9D0", VA = "0x458E9D0")] private set
      {
      }
    }

    [Token(Token = "0x17003DAE")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x601226C"), Address(RVA = "0x458E9D8", Offset = "0x458E9D8", VA = "0x458E9D8")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x601226D"), Address(RVA = "0x458E9E0", Offset = "0x458E9E0", VA = "0x458E9E0")] private set
      {
      }
    }

    [Token(Token = "0x601226E")]
    [Address(RVA = "0x458E718", Offset = "0x458E718", VA = "0x458E718")]
    public bool IsEmpty(int index) => new bool();

    [Token(Token = "0x601226F")]
    [Address(RVA = "0x458E850", Offset = "0x458E850", VA = "0x458E850")]
    public bool IsUnlockObliviae(int index) => new bool();

    [Token(Token = "0x6012270")]
    [Address(RVA = "0x458E760", Offset = "0x458E760", VA = "0x458E760")]
    public GameCore.MasterData.StyleData StyleData(int index) => (GameCore.MasterData.StyleData) null;

    [Token(Token = "0x6012271")]
    [Address(RVA = "0x458E9E8", Offset = "0x458E9E8", VA = "0x458E9E8")]
    public ObliviaeStyleContainerColumData(
      StoryObliviaeDetailData[] detailDataList,
      bool isMarginObject,
      int startIndex,
      Action<int> onClickIcon,
      AssetCachedSpawner assetCachedSpawner)
    {
    }
  }
}
