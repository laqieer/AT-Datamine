// Decompiled with JetBrains decompiler
// Type: StaqData.GachaPaymentModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002129")]
  public class GachaPaymentModel
  {
    [Token(Token = "0x17002C43")]
    public GachaDetailInfo DetailInfo
    {
      [Token(Token = "0x600CAEE"), Address(RVA = "0x1BA7C5C", Offset = "0x1BA7C5C", VA = "0x1BA7C5C")] get
      {
        return (GachaDetailInfo) null;
      }
      [Token(Token = "0x600CAEF"), Address(RVA = "0x1BA7C64", Offset = "0x1BA7C64", VA = "0x1BA7C64")] private set
      {
      }
    }

    [Token(Token = "0x17002C44")]
    public int RollCount
    {
      [Token(Token = "0x600CAF0"), Address(RVA = "0x1BA7C6C", Offset = "0x1BA7C6C", VA = "0x1BA7C6C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAF1"), Address(RVA = "0x1BA7C74", Offset = "0x1BA7C74", VA = "0x1BA7C74")] private set
      {
      }
    }

    [Token(Token = "0x17002C45")]
    public int PaymentAmount
    {
      [Token(Token = "0x600CAF2"), Address(RVA = "0x1BA7C7C", Offset = "0x1BA7C7C", VA = "0x1BA7C7C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAF3"), Address(RVA = "0x1BA7C84", Offset = "0x1BA7C84", VA = "0x1BA7C84")] private set
      {
      }
    }

    [Token(Token = "0x17002C46")]
    public int ExecuteCount
    {
      [Token(Token = "0x600CAF4"), Address(RVA = "0x1BA7C8C", Offset = "0x1BA7C8C", VA = "0x1BA7C8C")] get
      {
        return new int();
      }
      [Token(Token = "0x600CAF5"), Address(RVA = "0x1BA7C94", Offset = "0x1BA7C94", VA = "0x1BA7C94")] private set
      {
      }
    }

    [Token(Token = "0x17002C47")]
    public string GachaTitle
    {
      [Token(Token = "0x600CAF6"), Address(RVA = "0x1BA7C9C", Offset = "0x1BA7C9C", VA = "0x1BA7C9C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002C48")]
    public string GachaName
    {
      [Token(Token = "0x600CAF7"), Address(RVA = "0x1BA7CC8", Offset = "0x1BA7CC8", VA = "0x1BA7CC8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002C49")]
    public int GachaDetailId
    {
      [Token(Token = "0x600CAF8"), Address(RVA = "0x1BA7CE0", Offset = "0x1BA7CE0", VA = "0x1BA7CE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C4A")]
    public int GachaGroupId
    {
      [Token(Token = "0x600CAF9"), Address(RVA = "0x1BA7CFC", Offset = "0x1BA7CFC", VA = "0x1BA7CFC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C4B")]
    public int PaymentId
    {
      [Token(Token = "0x600CAFA"), Address(RVA = "0x1BA7D18", Offset = "0x1BA7D18", VA = "0x1BA7D18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C4C")]
    public int MaxExecuteCount
    {
      [Token(Token = "0x600CAFB"), Address(RVA = "0x1BA7D34", Offset = "0x1BA7D34", VA = "0x1BA7D34")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C4D")]
    public int RemainAdvertisementCount
    {
      [Token(Token = "0x600CAFC"), Address(RVA = "0x1BA7D50", Offset = "0x1BA7D50", VA = "0x1BA7D50")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C4E")]
    public PaymentTypeEnum PaymentType
    {
      [Token(Token = "0x600CAFD"), Address(RVA = "0x1BA7D6C", Offset = "0x1BA7D6C", VA = "0x1BA7D6C")] get
      {
        return new PaymentTypeEnum();
      }
    }

    [Token(Token = "0x17002C4F")]
    public DateTime StartAt
    {
      [Token(Token = "0x600CAFE"), Address(RVA = "0x1BA7D88", Offset = "0x1BA7D88", VA = "0x1BA7D88")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17002C50")]
    public DateTime EndAt
    {
      [Token(Token = "0x600CAFF"), Address(RVA = "0x1BA7DAC", Offset = "0x1BA7DAC", VA = "0x1BA7DAC")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17002C51")]
    public bool HasEnoughPaymentAmount
    {
      [Token(Token = "0x600CB00"), Address(RVA = "0x1BA7DD0", Offset = "0x1BA7DD0", VA = "0x1BA7DD0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CB01"), Address(RVA = "0x1BA7DD8", Offset = "0x1BA7DD8", VA = "0x1BA7DD8")] private set
      {
      }
    }

    [Token(Token = "0x17002C52")]
    public GachaTypeEnum GachaType
    {
      [Token(Token = "0x600CB02"), Address(RVA = "0x1BA7DE4", Offset = "0x1BA7DE4", VA = "0x1BA7DE4")] get
      {
        return new GachaTypeEnum();
      }
    }

    [Token(Token = "0x17002C53")]
    public int GachaId
    {
      [Token(Token = "0x600CB03"), Address(RVA = "0x1BA7DFC", Offset = "0x1BA7DFC", VA = "0x1BA7DFC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C54")]
    public bool IsHasAnyLimit
    {
      [Token(Token = "0x600CB04"), Address(RVA = "0x1BA7E18", Offset = "0x1BA7E18", VA = "0x1BA7E18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C55")]
    public bool IsStepGacha
    {
      [Token(Token = "0x600CB05"), Address(RVA = "0x1BA7E4C", Offset = "0x1BA7E4C", VA = "0x1BA7E4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C56")]
    public bool IsAdsGacha
    {
      [Token(Token = "0x600CB06"), Address(RVA = "0x1BA7E70", Offset = "0x1BA7E70", VA = "0x1BA7E70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CB07")]
    [Address(RVA = "0x1BA7A84", Offset = "0x1BA7A84", VA = "0x1BA7A84")]
    public GachaPaymentModel(GachaDetailInfo gachaDetailInfo, int executeCount = 1)
    {
    }

    [Token(Token = "0x600CB08")]
    [Address(RVA = "0x1BA7F14", Offset = "0x1BA7F14", VA = "0x1BA7F14")]
    private void Initialize(int rollCount, int paymentAmount, int executeCount)
    {
    }

    [Token(Token = "0x600CB09")]
    [Address(RVA = "0x1BA7F68", Offset = "0x1BA7F68", VA = "0x1BA7F68")]
    public void ToMaxExecuteCount()
    {
    }

    [Token(Token = "0x600CB0A")]
    [Address(RVA = "0x1BA80DC", Offset = "0x1BA80DC", VA = "0x1BA80DC")]
    public void SetExecuteCount(int executeCount)
    {
    }

    [Token(Token = "0x600CB0B")]
    [Address(RVA = "0x1BA7E94", Offset = "0x1BA7E94", VA = "0x1BA7E94")]
    private (int, int, int) CalcPaymentInfo(int executeCount) => ();

    [Token(Token = "0x600CB0C")]
    [Address(RVA = "0x1BA7FB0", Offset = "0x1BA7FB0", VA = "0x1BA7FB0")]
    private (int, int, int) CalcMaxTicketPaymentInfo() => ();

    [Token(Token = "0x600CB0D")]
    [Address(RVA = "0x1BA8100", Offset = "0x1BA8100", VA = "0x1BA8100")]
    public string GetRemainingButtonText() => (string) null;

    [Token(Token = "0x600CB0E")]
    [Address(RVA = "0x1BA8210", Offset = "0x1BA8210", VA = "0x1BA8210")]
    public string GetFreeText() => (string) null;

    [Token(Token = "0x600CB0F")]
    [Address(RVA = "0x1BA82AC", Offset = "0x1BA82AC", VA = "0x1BA82AC")]
    public List<GachaBonusRewardInfo> GetExecutionMultipliedBonusInfo()
    {
      return (List<GachaBonusRewardInfo>) null;
    }
  }
}
