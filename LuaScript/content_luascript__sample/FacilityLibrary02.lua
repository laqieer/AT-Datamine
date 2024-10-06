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
	message_direct("あら、どうしたの？")
	close_narration_window()
	
	local facility = get_facility()
	if facility.Book.Read == true then
	    open_narration_window()
    	message_direct("読み終わった本を返しますか？")
    	close_narration_window()
    else
        open_narration_window()
    	message_direct("読み終わっていない本ですが返却しますか？")
    	close_narration_window()
	end
	
	open_select_window_direct(nil, "", "はい", "いいえ")
	if is_select(1) then --はい
	    open_narration_window()
    	message_direct("演出")
    	close_narration_window()
    	
    	open_narration_window()
    	message_direct("確かに。返却を承りました。")
    	close_narration_window()
	    
	elseif is_select(2) then --いいえ
	    system.Cancel()
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
