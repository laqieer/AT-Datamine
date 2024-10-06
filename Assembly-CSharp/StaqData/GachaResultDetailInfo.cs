// Decompiled with JetBrains decompiler
// Type: StaqData.GachaResultDetailInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200213F")]
  public class GachaResultDetailInfo
  {
    [Token(Token = "0x17002C8A")]
    public RewardTypeEnum RewardType
    {
      [Token(Token = "0x600CBBC"), Address(RVA = "0x1BAA2CC", Offset = "0x1BAA2CC", VA = "0x1BAA2CC")] get
      {
        return new RewardTypeEnum();
      }
      [Token(Token = "0x600CBBD"), Address(RVA = "0x1BAA2D4", Offset = "0x1BAA2D4", VA = "0x1BAA2D4")] private set
      {
      }
    }

    [Token(Token = "0x17002C8B")]
    public int RewardId
    {
      [Token(Token = "0x600CBBE"), Address(RVA = "0x1BAA2DC", Offset = "0x1BAA2DC", VA = "0x1BAA2DC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBBF"), Address(RVA = "0x1BAA2E4", Offset = "0x1BAA2E4", VA = "0x1BAA2E4")] private set
      {
      }
    }

    [Token(Token = "0x17002C8C")]
    public int RewardQuantity
    {
      [Token(Token = "0x600CBC0"), Address(RVA = "0x1BAA2EC", Offset = "0x1BAA2EC", VA = "0x1BAA2EC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBC1"), Address(RVA = "0x1BAA2F4", Offset = "0x1BAA2F4", VA = "0x1BAA2F4")] private set
      {
      }
    }

    [Token(Token = "0x17002C8D")]
    public bool IsNew
    {
      [Token(Token = "0x600CBC2"), Address(RVA = "0x1BAA2FC", Offset = "0x1BAA2FC", VA = "0x1BAA2FC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CBC3"), Address(RVA = "0x1BAA304", Offset = "0x1BAA304", VA = "0x1BAA304")] private set
      {
      }
    }

    [Token(Token = "0x17002C8E")]
    public string RewardResultId
    {
      [Token(Token = "0x600CBC4"), Address(RVA = "0x1BAA310", Offset = "0x1BAA310", VA = "0x1BAA310")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CBC5"), Address(RVA = "0x1BAA318", Offset = "0x1BAA318", VA = "0x1BAA318")] private set
      {
      }
    }

    [Token(Token = "0x600CBC6")]
    [Address(RVA = "0x1BAA218", Offset = "0x1BAA218", VA = "0x1BAA218")]
    public static GachaResultDetailInfo CreateFromServerData(RewardGiveResultEntityType serverData)
    {
      return (GachaResultDetailInfo) null;
    }

    [Token(Token = "0x600CBC7")]
    [Address(RVA = "0x1BAA320", Offset = "0x1BAA320", VA = "0x1BAA320")]
    public GachaResultDetailInfo()
    {
    }
  }
}
