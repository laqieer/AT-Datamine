Include("content_luascript_common","ADVSmallPack")

function Load()
  InitializeLoadActive()
  Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
  StartPlayActive()

  Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00510_010001")
  Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00510_010002")
  Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00510_010003")
  Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00510_010004")





  CloseTalkWindow()

  EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end
