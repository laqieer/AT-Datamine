Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	fadeout(0.0, 0.0, 0.0, 1.0, 0.0)
	load_ui()
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera06_1 = set_camera(-0.403, 1.419, -4.446, -8.837, 146.884, -0.336, 35)

	setup_Lancelot({0.000, 0.0, -5.440, 0.0})

end

-- シーケンスの実行
function Play()
	on_camera(Camera06_1)
	motion(Lancelot, "Col_Std_talk01_loop_m", 0.1, 1.0, true)

	fadein(2.0)
	wait_time(2.0)

	while true do
		open_select_window_direct(Lancelot, "Normal", "表情タグ「Normal」", "表情タグ「Sad」", "表情タグ「Smile」", "表情タグ「Anger」", "次へ")
		if is_select(1) then
			change_face(Lancelot, "Normal")
		elseif is_select(2) then
			change_face(Lancelot, "Sad")
		elseif is_select(3) then
			change_face(Lancelot, "Smile")
		elseif is_select(4) then
			change_face(Lancelot, "Anger")
		else
			open_select_window_direct(Lancelot, "Normal", "表情タグ「Pain」", "表情タグ「Surprise」", "表情タグ「Serious」", "表情タグ「Shy」", "終わる")
			if is_select(1) then
				change_face(Lancelot, "Pain")
			elseif is_select(2) then
				change_face(Lancelot, "Surprise")
			elseif is_select(3) then
				change_face(Lancelot, "Serious")
			elseif is_select(4) then
				change_face(Lancelot, "Shy")
			else
				break
			end
		end
		open_speech_window("Name_Lancelot", Lancelot)
		message_direct("表情を変えました")
		close_speech_window()
	end

	fadeout(0.0, 0.0, 0.0, 1.0, 2.0)
	wait_time(2.0)

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110011", "Area110011")
	setup_Lancelot_preload({0.000, 0.0, -5.440, 0.0})
end
