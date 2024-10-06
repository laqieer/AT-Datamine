Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Guinevere()
  load_image("EA_045_101011", "content_still_20101033_image", "201010330_StillImage")
  show_image("EA_045_101011", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Guinevere,"Shy")
  open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)

  message("EA_045_1010110001")
  change_face(Guinevere,"Anger")
  message("EA_045_1010110002")
  change_face(Guinevere,"Shy")
  message("EA_045_1010110003")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Guinevere_preload()
  load_image_preload("EA_045_101011", "content_still_20101033_image", "201010330_StillImage")
end
