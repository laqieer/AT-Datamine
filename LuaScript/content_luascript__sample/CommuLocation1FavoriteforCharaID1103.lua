
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

function Load()
    demo_setup()
    commu = system.GetCommu()

	load_area_scene(110011) -- ノワール教室：夕晴
	CUT_CAMERA1	= set_camera({-2.45, 0.86, -0.08,   353.4, 141.99, 0,   21})
	
end
function Play()
    system.SetDefaultPlaySpeed(true)
    on_camera(CUT_CAMERA1)
    demo_start()
    

    local commuChara = commu.GetCharacter()
    local location = commu.GetLocation()
    
    open_narration_window()
    message_direct(commuChara.CharaName .. "のお気に入りの場所")
    close_narration_window()
    
    demo_end()
    system.SetDefaultPlaySpeed(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110011)
end
