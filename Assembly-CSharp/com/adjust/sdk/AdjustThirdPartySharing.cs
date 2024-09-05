// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustThirdPartySharing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FF9")]
  public class AdjustThirdPartySharing
  {
    [Token(Token = "0x401188E")]
    [FieldOffset(Offset = "0x10")]
    internal bool? isEnabled;
    [Token(Token = "0x401188F")]
    [FieldOffset(Offset = "0x18")]
    internal Dictionary<string, List<string>> granularOptions;
    [Token(Token = "0x4011890")]
    [FieldOffset(Offset = "0x20")]
    internal Dictionary<string, List<string>> partnerSharingSettings;

    [Token(Token = "0x6019C4E")]
    [Address(RVA = "0x3B3C098", Offset = "0x3B3C098", VA = "0x3B3C098")]
    public AdjustThirdPartySharing(bool? isEnabled)
    {
    }

    [Token(Token = "0x6019C4F")]
    [Address(RVA = "0x3B3C144", Offset = "0x3B3C144", VA = "0x3B3C144")]
    public void addGranularOption(string partnerName, string key, string value)
    {
    }

    [Token(Token = "0x6019C50")]
    [Address(RVA = "0x3B3C328", Offset = "0x3B3C328", VA = "0x3B3C328")]
    public void addPartnerSharingSetting(string partnerName, string key, bool value)
    {
    }
  }
}
