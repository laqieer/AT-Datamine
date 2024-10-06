// Decompiled with JetBrains decompiler
// Type: LoginBonus.DebugLoginBonusSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000ABE")]
  internal class DebugLoginBonusSequence : ILoginBonusSequence
  {
    [Token(Token = "0x4003156")]
    [FieldOffset(Offset = "0x18")]
    private LoginBonusRewardHolder loginBonusRewardHolder;
    [Token(Token = "0x4003157")]
    [FieldOffset(Offset = "0x20")]
    private DebugLoginBonusBehaviour loginBonusBehaviour;
    [Token(Token = "0x4003158")]
    [FieldOffset(Offset = "0x28")]
    private string loginBonusTitle;
    [Token(Token = "0x4003159")]
    [FieldOffset(Offset = "0x30")]
    private string startDate;
    [Token(Token = "0x400315A")]
    [FieldOffset(Offset = "0x38")]
    private string endDate;
    [Token(Token = "0x400315B")]
    [FieldOffset(Offset = "0x40")]
    private string prefabName;

    [Token(Token = "0x170008C7")]
    public bool IsFinished
    {
      [Token(Token = "0x6003D1C"), Address(RVA = "0x2C0AA90", Offset = "0x2C0AA90", VA = "0x2C0AA90", Slot = "8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003D1D"), Address(RVA = "0x2C0AA98", Offset = "0x2C0AA98", VA = "0x2C0AA98")] private set
      {
      }
    }

    [Token(Token = "0x170008C8")]
    public bool IsReady
    {
      [Token(Token = "0x6003D1E"), Address(RVA = "0x2C0AAA4", Offset = "0x2C0AAA4", VA = "0x2C0AAA4", Slot = "9")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003D1F"), Address(RVA = "0x2C0AAAC", Offset = "0x2C0AAAC", VA = "0x2C0AAAC")] private set
      {
      }
    }

    [Token(Token = "0x170008C9")]
    public bool IsPrepareStartCalled
    {
      [Token(Token = "0x6003D20"), Address(RVA = "0x2C0AAB8", Offset = "0x2C0AAB8", VA = "0x2C0AAB8", Slot = "7")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003D21"), Address(RVA = "0x2C0AAC0", Offset = "0x2C0AAC0", VA = "0x2C0AAC0")] private set
      {
      }
    }

    [Token(Token = "0x170008CA")]
    public LoginBonusTypeEnum LoginBonusType
    {
      [Token(Token = "0x6003D22"), Address(RVA = "0x2C0AACC", Offset = "0x2C0AACC", VA = "0x2C0AACC", Slot = "10")] get
      {
        return new LoginBonusTypeEnum();
      }
      [Token(Token = "0x6003D23"), Address(RVA = "0x2C0AAD4", Offset = "0x2C0AAD4", VA = "0x2C0AAD4")] private set
      {
      }
    }

    [Token(Token = "0x6003D24")]
    [Address(RVA = "0x2C0AADC", Offset = "0x2C0AADC", VA = "0x2C0AADC", Slot = "4")]
    public void PrepareStart()
    {
    }

    [Token(Token = "0x6003D25")]
    [Address(RVA = "0x2C0AAE8", Offset = "0x2C0AAE8", VA = "0x2C0AAE8", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x6003D26")]
    [Address(RVA = "0x2C0AB78", Offset = "0x2C0AB78", VA = "0x2C0AB78", Slot = "6")]
    public void Release()
    {
    }

    [Token(Token = "0x6003D27")]
    [Address(RVA = "0x2C0AC1C", Offset = "0x2C0AC1C", VA = "0x2C0AC1C")]
    public void Setup(int loginBonusId, int currentNumber)
    {
    }

    [Token(Token = "0x6003D28")]
    [Address(RVA = "0x2C0AE04", Offset = "0x2C0AE04", VA = "0x2C0AE04")]
    private void OnSingleRewardClicked(LoginBonusSingleRewardUIParam uIParam)
    {
    }

    [Token(Token = "0x6003D29")]
    [Address(RVA = "0x2C0AF3C", Offset = "0x2C0AF3C", VA = "0x2C0AF3C")]
    private void OnMultipleRewardClicked(LoginBonusMultipleRewardUIParam uIParam)
    {
    }

    [Token(Token = "0x6003D2A")]
    [Address(RVA = "0x2C0B050", Offset = "0x2C0B050", VA = "0x2C0B050")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x6003D2B")]
    [Address(RVA = "0x2C0B238", Offset = "0x2C0B238", VA = "0x2C0B238")]
    private void DrawLoginBonusTitle()
    {
    }

    [Token(Token = "0x6003D2C")]
    [Address(RVA = "0x2C0B388", Offset = "0x2C0B388", VA = "0x2C0B388")]
    private void DrawSchedule()
    {
    }

    [Token(Token = "0x6003D2D")]
    [Address(RVA = "0x2C0B7C0", Offset = "0x2C0B7C0", VA = "0x2C0B7C0")]
    private void DrawRewardList()
    {
    }

    [Token(Token = "0x6003D2E")]
    [Address(RVA = "0x2C0BD6C", Offset = "0x2C0BD6C", VA = "0x2C0BD6C")]
    private void DrawReward(ILoginBonusRewardUIParam reward)
    {
    }

    [Token(Token = "0x6003D2F")]
    [Address(RVA = "0x2C0BC5C", Offset = "0x2C0BC5C", VA = "0x2C0BC5C")]
    private void DrawCloseButton()
    {
    }

    [Token(Token = "0x6003D30")]
    [Address(RVA = "0x2C0BD2C", Offset = "0x2C0BD2C", VA = "0x2C0BD2C")]
    private int GetColumnFitnessNum(int value, int limit) => new int();

    [Token(Token = "0x6003D31")]
    [Address(RVA = "0x2C0C1E8", Offset = "0x2C0C1E8", VA = "0x2C0C1E8")]
    public DebugLoginBonusSequence()
    {
    }
  }
}
