// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2BranchPointController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003E9B")]
  public class Adv2BranchPointController : MonoBehaviour
  {
    [Token(Token = "0x40112B8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Adv2BranchPointParts[] parts4;
    [Token(Token = "0x40112B9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Adv2BranchPointParts[] parts5;
    [Token(Token = "0x40112BA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject part4Root;
    [Token(Token = "0x40112BB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject part5Root;
    [Token(Token = "0x40112BC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string[] part4Tags;
    [Token(Token = "0x40112BD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string[] part5Tags;
    [Token(Token = "0x40112BE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string inCommand;
    [Token(Token = "0x40112BF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string outCommand;
    [Token(Token = "0x40112C0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private string[] seNames;
    [Token(Token = "0x40112C1")]
    [FieldOffset(Offset = "0x60")]
    private Adv2Manager adv2Manager;
    [Token(Token = "0x40112C2")]
    [FieldOffset(Offset = "0x68")]
    private Adv2ProjectFilePlayer advPlayer;
    [Token(Token = "0x40112C3")]
    [FieldOffset(Offset = "0x70")]
    private int lastListCount;
    [Token(Token = "0x40112C4")]
    [FieldOffset(Offset = "0x78")]
    private Adv2BranchPointParts[] parts;
    [Token(Token = "0x40112C5")]
    [FieldOffset(Offset = "0x80")]
    private string[] tags;
    [Token(Token = "0x40112C6")]
    [FieldOffset(Offset = "0x88")]
    private Func<string, string, LuaSignalMini> inAnimPlayer;
    [Token(Token = "0x40112C7")]
    [FieldOffset(Offset = "0x90")]
    private Func<string, bool, string, LuaSignalMini> outAnimPlayer;
    [Token(Token = "0x40112C8")]
    private const string stackKey = "BranchPointController";

    [Token(Token = "0x6019335")]
    [Address(RVA = "0x2D04E84", Offset = "0x2D04E84", VA = "0x2D04E84")]
    private void Awake()
    {
    }

    [Token(Token = "0x6019336")]
    [Address(RVA = "0x2D04FC0", Offset = "0x2D04FC0", VA = "0x2D04FC0")]
    public void SetAnimPlayer(
      Func<string, string, LuaSignalMini> inAnimPlayer,
      Func<string, bool, string, LuaSignalMini> outAnimPlayer)
    {
    }

    [Token(Token = "0x6019337")]
    [Address(RVA = "0x2D04FC8", Offset = "0x2D04FC8", VA = "0x2D04FC8")]
    private Texture2D GetThumbnail(string id) => (Texture2D) null;

    [Token(Token = "0x6019338")]
    [Address(RVA = "0x2D05244", Offset = "0x2D05244", VA = "0x2D05244")]
    private LuaSignal InitializeThumbnail(
      List<Adv2BranchPointController.BranchPointData> list)
    {
      return (LuaSignal) null;
    }

    [Token(Token = "0x6019339")]
    [Address(RVA = "0x2D056B4", Offset = "0x2D056B4", VA = "0x2D056B4")]
    public LuaSignal Command(string command, string textId) => (LuaSignal) null;

    [Token(Token = "0x601933A")]
    [Address(RVA = "0x2D05C18", Offset = "0x2D05C18", VA = "0x2D05C18")]
    public Adv2BranchPointController()
    {
    }

    [Token(Token = "0x2003E9C")]
    public class BranchPointData
    {
      [Token(Token = "0x40112C9")]
      [FieldOffset(Offset = "0x10")]
      public string CharacterId;
      [Token(Token = "0x40112CA")]
      [FieldOffset(Offset = "0x18")]
      public int Point;
      [Token(Token = "0x40112CB")]
      [FieldOffset(Offset = "0x1C")]
      public AdvVariableTypeEnum Kind;
      [Token(Token = "0x40112CC")]
      [FieldOffset(Offset = "0x20")]
      public AdvArithmeticTypeEnum ArithmeticType;

      [Token(Token = "0x601933B")]
      [Address(RVA = "0x2D05C20", Offset = "0x2D05C20", VA = "0x2D05C20")]
      public BranchPointData(AdvProcessOneData data)
      {
      }

      [Token(Token = "0x601933C")]
      [Address(RVA = "0x2D05D40", Offset = "0x2D05D40", VA = "0x2D05D40")]
      public BranchPointData(AdvOptionOneData data)
      {
      }

      [Token(Token = "0x601933D")]
      [Address(RVA = "0x2D05D30", Offset = "0x2D05D30", VA = "0x2D05D30")]
      private void SetParameter(
        string id,
        int point,
        AdvVariableTypeEnum kind,
        AdvArithmeticTypeEnum arithmeticType)
      {
      }

      [Token(Token = "0x601933E")]
      [Address(RVA = "0x2D05C68", Offset = "0x2D05C68", VA = "0x2D05C68")]
      private string ToCharaId(int id) => (string) null;
    }
  }
}
