// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetBundleLoadAssetOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x2001484")]
  public class AssetBundleLoadAssetOperation : AssetBundleOperation
  {
    [Token(Token = "0x4005E41")]
    [FieldOffset(Offset = "0x30")]
    private Action<string> successCallback;
    [Token(Token = "0x4005E42")]
    [FieldOffset(Offset = "0x38")]
    private Action<string> failedCallback;

    [Token(Token = "0x170011AC")]
    public string FileName
    {
      [Token(Token = "0x6007367"), Address(RVA = "0x4058710", Offset = "0x4058710", VA = "0x4058710")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007368"), Address(RVA = "0x4058718", Offset = "0x4058718", VA = "0x4058718")] private set
      {
      }
    }

    [Token(Token = "0x170011AD")]
    public List<string> TargetFileList
    {
      [Token(Token = "0x6007369"), Address(RVA = "0x4058720", Offset = "0x4058720", VA = "0x4058720")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x600736A"), Address(RVA = "0x4058728", Offset = "0x4058728", VA = "0x4058728")] private set
      {
      }
    }

    [Token(Token = "0x170011AE")]
    public string LoadError
    {
      [Token(Token = "0x600736B"), Address(RVA = "0x4058730", Offset = "0x4058730", VA = "0x4058730")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600736C"), Address(RVA = "0x4058738", Offset = "0x4058738", VA = "0x4058738")] private set
      {
      }
    }

    [Token(Token = "0x170011AF")]
    private AssetBundleRequest AssetBundleRequest
    {
      [Token(Token = "0x600736D"), Address(RVA = "0x4058740", Offset = "0x4058740", VA = "0x4058740")] get
      {
        return (AssetBundleRequest) null;
      }
      [Token(Token = "0x600736E"), Address(RVA = "0x4058748", Offset = "0x4058748", VA = "0x4058748")] set
      {
      }
    }

    [Token(Token = "0x600736F")]
    [Address(RVA = "0x4058750", Offset = "0x4058750", VA = "0x4058750")]
    public AssetBundleLoadAssetOperation(
      string fileName,
      Action<string> sCallback = null,
      Action<string> fCallback = null,
      bool isDependency = true)
    {
    }

    [Token(Token = "0x6007370")]
    [Address(RVA = "0x4058AE8", Offset = "0x4058AE8", VA = "0x4058AE8", Slot = "8")]
    public override bool IsDone() => new bool();

    [Token(Token = "0x6007371")]
    [Address(RVA = "0x4058B84", Offset = "0x4058B84", VA = "0x4058B84", Slot = "7")]
    public override bool Execute() => new bool();
  }
}
