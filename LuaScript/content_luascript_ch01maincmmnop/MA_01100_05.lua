Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)

	ShowGlobalMenuButton(false)
	disableTextBox = true

	movie_load("MA_01100_04_02")
	--load_sound("SE_ADV_Movie")
	movie_set_active(true)
	movie_play()

	load_sound("BGM_ADV_Mountain")
	
end

-- シーケンスの実行
function Play()

	fadein(0)
	Play_start(true)
	SetTrackingId(33)

	movie_wait_playing()
	movie_stop()

	movie_load("MA_01100_05_02")
	--load_sound("SE_ADV_Movie")
	movie_set_active(true)
	bgm_play("BGM_ADV_Mountain")
	movie_play()
	movie_wait_playing()
	movie_stop()
	
	wait_time(2.0)
	
	disableTextBox = false
	open_textbox_base()
	open_simple_window("CHRNAME_NOIR", nil, nil)
	message("MA_01100_059001")
	close_simple_window()
	SetTrackingId(34)
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	disableTextBox = true
	movie_load_preload("MA_01100_04_02")
	preload_sound("BGM_ADV_Mountain")
end
