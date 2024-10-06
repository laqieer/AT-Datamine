Include("content_luascript_common","ADVSmallPack")

function Load()
  InitializeLoadActive()
  Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
  StartPlayActive()

	open_narration_window()
		message("AS_01_05_5021001")
		message("AS_01_05_5021002")
		message("AS_01_05_5021003")
		message("AS_01_05_5021004")
	close_narration_window()
	wait_time(1.0)

  Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_5020002")

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
