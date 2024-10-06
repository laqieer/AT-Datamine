Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Excelia()
  load_image("EA_045_101034", "content_still_20101048_image", "201010480_StillImage")
  show_image("EA_045_101034", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Excelia,"Shy")
  open_speech_window("CHRNAME_EXCELIA", Excelia, nil)

  message("EA_045_1010340001")
  message("EA_045_1010340002")
  change_face(Excelia,"Surprise")
  message("EA_045_1010340003")
  change_face(Excelia,"Sad")
  message("EA_045_1010340004")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Excelia_preload()
  load_image_preload("EA_045_101034", "content_still_20101048_image", "201010480_StillImage")
end
