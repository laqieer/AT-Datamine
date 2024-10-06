// Decompiled with JetBrains decompiler
// Type: GameCore.AppQualitySettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BBB")]
  public class AppQualitySettings : SingletonMonoBehaviour<AppQualitySettings>
  {
    [Token(Token = "0x4003576")]
    [FieldOffset(Offset = "0x19")]
    private bool isVeryLowMemory;
    [Token(Token = "0x4003577")]
    [FieldOffset(Offset = "0x1A")]
    private bool isLowSpecDevice;
    [Token(Token = "0x4003578")]
    [FieldOffset(Offset = "0x1B")]
    private bool isFrequentMemoryGC;
    [Token(Token = "0x4003579")]
    [FieldOffset(Offset = "0x1C")]
    private AppQualitySettings.QualityType currentQualityType;
    [Token(Token = "0x400357A")]
    [FieldOffset(Offset = "0x20")]
    private int currentFPS;
    [Token(Token = "0x400357B")]
    [FieldOffset(Offset = "0x24")]
    private bool isChangeLoadingFPS;
    [Token(Token = "0x400357C")]
    [FieldOffset(Offset = "0x25")]
    public bool IsDefaultSettings;
    [Token(Token = "0x400357D")]
    [FieldOffset(Offset = "0x26")]
    private bool isNonUIPostProcessDevice;
    [Token(Token = "0x400357E")]
    private const float lowestFps = 15f;
    [Token(Token = "0x400357F")]
    [FieldOffset(Offset = "0x28")]
    private int defDisplayWidth;
    [Token(Token = "0x4003580")]
    [FieldOffset(Offset = "0x2C")]
    private int defDisplayHeight;
    [Token(Token = "0x4003581")]
    private const int minimuLowResolutionWidth = 1000;
    [Token(Token = "0x4003582")]
    private const int minimuMidResolutionWidth = 1334;
    [Token(Token = "0x4003583")]
    [FieldOffset(Offset = "0x30")]
    private int minimuResolutionWidth;
    [Token(Token = "0x4003584")]
    [FieldOffset(Offset = "0x34")]
    private bool isForceOndemandRendering;

    [Token(Token = "0x170009AF")]
    public bool IsVeryLowMemory
    {
      [Token(Token = "0x60042F9"), Address(RVA = "0x363DA00", Offset = "0x363DA00", VA = "0x363DA00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170009B0")]
    public bool IsLowSpecDevice
    {
      [Token(Token = "0x60042FA"), Address(RVA = "0x363DA08", Offset = "0x363DA08", VA = "0x363DA08")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170009B1")]
    public bool IsFrequentMemoryGC
    {
      [Token(Token = "0x60042FB"), Address(RVA = "0x363DA10", Offset = "0x363DA10", VA = "0x363DA10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170009B2")]
    public AppQualitySettings.QualityType CurrentQualityType
    {
      [Token(Token = "0x60042FC"), Address(RVA = "0x363DA18", Offset = "0x363DA18", VA = "0x363DA18")] get
      {
        return new AppQualitySettings.QualityType();
      }
    }

    [Token(Token = "0x170009B3")]
    public int CurrentFPS
    {
      [Token(Token = "0x60042FD"), Address(RVA = "0x363DA20", Offset = "0x363DA20", VA = "0x363DA20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60042FE")]
    [Address(RVA = "0x363DA28", Offset = "0x363DA28", VA = "0x363DA28", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x60042FF")]
    [Address(RVA = "0x3639B88", Offset = "0x3639B88", VA = "0x3639B88")]
    public void SetupPerformanceConfig(AppQualitySettings.QualityType qualityType)
    {
    }

    [Token(Token = "0x6004300")]
    [Address(RVA = "0x3639DDC", Offset = "0x3639DDC", VA = "0x3639DDC")]
    public void SetupFPS(int fps, bool isCurrentUpdate = true)
    {
    }

    [Token(Token = "0x6004301")]
    [Address(RVA = "0x363DF00", Offset = "0x363DF00", VA = "0x363DF00")]
    public void SetupCurrentFPS(int fps)
    {
    }

    [Token(Token = "0x6004302")]
    [Address(RVA = "0x363DF18", Offset = "0x363DF18", VA = "0x363DF18")]
    public void ChangeLoadingFPS(bool isEnable)
    {
    }

    [Token(Token = "0x6004303")]
    [Address(RVA = "0x363DFB8", Offset = "0x363DFB8", VA = "0x363DFB8")]
    public void SetOnDemandRendering(int interval, bool isForce = true)
    {
    }

    [Token(Token = "0x6004304")]
    [Address(RVA = "0x363E044", Offset = "0x363E044", VA = "0x363E044")]
    public void SetDebugVeryLowMemory(bool isLow)
    {
    }

    [Token(Token = "0x6004305")]
    [Address(RVA = "0x363E054", Offset = "0x363E054", VA = "0x363E054")]
    public float GetDynamicBoneLodDistance() => new float();

    [Token(Token = "0x6004306")]
    [Address(RVA = "0x363E06C", Offset = "0x363E06C", VA = "0x363E06C")]
    public bool IsUIPostProcessEnable(bool isForceEnable) => new bool();

    [Token(Token = "0x6004307")]
    [Address(RVA = "0x363BF74", Offset = "0x363BF74", VA = "0x363BF74")]
    public int GetAssetCacheMax() => new int();

    [Token(Token = "0x6004308")]
    [Address(RVA = "0x363E094", Offset = "0x363E094", VA = "0x363E094")]
    public int GetAssetLoadingMax() => new int();

    [Token(Token = "0x6004309")]
    [Address(RVA = "0x363DDB0", Offset = "0x363DDB0", VA = "0x363DDB0")]
    private void SetupHardSpec()
    {
    }

    [Token(Token = "0x600430A")]
    [Address(RVA = "0x363DE40", Offset = "0x363DE40", VA = "0x363DE40")]
    public AppQualitySettings.QualityType GetDefaultPerformanceType()
    {
      return new AppQualitySettings.QualityType();
    }

    [Token(Token = "0x600430B")]
    [Address(RVA = "0x363E0A8", Offset = "0x363E0A8", VA = "0x363E0A8")]
    public int GetDefaultFPS() => new int();

    [Token(Token = "0x600430C")]
    [Address(RVA = "0x363E0B0", Offset = "0x363E0B0", VA = "0x363E0B0")]
    public void SetQualityUpMSAA(bool isUpdate)
    {
    }

    [Token(Token = "0x600430D")]
    [Address(RVA = "0x363DE74", Offset = "0x363DE74", VA = "0x363DE74")]
    private void SetResolution(float scale)
    {
    }

    [Token(Token = "0x600430E")]
    [Address(RVA = "0x363E1B0", Offset = "0x363E1B0", VA = "0x363E1B0")]
    public AppQualitySettings()
    {
    }

    [Token(Token = "0x2000BBC")]
    public enum QualityType
    {
      [Token(Token = "0x4003586")] Default,
      [Token(Token = "0x4003587")] Low,
      [Token(Token = "0x4003588")] Middle,
      [Token(Token = "0x4003589")] Hi,
    }
  }
}
