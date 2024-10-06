Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Dindrane()
  load_image("EA_045_101027", "content_still_20101042_image", "201010420_StillImage")
  show_image("EA_045_101027", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Dindrane,"Laugh")
  open_speech_window("CHRNAME_DINDRANE", Dindrane, nil)

  message("EA_045_1010270001")
  message("EA_045_1010270002")
  change_face(Dindrane,"Shy")
  message("EA_045_1010270003")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Dindrane_preload()
  load_image_preload("EA_045_101027", "content_still_20101042_image", "201010420_StillImage")
end
