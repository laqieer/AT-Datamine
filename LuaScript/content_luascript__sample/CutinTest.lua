Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室

	setup_101009_Noir({-1.163, 0, -4.793, 0}, "Com_Std01_Loop_m", 0, true)
	setup_101010_Lancelot({-0.07, 0, -5.554, 0}, "Col_Std02_Loop_m", 0, true)
	setup_101011_Guinevere({2.427, 0, -1.48, 180}, "Com_Sit02_Loop_f", 0, true)

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	open_narration_window()
	message_direct("カットイン１")
	close_narration_window()

	open_cutin(1, 2)
	on_cutin(1, Noir, "Surprise")

	wait_cutin_animation()

	open_narration_window()
	message_direct("カットイン1 Close")
	close_narration_window()

	close_cutin()

	wait_cutin_animation()

	open_narration_window()
	message_direct("カットイン2")
	close_narration_window()

	open_cutin(2, 2)
	on_cutin(1, Noir, "Surprise")
	on_cutin(2, Lancelot, "Surprise")


	open_narration_window()
	message_direct("カットイン2 Close")
	close_narration_window()

	close_cutin()

	open_narration_window()
	message_direct("カットイン3")
	close_narration_window()


	open_cutin(3, 2)
	on_cutin(1, Noir, "Smile", false)
	on_cutin(2, Lancelot, "Surprise", nil)
	on_cutin(3, Guinevere, "Surprise", true)


	open_narration_window()
	message_direct("カットイン3 Close")
	close_narration_window()

	close_cutin()

	open_narration_window()
	message_direct("カットイン１-１")
	close_narration_window()

	open_cutin(1, 1)
	off_cutin(1)

	open_narration_window()
	message_direct("Noir On")
	close_narration_window()

	on_cutin(1, Noir, "Smile", false)

	open_narration_window()
	message_direct("カットイン１-１ Close")
	close_narration_window()

	close_cutin()

	open_narration_window()
	message_direct("カットイン１-２")
	close_narration_window()

	open_cutin(1, 2)
	on_cutin(1, Noir, "Smile", true)

	open_narration_window()
	message_direct("カットイン１-２ Close")
	close_narration_window()

	close_cutin()

	open_narration_window()
	message_direct("カットイン１-３")
	close_narration_window()

	open_cutin(1, 3)
	on_cutin(1, Noir, "Smile", false)

	open_narration_window()
	message_direct("カットイン１-３ Close")
	close_narration_window()

	close_cutin()

	open_narration_window()
	message_direct("終了します")
	close_narration_window()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110011)
	setup_101009_Noir_preload({-1.163, 0, -4.793, 0}, "Com_Std01_Loop_m", 0, true)
	setup_101010_Lancelot_preload({-0.07, 0, -5.554, 0}, "Col_Std02_Loop_m", 0, true)
	setup_101011_Guinevere_preload({2.427, 0, -1.48, 180}, "Com_Sit02_Loop_f", 0, true)
end
