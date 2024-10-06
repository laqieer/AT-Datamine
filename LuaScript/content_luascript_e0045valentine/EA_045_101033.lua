Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Lyoness()
  load_image("EA_045_101033", "content_still_20101047_image", "201010470_StillImage")
  show_image("EA_045_101033", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Lyoness,"Shy")
  open_speech_window("CHRNAME_LYONESS", Lyoness, nil)

  message("EA_045_1010330001")
  message("EA_045_1010330002")
  change_face(Lyoness,"Smile")
  message("EA_045_1010330003")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Lyoness_preload()
  load_image_preload("EA_045_101033", "content_still_20101047_image", "201010470_StillImage")
end