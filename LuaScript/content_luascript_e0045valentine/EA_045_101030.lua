Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Elaine()
  load_image("EA_045_101030", "content_still_20101045_image", "201010450_StillImage")
  show_image("EA_045_101030", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Elaine,"Shy")
  open_speech_window("CHRNAME_ELAINE", Elaine, nil)

  message("EA_045_1010300001")
  message("EA_045_1010300002")
  change_face(Elaine,"Sad")
  message("EA_045_1010300003")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Elaine_preload()
  load_image_preload("EA_045_101030", "content_still_20101045_image", "201010450_StillImage")
end
