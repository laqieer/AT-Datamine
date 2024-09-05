// Decompiled with JetBrains decompiler
// Type: StaqTools.TimelinePreview.PreviewMovieConroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using TMPro;

#nullable disable
namespace StaqTools.TimelinePreview
{
  [Token(Token = "0x2000365")]
  public class PreviewMovieConroller : SingletonMonoBehaviour<PreviewMovieConroller>
  {
    [Token(Token = "0x4001400")]
    [FieldOffset(Offset = "0x20")]
    public RubyTextMeshProUGUI talkerText;
    [Token(Token = "0x4001401")]
    [FieldOffset(Offset = "0x28")]
    public RubyTextMeshProUGUI messageText;
    [Token(Token = "0x4001402")]
    [FieldOffset(Offset = "0x30")]
    public Dictionary<string, string> textAssetPathDic;

    [Token(Token = "0x600137D")]
    [Address(RVA = "0x286B818", Offset = "0x286B818", VA = "0x286B818", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x600137E")]
    [Address(RVA = "0x286B64C", Offset = "0x286B64C", VA = "0x286B64C")]
    public void AddAssetTextPath(string oriPath)
    {
    }

    [Token(Token = "0x600137F")]
    [Address(RVA = "0x286B894", Offset = "0x286B894", VA = "0x286B894")]
    public void SetMessage(string talkerKey, string messageKey)
    {
    }

    [Token(Token = "0x6001380")]
    [Address(RVA = "0x286B81C", Offset = "0x286B81C", VA = "0x286B81C")]
    public void ClearMessage()
    {
    }

    [Token(Token = "0x6001381")]
    [Address(RVA = "0x286B760", Offset = "0x286B760", VA = "0x286B760")]
    public IEnumerator LoadTextAsset() => (IEnumerator) null;

    [Token(Token = "0x6001382")]
    [Address(RVA = "0x286BB9C", Offset = "0x286BB9C", VA = "0x286BB9C")]
    public PreviewMovieConroller()
    {
    }
  }
}
