// Decompiled with JetBrains decompiler
// Type: Home.HomeVoiceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B54")]
  public class HomeVoiceManager
  {
    [Token(Token = "0x40033C7")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, HomeVoicePack> defaultSerifs;
    [Token(Token = "0x40033C8")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, HomeVoicePack> soliloquySerifs;
    [Token(Token = "0x40033C9")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, HomeVoicePack> seasonSerifs;
    [Token(Token = "0x40033CA")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<int, HomeVoicePack> timeAnnouncementSerifs;
    [Token(Token = "0x40033CB")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<int, HomeVoicePack> loginBonusSerifs;

    [Token(Token = "0x600408D")]
    [Address(RVA = "0x2A27748", Offset = "0x2A27748", VA = "0x2A27748")]
    public HomeVoicePack GetVoicePack(int styleId, HomeCharacterSerifType serifType)
    {
      return (HomeVoicePack) null;
    }

    [Token(Token = "0x600408E")]
    [Address(RVA = "0x2A27870", Offset = "0x2A27870", VA = "0x2A27870")]
    public void Initialize(List<int> styleIdList)
    {
    }

    [Token(Token = "0x600408F")]
    [Address(RVA = "0x2A27A30", Offset = "0x2A27A30", VA = "0x2A27A30")]
    private void LoadSerifMasterData(int styleId)
    {
    }

    [Token(Token = "0x6004090")]
    [Address(RVA = "0x2A28288", Offset = "0x2A28288", VA = "0x2A28288")]
    private List<string> CreateVoicePackList() => (List<string>) null;

    [Token(Token = "0x6004091")]
    [Address(RVA = "0x2A28E0C", Offset = "0x2A28E0C", VA = "0x2A28E0C")]
    private HomeVoicePack PackSerifs(List<HomeSerifDescriptionData> serifList)
    {
      return (HomeVoicePack) null;
    }

    [Token(Token = "0x6004092")]
    [Address(RVA = "0x2A28C68", Offset = "0x2A28C68", VA = "0x2A28C68")]
    private void LoadVoicePack(List<string> voicePackList)
    {
    }

    [Token(Token = "0x6004093")]
    [Address(RVA = "0x2A2905C", Offset = "0x2A2905C", VA = "0x2A2905C")]
    public HomeVoiceManager()
    {
    }
  }
}
