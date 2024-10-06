// Decompiled with JetBrains decompiler
// Type: staq.SaveData.DebugSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D08")]
  public class DebugSaveData
  {
    [Token(Token = "0x4010CA2")]
    [FieldOffset(Offset = "0x10")]
    public bool DebugStatusDisplay;
    [Token(Token = "0x4010CA3")]
    [FieldOffset(Offset = "0x11")]
    public bool UseDLC;
    [Token(Token = "0x4010CA4")]
    [FieldOffset(Offset = "0x12")]
    public bool IgnoreSystemLog;
    [Token(Token = "0x4010CA5")]
    [FieldOffset(Offset = "0x13")]
    public bool IgnoreNetworkLog;
    [Token(Token = "0x4010CA6")]
    [FieldOffset(Offset = "0x14")]
    public bool PlayerSaveUsers;
    [Token(Token = "0x4010CA7")]
    [FieldOffset(Offset = "0x15")]
    public bool MeterDisplay;
    [Token(Token = "0x4010CA8")]
    [FieldOffset(Offset = "0x16")]
    public bool ConsoleDisplay;
    [Token(Token = "0x4010CA9")]
    [FieldOffset(Offset = "0x17")]
    public bool ConsoleActive;
    [Token(Token = "0x4010CAA")]
    [FieldOffset(Offset = "0x18")]
    public bool DisableError;
    [Token(Token = "0x4010CAB")]
    [FieldOffset(Offset = "0x19")]
    public bool DisableLogLimit;
    [Token(Token = "0x4010CAC")]
    [FieldOffset(Offset = "0x1C")]
    public int LogLimitNum;
    [Token(Token = "0x4010CAD")]
    [FieldOffset(Offset = "0x20")]
    public bool DebugButtonInvisible;
    [Token(Token = "0x4010CAE")]
    [FieldOffset(Offset = "0x21")]
    public bool DebugButtonPositionEnabled;
    [Token(Token = "0x4010CAF")]
    [FieldOffset(Offset = "0x24")]
    public Vector3 DebugButtonPosition;
    [Token(Token = "0x4010CB0")]
    [FieldOffset(Offset = "0x30")]
    public string ProxyServerName;
    [Token(Token = "0x4010CB1")]
    [FieldOffset(Offset = "0x38")]
    public bool CopyErrorLogs;
    [Token(Token = "0x4010CB2")]
    [FieldOffset(Offset = "0x39")]
    public bool ShowFullDuelAnimation;
    [Token(Token = "0x4010CB3")]
    [FieldOffset(Offset = "0x3C")]
    public int DuelPlaySpeed;
    [Token(Token = "0x4010CB4")]
    [FieldOffset(Offset = "0x40")]
    public bool DebugModeAdv;
    [Token(Token = "0x4010CB5")]
    [FieldOffset(Offset = "0x41")]
    public bool DebugModeAdvTextColor;
    [Token(Token = "0x4010CB6")]
    [FieldOffset(Offset = "0x42")]
    public bool ShowInspector;
    [Token(Token = "0x4010CB7")]
    [FieldOffset(Offset = "0x43")]
    public bool HashCheckEnable;
    [Token(Token = "0x4010CB8")]
    [FieldOffset(Offset = "0x44")]
    public bool IsForceAreaOpen;
    [Token(Token = "0x4010CB9")]
    [FieldOffset(Offset = "0x45")]
    public bool ShowLoadedSoundBank;
    [Token(Token = "0x4010CBA")]
    [FieldOffset(Offset = "0x46")]
    public bool IsForceStoryChartOpen;
    [Token(Token = "0x4010CBB")]
    [FieldOffset(Offset = "0x47")]
    public bool IsRawDataNonCache;
    [Token(Token = "0x4010CBC")]
    [FieldOffset(Offset = "0x48")]
    public bool IsShowGameTime;
    [Token(Token = "0x4010CBD")]
    [FieldOffset(Offset = "0x49")]
    public bool IgnorePreHomeEvent;
    [Token(Token = "0x4010CBE")]
    [FieldOffset(Offset = "0x4A")]
    public bool IgnoreLoginBonus;
    [Token(Token = "0x4010CBF")]
    [FieldOffset(Offset = "0x4B")]
    public bool IgnoreIntroChapter;
    [Token(Token = "0x4010CC0")]
    [FieldOffset(Offset = "0x4C")]
    public bool IsForceAbortFulfillment;
    [Token(Token = "0x4010CC1")]
    [FieldOffset(Offset = "0x4D")]
    public bool loaded;

    [Token(Token = "0x17005020")]
    public static string Path
    {
      [Token(Token = "0x6018872"), Address(RVA = "0x293E218", Offset = "0x293E218", VA = "0x293E218")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018873")]
    [Address(RVA = "0x293E268", Offset = "0x293E268", VA = "0x293E268")]
    public string getPath() => (string) null;

    [Token(Token = "0x6018874")]
    [Address(RVA = "0x293E2B0", Offset = "0x293E2B0", VA = "0x293E2B0")]
    public void delete()
    {
    }

    [Token(Token = "0x6018875")]
    [Address(RVA = "0x293E2C8", Offset = "0x293E2C8", VA = "0x293E2C8")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x6018876")]
    [Address(RVA = "0x293E2F4", Offset = "0x293E2F4", VA = "0x293E2F4")]
    public void load()
    {
    }

    [Token(Token = "0x6018877")]
    [Address(RVA = "0x293E6C8", Offset = "0x293E6C8", VA = "0x293E6C8")]
    public void save()
    {
    }

    [Token(Token = "0x6018878")]
    [Address(RVA = "0x293E940", Offset = "0x293E940", VA = "0x293E940")]
    public DebugSaveData()
    {
    }
  }
}
