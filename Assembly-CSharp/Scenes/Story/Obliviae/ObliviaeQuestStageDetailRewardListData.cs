// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeQuestStageDetailRewardListData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E6F")]
  public class ObliviaeQuestStageDetailRewardListData
  {
    [Token(Token = "0x17003DA6")]
    public ObliviaeQuestStageDetailRewardData[] RewardList
    {
      [Token(Token = "0x6012247"), Address(RVA = "0x458D96C", Offset = "0x458D96C", VA = "0x458D96C")] get
      {
        return (ObliviaeQuestStageDetailRewardData[]) null;
      }
      [Token(Token = "0x6012248"), Address(RVA = "0x458D974", Offset = "0x458D974", VA = "0x458D974")] private set
      {
      }
    }

    [Token(Token = "0x17003DA7")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x6012249"), Address(RVA = "0x458D97C", Offset = "0x458D97C", VA = "0x458D97C")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x601224A"), Address(RVA = "0x458D984", Offset = "0x458D984", VA = "0x458D984")] private set
      {
      }
    }

    [Token(Token = "0x601224B")]
    [Address(RVA = "0x458D544", Offset = "0x458D544", VA = "0x458D544")]
    public bool IsEmpty() => new bool();

    [Token(Token = "0x601224C")]
    [Address(RVA = "0x458C66C", Offset = "0x458C66C", VA = "0x458C66C")]
    public ObliviaeQuestStageDetailRewardListData(
      ObliviaeQuestStageDetailRewardData[] rewardList,
      AssetCachedSpawner assetCachedSpawner)
    {
    }
  }
}
