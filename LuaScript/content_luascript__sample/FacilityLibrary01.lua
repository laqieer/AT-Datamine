Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
    demo_setup()
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	demo_start()
	
	open_narration_window()
	message_direct("あら、どうしたの？貸出できる本を見ていく？")
	close_narration_window()
	
	local facility = get_facility()
	if facility.ShowMenu == true then
	    local books = facility.GetBooks()
    	local item = open_menu_window(books)
    	system.SelectMenuItem(item.ID)

    	open_narration_window()
    	message_direct("「" .. item.TextValue .. "」を借りるのね？わかったわ。")
    	close_narration_window()
	end
	
	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110011", "Area110011")
end
