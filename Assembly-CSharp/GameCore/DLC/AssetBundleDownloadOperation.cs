// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetBundleDownloadOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x200147B")]
  public class AssetBundleDownloadOperation : AssetBundleOperation
  {
    [Token(Token = "0x4005E30")]
    [FieldOffset(Offset = "0x28")]
    private Action<string> successCallback;
    [Token(Token = "0x4005E31")]
    [FieldOffset(Offset = "0x30")]
    private Action<string> failedCallback;
    [Token(Token = "0x4005E32")]
    [FieldOffset(Offset = "0x38")]
    private List<string> targetFileList;

    [Token(Token = "0x170011A9")]
    public string FileName
    {
      [Token(Token = "0x6007352"), Address(RVA = "0x4057F88", Offset = "0x4057F88", VA = "0x4057F88")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007353"), Address(RVA = "0x4057F90", Offset = "0x4057F90", VA = "0x4057F90")] private set
      {
      }
    }

    [Token(Token = "0x170011AA")]
    public string[] Dependencies
    {
      [Token(Token = "0x6007354"), Address(RVA = "0x4057F98", Offset = "0x4057F98", VA = "0x4057F98")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x6007355"), Address(RVA = "0x4057FA0", Offset = "0x4057FA0", VA = "0x4057FA0")] private set
      {
      }
    }

    [Token(Token = "0x170011AB")]
    private bool IsDownloaded
    {
      [Token(Token = "0x6007356"), Address(RVA = "0x4057FA8", Offset = "0x4057FA8", VA = "0x4057FA8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007357"), Address(RVA = "0x4057FB0", Offset = "0x4057FB0", VA = "0x4057FB0")] set
      {
      }
    }

    [Token(Token = "0x6007358")]
    [Address(RVA = "0x4057FBC", Offset = "0x4057FBC", VA = "0x4057FBC")]
    public AssetBundleDownloadOperation(
      string fileName,
      Action<string> sCallback = null,
      Action<string> fCallback = null,
      string[] dependency = null)
    {
    }

    [Token(Token = "0x6007359")]
    [Address(RVA = "0x405811C", Offset = "0x405811C", VA = "0x405811C", Slot = "7")]
    public override bool Execute() => new bool();

    [Token(Token = "0x600735A")]
    [Address(RVA = "0x4058188", Offset = "0x4058188", VA = "0x4058188", Slot = "8")]
    public override bool IsDone() => new bool();

    [Token(Token = "0x600735B")]
    [Address(RVA = "0x4058190", Offset = "0x4058190", VA = "0x4058190")]
    public void OnDownloadSucceed(string fileName)
    {
    }

    [Token(Token = "0x600735C")]
    [Address(RVA = "0x4058204", Offset = "0x4058204", VA = "0x4058204")]
    public void OnDownloadFailed(string fileName, string error)
    {
    }
  }
}
