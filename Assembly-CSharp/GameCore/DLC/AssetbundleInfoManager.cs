// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetbundleInfoManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x2001483")]
  [Serializable]
  public class AssetbundleInfoManager
  {
    [Token(Token = "0x4005E37")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public AssetLabelDic assetLabelDic;
    [Token(Token = "0x4005E38")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public AssetLabelLocalizeDic assetLabelLocalizeDic;
    [Token(Token = "0x4005E39")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public AssetbundleInfoDic assetbundleDic;
    [Token(Token = "0x4005E3A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public AssetbundleSplitDic assetbundleSplitDic;
    [Token(Token = "0x4005E3B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public AssetBundleCandidateForDeletionDic assetbundleCandidateForDeletionDic;
    [Token(Token = "0x4005E3C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public AssetbundleList assetbundleServicsClosedList;

    [Token(Token = "0x6007366")]
    [Address(RVA = "0x40585D0", Offset = "0x40585D0", VA = "0x40585D0")]
    public AssetbundleInfoManager()
    {
    }
  }
}
