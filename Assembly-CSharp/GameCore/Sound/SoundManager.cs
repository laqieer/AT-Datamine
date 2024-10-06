// Decompiled with JetBrains decompiler
// Type: GameCore.Sound.SoundManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace GameCore.Sound
{
  [Token(Token = "0x2000C42")]
  public class SoundManager : SingletonMonoBehaviour<SoundManager>
  {
    [Token(Token = "0x400378D")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int BgmMax;
    [Token(Token = "0x400378E")]
    [FieldOffset(Offset = "0x4")]
    private static readonly int SEMax;
    [Token(Token = "0x400378F")]
    [FieldOffset(Offset = "0x8")]
    private static readonly int VoiceMax;
    [Token(Token = "0x4003791")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<string, PackInfo> packIDDic;
    [Token(Token = "0x4003792")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<string, BankInfo> bankIDDic;
    [Token(Token = "0x4003793")]
    [FieldOffset(Offset = "0x38")]
    private List<PlaySoundInfo> playBgmInfo;
    [Token(Token = "0x4003794")]
    [FieldOffset(Offset = "0x40")]
    private List<PlaySoundInfo> playSeInfo;
    [Token(Token = "0x4003795")]
    [FieldOffset(Offset = "0x48")]
    private List<PlaySoundInfo> playVoiceInfo;
    [Token(Token = "0x4003796")]
    [FieldOffset(Offset = "0x50")]
    private AkAudioListener bootAudioListener;
    [Token(Token = "0x4003797")]
    [FieldOffset(Offset = "0x58")]
    private List<string> requestUnloadPackFileList;
    [Token(Token = "0x4003798")]
    [FieldOffset(Offset = "0x60")]
    private bool isAppPause;

    [Token(Token = "0x17000A34")]
    public string currentBGMName
    {
      [Token(Token = "0x6004670"), Address(RVA = "0x3516C8C", Offset = "0x3516C8C", VA = "0x3516C8C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004671"), Address(RVA = "0x3516C94", Offset = "0x3516C94", VA = "0x3516C94")] private set
      {
      }
    }

    [Token(Token = "0x6004672")]
    [Address(RVA = "0x3516C9C", Offset = "0x3516C9C", VA = "0x3516C9C", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6004673")]
    [Address(RVA = "0x35171F0", Offset = "0x35171F0", VA = "0x35171F0")]
    public void SetVolume(string busName, float volume)
    {
    }

    [Token(Token = "0x6004674")]
    [Address(RVA = "0x351725C", Offset = "0x351725C", VA = "0x351725C")]
    public void ChangeBootAudioListener(bool enable)
    {
    }

    [Token(Token = "0x6004675")]
    [Address(RVA = "0x35172F4", Offset = "0x35172F4", VA = "0x35172F4")]
    private void OnApplicationPause(bool pause)
    {
    }

    [Token(Token = "0x6004676")]
    [Address(RVA = "0x35172FC", Offset = "0x35172FC", VA = "0x35172FC")]
    private void SetApplicationPauseBGM(bool pause)
    {
    }

    [Token(Token = "0x6004677")]
    [Address(RVA = "0x3517138", Offset = "0x3517138", VA = "0x3517138")]
    public void SetFileDirectory(string path)
    {
    }

    [Token(Token = "0x6004678")]
    [Address(RVA = "0x35177CC", Offset = "0x35177CC", VA = "0x35177CC")]
    public void StopAll()
    {
    }

    [Token(Token = "0x6004679")]
    [Address(RVA = "0x3517B30", Offset = "0x3517B30", VA = "0x3517B30")]
    public void Update()
    {
    }

    [Token(Token = "0x600467A")]
    [Address(RVA = "0x3517D2C", Offset = "0x3517D2C", VA = "0x3517D2C")]
    public bool IsBgmActive(string name) => new bool();

    [Token(Token = "0x600467B")]
    [Address(RVA = "0x3517E1C", Offset = "0x3517E1C", VA = "0x3517E1C")]
    public bool IsBattleBgmActive() => new bool();

    [Token(Token = "0x600467C")]
    [Address(RVA = "0x3517FD4", Offset = "0x3517FD4", VA = "0x3517FD4")]
    public bool IsVoiceActive(string name) => new bool();

    [Token(Token = "0x600467D")]
    [Address(RVA = "0x35180C4", Offset = "0x35180C4", VA = "0x35180C4")]
    public bool IsSeActive(string name) => new bool();

    [Token(Token = "0x600467E")]
    [Address(RVA = "0x35181B4", Offset = "0x35181B4", VA = "0x35181B4")]
    public void UnLoadALL(bool forceAllFile = true)
    {
    }

    [Token(Token = "0x600467F")]
    [Address(RVA = "0x3518B80", Offset = "0x3518B80", VA = "0x3518B80")]
    public bool LoadBank(string name, bool isReside = false) => new bool();

    [Token(Token = "0x6004680")]
    [Address(RVA = "0x3518D68", Offset = "0x3518D68", VA = "0x3518D68")]
    public bool LoadFromMemory(byte[] dataBuf, int dataSize, string name) => new bool();

    [Token(Token = "0x6004681")]
    [Address(RVA = "0x3518F54", Offset = "0x3518F54", VA = "0x3518F54")]
    public bool IsLoadStartedPackFile(string fileName) => new bool();

    [Token(Token = "0x6004682")]
    [Address(RVA = "0x3518FAC", Offset = "0x3518FAC", VA = "0x3518FAC")]
    public bool LoadPackFile(string fileName, bool isReside = false) => new bool();

    [Token(Token = "0x6004683")]
    [Address(RVA = "0x3518A1C", Offset = "0x3518A1C", VA = "0x3518A1C")]
    private bool UnloadBank(string name) => new bool();

    [Token(Token = "0x6004684")]
    [Address(RVA = "0x3519280", Offset = "0x3519280", VA = "0x3519280")]
    public void RequestUnLoadPackFile(string fileName)
    {
    }

    [Token(Token = "0x6004685")]
    [Address(RVA = "0x3519328", Offset = "0x3519328", VA = "0x3519328")]
    public void RequestUnLoadPackAllFile()
    {
    }

    [Token(Token = "0x6004686")]
    [Address(RVA = "0x35196B0", Offset = "0x35196B0", VA = "0x35196B0")]
    public void StartRequestUnLoadFile()
    {
    }

    [Token(Token = "0x6004687")]
    [Address(RVA = "0x3518898", Offset = "0x3518898", VA = "0x3518898")]
    public bool UnLoadPackFile(string fileName) => new bool();

    [Token(Token = "0x6004688")]
    [Address(RVA = "0x3519828", Offset = "0x3519828", VA = "0x3519828")]
    public void PreLoadAndPlayBGM(string preBGMBank, string preBGMEvent, string preLoadVoiceBank)
    {
    }

    [Token(Token = "0x6004689")]
    [Address(RVA = "0x3519954", Offset = "0x3519954", VA = "0x3519954")]
    private uint PlaySoundForSEAndVoice(
      string name,
      List<PlaySoundInfo> infoList,
      uint flags,
      AkCallbackManager.EventCallback eventCallback)
    {
      return new uint();
    }

    [Token(Token = "0x600468A")]
    [Address(RVA = "0x3519ADC", Offset = "0x3519ADC", VA = "0x3519ADC")]
    private uint PlaySoundForBGM(
      string name,
      List<PlaySoundInfo> infoList,
      uint flags,
      AkCallbackManager.EventCallback eventCallback)
    {
      return new uint();
    }

    [Token(Token = "0x600468B")]
    [Address(RVA = "0x3519DE0", Offset = "0x3519DE0", VA = "0x3519DE0")]
    private void StopSound(
      PlaySoundInfo playSoundInfo,
      int duration = 0,
      AkCurveInterpolation feadCurve = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x600468C")]
    [Address(RVA = "0x3519E8C", Offset = "0x3519E8C", VA = "0x3519E8C")]
    private void PauseSound(PlaySoundInfo playSoundInfo)
    {
    }

    [Token(Token = "0x600468D")]
    [Address(RVA = "0x3519E98", Offset = "0x3519E98", VA = "0x3519E98")]
    private void PauseSound(
      PlaySoundInfo playSoundInfo,
      int transitionDuration,
      AkCurveInterpolation curveInterpolation)
    {
    }

    [Token(Token = "0x600468E")]
    [Address(RVA = "0x3519F44", Offset = "0x3519F44", VA = "0x3519F44")]
    private void ResumeSound(PlaySoundInfo playSoundInfo)
    {
    }

    [Token(Token = "0x600468F")]
    [Address(RVA = "0x3519F50", Offset = "0x3519F50", VA = "0x3519F50")]
    private void ResumeSound(
      PlaySoundInfo playSoundInfo,
      int transitionDuration,
      AkCurveInterpolation curveInterpolation)
    {
    }

    [Token(Token = "0x6004690")]
    [Address(RVA = "0x3519FFC", Offset = "0x3519FFC", VA = "0x3519FFC")]
    public void StopEnvironmentalSound()
    {
    }

    [Token(Token = "0x6004691")]
    [Address(RVA = "0x351A080", Offset = "0x351A080", VA = "0x351A080")]
    public void StopPlaySoundInfo(List<PlaySoundInfo> checkList, uint playingID, float secDuration = 0.0f)
    {
    }

    [Token(Token = "0x6004692")]
    [Address(RVA = "0x351A204", Offset = "0x351A204", VA = "0x351A204")]
    private IEnumerator SetRtpcProc(string name, float start, float end, float duration)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004693")]
    [Address(RVA = "0x351A2B8", Offset = "0x351A2B8", VA = "0x351A2B8")]
    public void SetRtpc(string name, float start, float end, float duration)
    {
    }

    [Token(Token = "0x6004694")]
    [Address(RVA = "0x35171F4", Offset = "0x35171F4", VA = "0x35171F4")]
    public void SetRtpcValue(string name, float value)
    {
    }

    [Token(Token = "0x6004695")]
    [Address(RVA = "0x351A2E4", Offset = "0x351A2E4", VA = "0x351A2E4")]
    public void SetRtpcByPlayingID(
      string name,
      float start,
      float end,
      float duration,
      uint playingID)
    {
    }

    [Token(Token = "0x6004696")]
    [Address(RVA = "0x351A3E4", Offset = "0x351A3E4", VA = "0x351A3E4")]
    public AKRESULT GetRtpcValue(string rtpcName, uint playingID, out float outValue, int refType)
    {
      return new AKRESULT();
    }

    [Token(Token = "0x6004697")]
    [Address(RVA = "0x35198BC", Offset = "0x35198BC", VA = "0x35198BC")]
    public uint PlayBGM(string name) => new uint();

    [Token(Token = "0x6004698")]
    [Address(RVA = "0x351A484", Offset = "0x351A484", VA = "0x351A484")]
    public uint PlayBGM(string name, uint flags, AkCallbackManager.EventCallback callback)
    {
      return new uint();
    }

    [Token(Token = "0x6004699")]
    [Address(RVA = "0x351A564", Offset = "0x351A564", VA = "0x351A564")]
    public uint PlayCrossBGM(string name, int duration = 0, AkCurveInterpolation feadCurve = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
      return new uint();
    }

    [Token(Token = "0x600469A")]
    [Address(RVA = "0x3517804", Offset = "0x3517804", VA = "0x3517804")]
    public void StopBGMAll(int duration = 1000, AkCurveInterpolation feadCurve = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x600469B")]
    [Address(RVA = "0x351A7B0", Offset = "0x351A7B0", VA = "0x351A7B0")]
    public void StopMuteBGM()
    {
    }

    [Token(Token = "0x600469C")]
    [Address(RVA = "0x351A674", Offset = "0x351A674", VA = "0x351A674")]
    public void StopBGM(string name, int duration = 0, AkCurveInterpolation feadCurve = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x600469D")]
    [Address(RVA = "0x351A89C", Offset = "0x351A89C", VA = "0x351A89C")]
    public void StopBGM(uint playingID, float duration = 0.0f)
    {
    }

    [Token(Token = "0x600469E")]
    [Address(RVA = "0x3517364", Offset = "0x3517364", VA = "0x3517364")]
    public void PauseBGM()
    {
    }

    [Token(Token = "0x600469F")]
    [Address(RVA = "0x351A8AC", Offset = "0x351A8AC", VA = "0x351A8AC")]
    public void PauseBGM(
      string name,
      int transitionDuration = 0,
      AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046A0")]
    [Address(RVA = "0x3517598", Offset = "0x3517598", VA = "0x3517598")]
    public void ResumeBGM()
    {
    }

    [Token(Token = "0x60046A1")]
    [Address(RVA = "0x351A98C", Offset = "0x351A98C", VA = "0x351A98C")]
    public void ResumeBGM(
      string name,
      int transitionDuration = 0,
      AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046A2")]
    [Address(RVA = "0x351AA6C", Offset = "0x351AA6C", VA = "0x351AA6C")]
    public List<string> GetPlayingBGMName() => (List<string>) null;

    [Token(Token = "0x60046A3")]
    [Address(RVA = "0x351AC90", Offset = "0x351AC90", VA = "0x351AC90")]
    public uint PlaySE(string name, Action callback = null) => new uint();

    [Token(Token = "0x60046A4")]
    [Address(RVA = "0x351AD64", Offset = "0x351AD64", VA = "0x351AD64")]
    public uint PlaySE(string name, uint flags, AkCallbackManager.EventCallback callback)
    {
      return new uint();
    }

    [Token(Token = "0x60046A5")]
    [Address(RVA = "0x3517934", Offset = "0x3517934", VA = "0x3517934")]
    public void StopSEAll(int duration = 0, AkCurveInterpolation feadCurve = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046A6")]
    [Address(RVA = "0x351AE44", Offset = "0x351AE44", VA = "0x351AE44")]
    public void StopSE(string name, int duration = 0, AkCurveInterpolation feadCurve = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046A7")]
    [Address(RVA = "0x351AF24", Offset = "0x351AF24", VA = "0x351AF24")]
    public void StopSE(uint playingID)
    {
    }

    [Token(Token = "0x60046A8")]
    [Address(RVA = "0x3517420", Offset = "0x3517420", VA = "0x3517420")]
    public void PauseSE()
    {
    }

    [Token(Token = "0x60046A9")]
    [Address(RVA = "0x351AF38", Offset = "0x351AF38", VA = "0x351AF38")]
    public void PauseSE(
      string name,
      int transitionDuration = 0,
      AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046AA")]
    [Address(RVA = "0x3517654", Offset = "0x3517654", VA = "0x3517654")]
    public void ResumeSE()
    {
    }

    [Token(Token = "0x60046AB")]
    [Address(RVA = "0x351B018", Offset = "0x351B018", VA = "0x351B018")]
    public void ResumeSE(
      string name,
      int transitionDuration = 0,
      AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046AC")]
    [Address(RVA = "0x351B0F8", Offset = "0x351B0F8", VA = "0x351B0F8")]
    public uint PlayVoice(
      string name,
      LuaSequence.SoundSignal soundSignal = null,
      Action voiceEndCallBack = null)
    {
      return new uint();
    }

    [Token(Token = "0x60046AD")]
    [Address(RVA = "0x351B1DC", Offset = "0x351B1DC", VA = "0x351B1DC")]
    public uint PlayVoice(string name, uint flags, AkCallbackManager.EventCallback callback)
    {
      return new uint();
    }

    [Token(Token = "0x60046AE")]
    [Address(RVA = "0x3517A00", Offset = "0x3517A00", VA = "0x3517A00")]
    public void StopVoiceAll(int duration = 0, AkCurveInterpolation feadCurve = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046AF")]
    [Address(RVA = "0x351B328", Offset = "0x351B328", VA = "0x351B328")]
    public void StopVoice(string name, int duration = 0, AkCurveInterpolation feadCurve = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046B0")]
    [Address(RVA = "0x35174DC", Offset = "0x35174DC", VA = "0x35174DC")]
    public void PauseVoice()
    {
    }

    [Token(Token = "0x60046B1")]
    [Address(RVA = "0x351B464", Offset = "0x351B464", VA = "0x351B464")]
    public void StopVoice(uint playingID)
    {
    }

    [Token(Token = "0x60046B2")]
    [Address(RVA = "0x351B478", Offset = "0x351B478", VA = "0x351B478")]
    public void PauseVoice(
      string name,
      int transitionDuration = 0,
      AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046B3")]
    [Address(RVA = "0x3517710", Offset = "0x3517710", VA = "0x3517710")]
    public void ResumeVoice()
    {
    }

    [Token(Token = "0x60046B4")]
    [Address(RVA = "0x351B558", Offset = "0x351B558", VA = "0x351B558")]
    public void ResumeVoice(
      string name,
      int transitionDuration = 0,
      AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x60046B5")]
    [Address(RVA = "0x351B638", Offset = "0x351B638", VA = "0x351B638")]
    public void PostEvent(string eventName)
    {
    }

    [Token(Token = "0x60046B6")]
    [Address(RVA = "0x351B6B4", Offset = "0x351B6B4", VA = "0x351B6B4")]
    public SoundManager()
    {
    }

    [Token(Token = "0x60046B7")]
    [Address(RVA = "0x351B8AC", Offset = "0x351B8AC", VA = "0x351B8AC")]
    static SoundManager()
    {
    }

    [Token(Token = "0x2000C43")]
    public class BusName
    {
      [Token(Token = "0x4003799")]
      public const string BGM = "BGM_Bus_Volume";
      [Token(Token = "0x400379A")]
      public const string SE = "SE_Bus_Volume";
      [Token(Token = "0x400379B")]
      public const string VOICE = "Voice_Bus_Volume";

      [Token(Token = "0x60046B9")]
      [Address(RVA = "0x351BAD8", Offset = "0x351BAD8", VA = "0x351BAD8")]
      public BusName()
      {
      }
    }
  }
}
