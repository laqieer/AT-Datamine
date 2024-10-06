// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.StartCostAPButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Common;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003788")]
  [AddComponentMenu("Scenes/OutGame/Battle/StartCostAPButton")]
  public class StartCostAPButton : MonoBehaviour
  {
    [Token(Token = "0x400F28D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400F28E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeReference]
    private StartCostAPButton.StatusBoard[] statusBoards;

    [Token(Token = "0x17004868")]
    public CommonButton Button
    {
      [Token(Token = "0x6015DEE"), Address(RVA = "0x231EF78", Offset = "0x231EF78", VA = "0x231EF78")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x6015DEF")]
    [Address(RVA = "0x231EF80", Offset = "0x231EF80", VA = "0x231EF80")]
    public void SetAP(int ap)
    {
    }

    [Token(Token = "0x6015DF0")]
    [Address(RVA = "0x231F028", Offset = "0x231F028", VA = "0x231F028")]
    public void SetFreeRemain(int remain)
    {
    }

    [Token(Token = "0x6015DF1")]
    [Address(RVA = "0x231F0CC", Offset = "0x231F0CC", VA = "0x231F0CC")]
    public StartCostAPButton()
    {
    }

    [Token(Token = "0x2003789")]
    public enum CostType
    {
      [Token(Token = "0x400F290")] Free,
      [Token(Token = "0x400F291")] AP,
    }

    [Token(Token = "0x200378A")]
    [Serializable]
    private abstract class StatusBoard
    {
      [Token(Token = "0x400F292")]
      [FieldOffset(Offset = "0x10")]
      public GameObject root;

      [Token(Token = "0x6015DF2")]
      public abstract void SetNumber(int number);

      [Token(Token = "0x6015DF3")]
      [Address(RVA = "0x231F0D4", Offset = "0x231F0D4", VA = "0x231F0D4")]
      protected StatusBoard()
      {
      }
    }

    [Token(Token = "0x200378B")]
    [Serializable]
    private class CostFreeBoard : StartCostAPButton.StatusBoard
    {
      [Token(Token = "0x400F293")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private Text textRemain;

      [Token(Token = "0x6015DF4")]
      [Address(RVA = "0x231F0DC", Offset = "0x231F0DC", VA = "0x231F0DC", Slot = "4")]
      public override void SetNumber(int number)
      {
      }

      [Token(Token = "0x6015DF5")]
      [Address(RVA = "0x231F124", Offset = "0x231F124", VA = "0x231F124")]
      public CostFreeBoard()
      {
      }
    }

    [Token(Token = "0x200378C")]
    [Serializable]
    private class CostAPBoard : StartCostAPButton.StatusBoard
    {
      [Token(Token = "0x400F294")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private DotArrayView apView;

      [Token(Token = "0x6015DF6")]
      [Address(RVA = "0x231F12C", Offset = "0x231F12C", VA = "0x231F12C", Slot = "4")]
      public override void SetNumber(int number)
      {
      }

      [Token(Token = "0x6015DF7")]
      [Address(RVA = "0x231F148", Offset = "0x231F148", VA = "0x231F148")]
      public CostAPBoard()
      {
      }
    }
  }
}
