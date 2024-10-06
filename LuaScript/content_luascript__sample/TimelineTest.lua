Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	load_area_scene(114041) -- 剣の祭壇
	load_duel_scene(101000011) -- デュエル背景
	--load_scene("content_areascene_110011", "Area110011") -- 教室
	
	-- タイムラインのシーンを読み込む
	load_timeline("content_adv_timeline_timelinetest_scene", "TimelineTest")
	change_duel_scene(101000011)
	
	Camera01 = set_camera(2.104817, 1.4, 11.61, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.54, 0.3, 15.64)
	
	--setup_Lancelot({0.54, 0.3, 15.64,   0.0})
end


-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)
	
	open_narration_window()
	message_direct("タイムラインテスト")
	close_narration_window()
	
	play_timeline("TimelineTest", false, fadefunc)
	change_scene("Area114041")
	
	Play_end(true)
end


function fadefunc()
	fadeout(0, 0, 0, 0, 0.3)
	wait_time(0.3)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(114041)
	load_duel_scene_preload(101000011)
	load_timeline_preload("content_adv_timeline_timelinetest_scene", "TimelineTest")
end
