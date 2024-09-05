// Decompiled with JetBrains decompiler
// Type: StaqData.IntroChapterInfoManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200200D")]
  public class IntroChapterInfoManager
  {
    [Token(Token = "0x4008892")]
    [FieldOffset(Offset = "0x11")]
    private bool finished;
    [Token(Token = "0x4008893")]
    [FieldOffset(Offset = "0x12")]
    private bool isFinishReserved;

    [Token(Token = "0x17002791")]
    public bool IsEndedMainDownload
    {
      [Token(Token = "0x600BECA"), Address(RVA = "0x2002FC8", Offset = "0x2002FC8", VA = "0x2002FC8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BECB"), Address(RVA = "0x2002FD0", Offset = "0x2002FD0", VA = "0x2002FD0")] private set
      {
      }
    }

    [Token(Token = "0x600BECC")]
    [Address(RVA = "0x2002FDC", Offset = "0x2002FDC", VA = "0x2002FDC")]
    public void SetEndedMainDownload()
    {
    }

    [Token(Token = "0x600BECD")]
    [Address(RVA = "0x2002FE8", Offset = "0x2002FE8", VA = "0x2002FE8")]
    public static int GetFreeMoveTutorialProgressValue() => new int();

    [Token(Token = "0x17002792")]
    private bool isAgreedTermsOfService
    {
      [Token(Token = "0x600BECE"), Address(RVA = "0x2003118", Offset = "0x2003118", VA = "0x2003118")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BECF"), Address(RVA = "0x200319C", Offset = "0x200319C", VA = "0x200319C")] set
      {
      }
    }

    [Token(Token = "0x17002793")]
    private int nowProgressValue
    {
      [Token(Token = "0x600BED0"), Address(RVA = "0x200326C", Offset = "0x200326C", VA = "0x200326C")] get
      {
        return new int();
      }
      [Token(Token = "0x600BED1"), Address(RVA = "0x20032F0", Offset = "0x20032F0", VA = "0x20032F0")] set
      {
      }
    }

    [Token(Token = "0x600BED2")]
    [Address(RVA = "0x2003540", Offset = "0x2003540", VA = "0x2003540")]
    public void SigninNetworkReponseApply(bool finished)
    {
    }

    [Token(Token = "0x600BED3")]
    [Address(RVA = "0x2003694", Offset = "0x2003694", VA = "0x2003694")]
    public bool IsFinished() => new bool();

    [Token(Token = "0x600BED4")]
    [Address(RVA = "0x2003554", Offset = "0x2003554", VA = "0x2003554")]
    public void Finished()
    {
    }

    [Token(Token = "0x600BED5")]
    [Address(RVA = "0x200371C", Offset = "0x200371C", VA = "0x200371C")]
    public bool IsAgreedTermsOfService() => new bool();

    [Token(Token = "0x600BED6")]
    [Address(RVA = "0x2003720", Offset = "0x2003720", VA = "0x2003720")]
    public void AgreedTermsOfService()
    {
    }

    [Token(Token = "0x600BED7")]
    [Address(RVA = "0x2003728", Offset = "0x2003728", VA = "0x2003728")]
    public int GetNowProgressValue() => new int();

    [Token(Token = "0x600BED8")]
    [Address(RVA = "0x200372C", Offset = "0x200372C", VA = "0x200372C")]
    public void SetNowProgressValue(int progressValue)
    {
    }

    [Token(Token = "0x600BED9")]
    [Address(RVA = "0x2003730", Offset = "0x2003730", VA = "0x2003730")]
    public IntroChapterSeqContentsPramData GetNowSequenceParam()
    {
      return (IntroChapterSeqContentsPramData) null;
    }

    [Token(Token = "0x600BEDA")]
    [Address(RVA = "0x2003AF4", Offset = "0x2003AF4", VA = "0x2003AF4")]
    public int GetNextSequenceProgressValue() => new int();

    [Token(Token = "0x600BEDB")]
    [Address(RVA = "0x2003E24", Offset = "0x2003E24", VA = "0x2003E24")]
    public void NowSequenceProgressEnded(int nextProgressValue)
    {
    }

    [Token(Token = "0x600BEDC")]
    [Address(RVA = "0x2003E5C", Offset = "0x2003E5C", VA = "0x2003E5C")]
    private IReadOnlyList<IntroChapterSequenceData> GetOrderList()
    {
      return (IReadOnlyList<IntroChapterSequenceData>) null;
    }

    [Token(Token = "0x600BEDD")]
    [Address(RVA = "0x200369C", Offset = "0x200369C", VA = "0x200369C")]
    private int GetMaxSequenceValue() => new int();

    [Token(Token = "0x600BEDE")]
    [Address(RVA = "0x2003EDC", Offset = "0x2003EDC", VA = "0x2003EDC")]
    public int GetSkipToHomeTutorialProgressValue() => new int();

    [Token(Token = "0x600BEDF")]
    [Address(RVA = "0x2003B28", Offset = "0x2003B28", VA = "0x2003B28")]
    private IntroChapterSequenceData GetNextSequence(int tagetProgress)
    {
      return (IntroChapterSequenceData) null;
    }

    [Token(Token = "0x600BEE0")]
    [Address(RVA = "0x20037E4", Offset = "0x20037E4", VA = "0x20037E4")]
    private IntroChapterSequenceData GetMatchSequence(int tagetProgress)
    {
      return (IntroChapterSequenceData) null;
    }

    [Token(Token = "0x600BEE1")]
    [Address(RVA = "0x2003F5C", Offset = "0x2003F5C", VA = "0x2003F5C")]
    public bool IsTutorialGachaExecuted() => new bool();

    [Token(Token = "0x600BEE2")]
    [Address(RVA = "0x20034A8", Offset = "0x20034A8", VA = "0x20034A8")]
    public bool IsEnteredHomeTutorial() => new bool();

    [Token(Token = "0x600BEE3")]
    [Address(RVA = "0x2003F74", Offset = "0x2003F74", VA = "0x2003F74")]
    public IntroChapterInfoManager()
    {
    }
  }
}
