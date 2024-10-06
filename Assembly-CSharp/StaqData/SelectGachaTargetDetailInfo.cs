// Decompiled with JetBrains decompiler
// Type: StaqData.SelectGachaTargetDetailInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002142")]
  public class SelectGachaTargetDetailInfo
  {
    [Token(Token = "0x17002C91")]
    public int TargetOptionId
    {
      [Token(Token = "0x600CBD0"), Address(RVA = "0x1BAA3CC", Offset = "0x1BAA3CC", VA = "0x1BAA3CC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBD1"), Address(RVA = "0x1BAA3D4", Offset = "0x1BAA3D4", VA = "0x1BAA3D4")] private set
      {
      }
    }

    [Token(Token = "0x17002C92")]
    public RewardTypeEnum RewardType
    {
      [Token(Token = "0x600CBD2"), Address(RVA = "0x1BAA3DC", Offset = "0x1BAA3DC", VA = "0x1BAA3DC")] get
      {
        return new RewardTypeEnum();
      }
      [Token(Token = "0x600CBD3"), Address(RVA = "0x1BAA3E4", Offset = "0x1BAA3E4", VA = "0x1BAA3E4")] private set
      {
      }
    }

    [Token(Token = "0x17002C93")]
    public int RewardId
    {
      [Token(Token = "0x600CBD4"), Address(RVA = "0x1BAA3EC", Offset = "0x1BAA3EC", VA = "0x1BAA3EC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBD5"), Address(RVA = "0x1BAA3F4", Offset = "0x1BAA3F4", VA = "0x1BAA3F4")] private set
      {
      }
    }

    [Token(Token = "0x17002C94")]
    public int RewardQuantity
    {
      [Token(Token = "0x600CBD6"), Address(RVA = "0x1BAA3FC", Offset = "0x1BAA3FC", VA = "0x1BAA3FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBD7"), Address(RVA = "0x1BAA404", Offset = "0x1BAA404", VA = "0x1BAA404")] private set
      {
      }
    }

    [Token(Token = "0x600CBD8")]
    [Address(RVA = "0x1BAA40C", Offset = "0x1BAA40C", VA = "0x1BAA40C")]
    public static SelectGachaTargetDetailInfo CreateFromServerData(
      G0001GachaTargetOptionType serverData)
    {
      return (SelectGachaTargetDetailInfo) null;
    }

    [Token(Token = "0x600CBD9")]
    [Address(RVA = "0x1BAA480", Offset = "0x1BAA480", VA = "0x1BAA480")]
    public static List<SelectGachaTargetDetailInfo> CreateFromServerData(
      IEnumerable<G0001GachaTargetOptionType> serverData)
    {
      return (List<SelectGachaTargetDetailInfo>) null;
    }

    [Token(Token = "0x600CBDA")]
    [Address(RVA = "0x1BAA594", Offset = "0x1BAA594", VA = "0x1BAA594")]
    internal void Where()
    {
    }

    [Token(Token = "0x600CBDB")]
    [Address(RVA = "0x1BAA478", Offset = "0x1BAA478", VA = "0x1BAA478")]
    public SelectGachaTargetDetailInfo()
    {
    }
  }
}
