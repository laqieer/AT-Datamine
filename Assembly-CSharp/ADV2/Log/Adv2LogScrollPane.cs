// Decompiled with JetBrains decompiler
// Type: ADV2.Log.Adv2LogScrollPane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2.Log
{
  [Token(Token = "0x2003E90")]
  public class Adv2LogScrollPane : UIScrollGridPane
  {
    [Token(Token = "0x401128E")]
    [FieldOffset(Offset = "0x88")]
    private List<Adv2LogScrollPane.LogData> logList;
    [Token(Token = "0x401128F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Adv2LogScrollCell ListParts;
    [Token(Token = "0x4011290")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private UITweenGroup tweenRoot;
    [Token(Token = "0x4011291")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CapturedBlurTexture backImage;
    [Token(Token = "0x4011292")]
    [FieldOffset(Offset = "0xA8")]
    private bool addLogFlag;

    [Token(Token = "0x60192EF")]
    [Address(RVA = "0x2D02A88", Offset = "0x2D02A88", VA = "0x2D02A88")]
    public void AddLog(
      int WinType,
      string Talker,
      string ThumbImageTag,
      string Message,
      string VoiceTag,
      bool isPlayer)
    {
    }

    [Token(Token = "0x60192F0")]
    [Address(RVA = "0x2D02C30", Offset = "0x2D02C30", VA = "0x2D02C30", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x60192F1")]
    [Address(RVA = "0x2D02CB0", Offset = "0x2D02CB0", VA = "0x2D02CB0", Slot = "5")]
    protected override void OnScroll(Vector2 value)
    {
    }

    [Token(Token = "0x60192F2")]
    [Address(RVA = "0x2D02CBC", Offset = "0x2D02CBC", VA = "0x2D02CBC", Slot = "7")]
    protected override void OnModifyItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x60192F3")]
    [Address(RVA = "0x2D02D70", Offset = "0x2D02D70", VA = "0x2D02D70")]
    public void ClearLogList()
    {
    }

    [Token(Token = "0x60192F4")]
    [Address(RVA = "0x2D02DE4", Offset = "0x2D02DE4", VA = "0x2D02DE4")]
    public bool CheckPlayerTag(string TalkerTag) => new bool();

    [Token(Token = "0x60192F5")]
    [Address(RVA = "0x2D02E44", Offset = "0x2D02E44", VA = "0x2D02E44")]
    public void OpenAdvLog(bool openflag)
    {
    }

    [Token(Token = "0x60192F6")]
    [Address(RVA = "0x2D02E68", Offset = "0x2D02E68", VA = "0x2D02E68")]
    private IEnumerator OpenAdvCoroutine(bool openflag) => (IEnumerator) null;

    [Token(Token = "0x60192F7")]
    [Address(RVA = "0x2D02F0C", Offset = "0x2D02F0C", VA = "0x2D02F0C")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x60192F8")]
    [Address(RVA = "0x2D02F44", Offset = "0x2D02F44", VA = "0x2D02F44")]
    public Adv2LogScrollPane()
    {
    }

    [Token(Token = "0x2003E91")]
    public class LogData
    {
      [Token(Token = "0x4011293")]
      [FieldOffset(Offset = "0x10")]
      public int WinType;
      [Token(Token = "0x4011294")]
      [FieldOffset(Offset = "0x18")]
      public string Talker;
      [Token(Token = "0x4011295")]
      [FieldOffset(Offset = "0x20")]
      public string ThumbImageTag;
      [Token(Token = "0x4011296")]
      [FieldOffset(Offset = "0x28")]
      public string Message;
      [Token(Token = "0x4011297")]
      [FieldOffset(Offset = "0x30")]
      public string VoiceTag;
      [Token(Token = "0x4011298")]
      [FieldOffset(Offset = "0x38")]
      public bool isPlayer;

      [Token(Token = "0x60192F9")]
      [Address(RVA = "0x2D02BD4", Offset = "0x2D02BD4", VA = "0x2D02BD4")]
      public LogData()
      {
      }

      [Token(Token = "0x2003E92")]
      public enum WindowType
      {
        [Token(Token = "0x401129A")] WinType_NULL,
        [Token(Token = "0x401129B")] WinType_Speech,
        [Token(Token = "0x401129C")] WinType_Mind,
        [Token(Token = "0x401129D")] WinType_Narration,
        [Token(Token = "0x401129E")] WinType_Simple,
        [Token(Token = "0x401129F")] WinType_Choice,
      }
    }
  }
}
