Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript__sample", "label_camera")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室
	
	Camera01 = set_camera(LABEL_CAMERA_POSROTFOV)
	set_camera_lookat(Camera01, LABEL_CAMERA_LOOKAT)
	
	setup_Lancelot({0.000, 0.0, -5.440, 0.0})
	
	setup_Noir({1.050, 0.0, -1.610, 180.0})
	motion(Noir, "Sri_Sit_loop_m", 0.0, 1.0, true)
	
	setup_Guinevere({-1.430, 0.0,  0.050, 180.0})
	motion(Guinevere, "Nbl_Sit_loop_f", 0.0, 1.0, true)
	
	MobGirl01	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl02	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl03	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
	
	-- 適当なpngファイルをロード
	load_image("unit1901", "content_still_10101002_image", "101010020_StillImage")
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)
	
	open_narration_window()
	message_direct("2DImage操作テスト")
	close_narration_window()
	local signal
	
	signal = show_image("unit1901", 0.0, 0.0, 0.5)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	open_narration_window()
	message_direct("x:480へLinearで移動")
	close_narration_window()

	signal = move_to_image(480, 0, 1, "Linear")
	while signal.IsProccessing() do
		coroutine.yield()
	end

	open_narration_window()
	message_direct("x:-240へEaseInで移動")
	close_narration_window()
	signal = move_to_image(-240, 0, 1, "EaseIn")
	while signal.IsProccessing() do
		coroutine.yield()
	end

	open_narration_window()
	message_direct("x: 0.5 y :0.5にEaseOutで縮小")
	close_narration_window()
	signal = scale_to_image(0.5, 0.5, 2, "EaseOut")
	while signal.IsProccessing() do
		coroutine.yield()
	end

	open_narration_window()
	message_direct("x:2 y:2にEaseInOutで拡大")
	close_narration_window()
	signal = scale_to_image(2, 2, 2, "EaseInOut")
	while signal.IsProccessing() do
		coroutine.yield()
	end

	open_narration_window()
	message_direct("position x:0 scale x:1 y:1に即時変更")
	close_narration_window()

	set_position_image(0, 0)
	set_scale_image(1, 1)

	wait_time(2)

	open_narration_window()
	message_direct("グレースケールテスト")
	close_narration_window()

	on_screencolor("#FFFFFF", 0, -100)
	wait_time(2)
	off_screencolor()

	open_narration_window()
	message_direct("カメラフレーム1テスト")
	close_narration_window()

	on_cameraframe(1)
	wait_time(2)
	off_cameraframe()


	open_narration_window()
	message_direct("スチル消去")
	close_narration_window()

	hide_image(0)

	open_narration_window()
	message_direct("マスクoff Bg off テスト")
	close_narration_window()

	signal = show_image("unit1901", 0.0, 0.0, 0.5, false, false)
	set_scale_image(2, 2)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	open_narration_window()
	message_direct("スチル消去")
	close_narration_window()

	hide_image(0)

	open_narration_window()
	message_direct("マスクon Bg off テスト")
	close_narration_window()

	signal = show_image("unit1901", 0.0, 0.0, 0.5, true, false)
	set_scale_image(2, 2)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	open_narration_window()
	message_direct("スチル消去")
	close_narration_window()

	hide_image(0)

	open_narration_window()
	message_direct("マスクoff Bg on テスト")
	close_narration_window()

	signal = show_image("unit1901", 0.5, 0.0, 0.5, false, true)
	set_scale_image(1, 1)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	open_narration_window()
	message_direct("終了")
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
	setup_Lancelot_preload({0.000, 0.0, -5.440, 0.0})
	setup_Noir_preload({1.050, 0.0, -1.610, 180.0})
	setup_Guinevere_preload({-1.430, 0.0,  0.050, 180.0})
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
	load_image_preload("unit1901", "content_still_10101002_image", "101010020_StillImage")
end
